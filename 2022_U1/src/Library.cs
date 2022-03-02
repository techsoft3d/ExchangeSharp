
using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;


namespace TS3D.Exchange
{
    using Direct;
    public class Library
    {        
        private static string[] _ExtraLibraryNames = {
             "libTD_Alloc.so",
             "liblibcrypto.so",
             "libTD_Root.so",
             "TD_AssetXMLParser.tx",
             "libTD_Ge.so",
             "libTD_SpatialIndex.so",
             "libTD_Gi.so",
             "libTD_DbRoot.so",
             "libTD_DbCore.so",
             "SCENEOE.tx",
             "ACCAMERA.tx",
             "ISM.tx",
             "TD_DbEntities.tx",
             "AcMPolygonObj15.tx",
             "WipeOut.tx",
             "ATEXT.tx",
             "RText.tx",
             "libTD_Db.so",
             "TD_DbIO.tx",
             "RecomputeDimBlock.tx",
             "AcIdViewObj.tx",
             "TD_TfCore.tx",
             "liboless.so",
             "libTD_Zlib.so",
             "libTD_BrepBuilder.so",
             "libTD_Br.so",
             "libOdBrepModeler.so",
             "ThreadPool.tx",
             "libTD_tbb.so",
             "TB_Common.tx",
             "TB_Base.tx",
             "libTD_BrepBuilderFiller.so",
             "TB_Geometry.tx",
             "TB_GeometryUtils.tx",
             "TB_Database.tx",
             "TB_Essential.tx",
             "TB_HostObj.tx",
             "TB_Family.tx",
             "TB_MEP.tx",
             "TB_Architecture.tx",
             "TB_Analytical.tx",
             "TB_Structural.tx",
             "TB_StairsRamp.tx",
             "TB_Rebar.tx",
             "TB_Main.tx",
             "libTD_BrepRenderer.so",
             "TB_ExportUtils.tx",
             "TB_ModelerGeometry.tx",
             "RasterProcessor.tx",
             "ModelerGeometry.tx",
             "libTD_AcisBuilder.so",
             "liblibBuffer.so",
             "libTD_Gs.so",
             "OdOleSsItemHandler.tx",
             "TB_LoaderBase.tx",
             "TB_ExLabelUtils.tx",
             "TB_FormatCommonClasses.tx",
             "TB_Format2021Classes.tx",
             "TB_Format2020Classes.tx",
             "TB_Format2019Classes.tx",
             "TB_Format2018Classes.tx",
             "TB_Format2017Classes.tx",
             "TB_Format2016Classes.tx",
             "TB_Format2015Classes.tx",
             "TB_Format2014Classes.tx",
             "TB_Format2013Classes.tx",
             "TB_Format2012Classes.tx",
             "TB_Format2011Classes.tx",
             "TB_FormatCommonReaders.tx",
             "TB_Format2021Readers.tx",
             "TB_Format2020Readers.tx",
             "TB_Format2019Readers.tx",
             "TB_Format2018Readers.tx",
             "TB_Format2017Readers.tx",
             "TB_Format2016Readers.tx",
             "TB_Format2015Readers.tx",
             "TB_Format2014Readers.tx",
             "TB_Format2013Readers.tx",
             "TB_Format2012Readers.tx",
             "TB_Format2011Readers.tx",
             "TB_Format2021Writers.tx",
             "TB_Loader.tx",
             "RxRasterServices.tx"
        };

        static internal IntPtr _LibraryHandle;
        static internal List<IntPtr> _ExtraLibraryHandles;

        static internal bool IsLinux() {
            return RuntimeInformation.IsOSPlatform( OSPlatform.Linux );
        }
        static internal bool IsMacOS() {
            return RuntimeInformation.IsOSPlatform( OSPlatform.OSX );
        }
        static internal bool IsWindows() {
            return RuntimeInformation.IsOSPlatform( OSPlatform.Windows );
        }

        static public string GetLibraryName() {
            if( IsWindows() ) {
                return "A3DLIBS.dll";
            } else if( IsMacOS() ) {
                return "libA3DLIBS.dylib";
            } else if( IsLinux() ) {
                return "libA3DLIBS.so";
            }
            throw new InvalidOperationException("Unable to determine library name for this platform.");
        }

        static internal IntPtr LoadLibrary(string path) {
            IntPtr handle = IntPtr.Zero;
            if( IsWindows() ) {
                handle = LoadLibraryEx( path, IntPtr.Zero, LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH );
            } else {
                handle = dlopen(path, RTLD_LAZY | RTLD_GLOBAL );
            }
            if(handle.Equals(IntPtr.Zero)) {
                throw new DllNotFoundException("Unable to find DLL: " + path);
            }

            return handle;
        }

        static internal IntPtr GetSymbolAddress( string symbol ) {
            if( IsWindows() ) {
                return GetProcAddress( _LibraryHandle, symbol );
            }

            return dlsym( _LibraryHandle, symbol );
        }

        static internal bool UnLoadLibrary(IntPtr handle) {
            if( IsWindows() ) {
                return FreeLibrary( handle );
            } else {
                return 0 == dlclose( handle );
            }
        }

#region dl
#region dlopen
        private const int RTLD_LAZY = 0x00001; //Only resolve symbols as needed
        private const int RTLD_GLOBAL = 0x00100; //Make symbols available to libraries loaded later
        [DllImport("dl")]
        private static extern IntPtr dlopen (string file, int mode);
#endregion
#region dlsym
        [DllImport("dl")]
        private static extern IntPtr dlsym(IntPtr handle, string symbol);
#endregion
#region dlclose
        [DllImport("dl")]
        private static extern int dlclose(IntPtr handle);
#endregion
#endregion
#region kernel32
#region LoadLibraryEx
		[System.Flags]
		private enum LoadLibraryFlags : uint
		{
			DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
			LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
			LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
			LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
			LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
			LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200,
			LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000,
			LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100,
			LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800,
			LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400,
			LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);

#endregion
#region GetProcAddress
        [DllImport("kernel32.dll")]
        static private extern IntPtr GetProcAddress(IntPtr handle, string symbol);
#endregion
#region FreeLibrary
        [DllImport("kernel32.dll")]
        static private extern bool FreeLibrary(IntPtr handle);
#endregion
#endregion

        internal delegate IntPtr PFA3DGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string fcn_spelling, UInt32 apI_flags);

        static public bool Load( string exchange_bin_folder ) {
            if( _LibraryHandle != IntPtr.Zero ) {
                return false;
            }

            if( null == exchange_bin_folder ) {
                exchange_bin_folder = "";
            }
            
            string library_name = GetLibraryName();
            string [] extra_libraries = null;
            if( IsLinux() ) {
                extra_libraries = _ExtraLibraryNames;
            }

            try {
                if( null != extra_libraries ) {
                    _ExtraLibraryHandles = new List<IntPtr>();
                    foreach( var extra_library in extra_libraries ) {
                        var extra_lib_path = Path.Combine( exchange_bin_folder, extra_library );
                        if( File.Exists( extra_lib_path ) ) {
                            _ExtraLibraryHandles.Add( LoadLibrary( extra_lib_path ) );
                        }
                    }
                }
                _LibraryHandle = LoadLibrary( Path.Combine( exchange_bin_folder, library_name ) );
            } catch( DllNotFoundException ) {
                return false;
            }
            var sym = GetSymbolAddress("A3DGetProcAddress");
            var A3DGetProcAddress = Marshal.GetDelegateForFunctionPointer<PFA3DGetProcAddress>(sym);
            var fields = typeof(API).GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            foreach (var field in fields) {
                var fcn_ptr = A3DGetProcAddress(field.Name, 1);
                var val = Marshal.GetDelegateForFunctionPointer(fcn_ptr, field.FieldType);
                field.SetValue(null, val);
            }

            return true;
        }

        static public void Free( ) {
            UnLoadLibrary( _LibraryHandle );

            if( null != _ExtraLibraryHandles ) {
                foreach( var handle in _ExtraLibraryHandles ) {
                    UnLoadLibrary( handle );
                }
                _ExtraLibraryHandles = null;
            }
        }

        static public bool IsLoaded {
            get {
                return _LibraryHandle != IntPtr.Zero;
            }
        }

        public class InitializationException : Exception {
            public InitializationException() : base() {}
            public InitializationException(string message) : base( message ) {}
        }

        static public void Initialize( string hoops_license, string bin_folder ) {
            if( !Library.Load( bin_folder ) ) {
                var sb = new StringBuilder();
                sb.AppendLine( "Unable to load Exchange." );
                if( null == bin_folder ) {
                    sb.AppendLine("Because a folder was not specified, the platform-specific library");
                    sb.AppendLine("search method was used. For this to work, you must ensure the");
                    sb.AppendLine("Exchange library " + Library.GetLibraryName() + " can be found.");
                } else {
                    sb.AppendLine( Path.Combine( bin_folder, Library.GetLibraryName() ) );
                    sb.AppendLine( "Please check the path you specified." );
                }
                throw new InitializationException( sb.ToString() );
            }

            if(A3DStatus.A3D_SUCCESS != API.A3DLicPutUnifiedLicense(hoops_license) ) {
                throw new InitializationException("Unable to unlock HOOPS Exchange." );
            }

            int major_version, minor_version;
            if(A3DStatus.A3D_SUCCESS != API.A3DDllGetVersion( out major_version, out minor_version ) ) {
                throw new InitializationException("Unable to retrieve DLL version information." );
            }

            if( major_version != Constants.A3D_DLL_MAJORVERSION || minor_version != Constants.A3D_DLL_MINORVERSION ) {
                var sb = new StringBuilder();
                sb.AppendLine("The DLL version does not match the C# version." );
                sb.AppendLine(
                    "DLL: (" + major_version + ", " + minor_version + ")"
                    + " != " + 
                    "C# (" + Constants.A3D_DLL_MAJORVERSION + ", " + Constants.A3D_DLL_MINORVERSION + ")");
                throw new InitializationException( sb.ToString() );
            }

            var init_result = API.A3DDllInitialize( major_version, minor_version );
            if( A3DStatus.A3D_SUCCESS != init_result ) {
                throw new InitializationException("Failed to initialize the Exchange DLL: " + Marshal.PtrToStringAnsi( API.A3DMiscGetErrorMsg( init_result ) ) );
            }
        }
    }
}


