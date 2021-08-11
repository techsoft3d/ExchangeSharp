
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
        private static string[] ExtraLibraryNames = {
            "libTD_Alloc.so",
            "liblibcrypto.so",
            "libTD_Root.so",
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
            "libtbb.so",
            "TB_Common.tx",
            "TB_Base.tx",
            "libTD_BrepBuilderFiller.so",
            "TB_Geometry.tx",
            "TB_GeometryUtils.tx",
            "TB_Database.tx",
            "TB_HostObj.tx",
            "TB_Family.tx",
            "TB_MEP.tx",
            "TB_Architecture.tx",
            "TB_Analytical.tx",
            "TB_StairsRamp.tx",
            "TB_Rebar.tx",
            "TB_Main.tx",
            "libTD_BrepRenderer.so",
            "TB_ModelerGeometry.tx",
            "RasterProcessor.tx",
            "libTD_AcisBuilder.so",
            "ModelerGeometry.tx",
            "liblibBuffer.so",
            "libTD_Gs.so",
            "OdOleSsItemHandler.tx",
            "TB_LoaderBase.tx",
            "TB_ExLabelUtils.tx",
            "TB_FormatCommonClasses.tx",
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
            "TB_Format2020Writers.tx",
            "TB_Loader.tx",
            "RxRasterServices.tx",
            "TD_FtFontEngine.tx"
        };

        static private IntPtr LibraryHandle;
        static private List<IntPtr> ExtraLibraryHandles;

        static public string GetExchangeBinPath( string exchange_root_folder ) {
            string arch_name = null;
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                arch_name = "win64";
            } else if( RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ) {
                arch_name = "osx64";
            } else if( RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                arch_name = "linux64";
            }
            
            return Path.Combine( exchange_root_folder, "bin", arch_name );
        }

        static public string GetLibraryName() {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                return "A3DLIBS.dll";
            } else if( RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ) {
                return "libA3DLIBS.dylib";
            } else if( RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                return "libA3DLIBS.so";
            }
            return "unknown_platform";
        }

        static internal IntPtr LoadLibrary(string path) {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                var handle = dlopen(path, RTLD_LAZY | RTLD_GLOBAL);
                if(handle.Equals(IntPtr.Zero)) {
                    throw new DllNotFoundException("Unable to find DLL: " + path);
                }
                return handle;
            }
            
            return NativeLibrary.Load( path );
        }

#region dlopen
        private const int RTLD_LAZY = 0x00001; //Only resolve symbols as needed
        private const int RTLD_GLOBAL = 0x00100; //Make symbols available to libraries loaded later
        [DllImport("dl")]
        private static extern IntPtr dlopen (string file, int mode);
#endregion

        static public bool Load( string exchange_bin_folder ) {
            if( LibraryHandle != IntPtr.Zero ) {
                return false;
            }

            if( null == exchange_bin_folder ) {
                exchange_bin_folder = "";
            }
            
            string library_name = GetLibraryName();
            string [] extra_libraries = null;
            if( RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                extra_libraries = ExtraLibraryNames;
            }
            try {
                if( null != extra_libraries ) {
                    ExtraLibraryHandles = new List<IntPtr>();
                    foreach( var extra_library in extra_libraries ) {
                        var extra_lib_path = Path.Combine(exchange_bin_folder, extra_library);
                        if (File.Exists(extra_lib_path)) {
                            ExtraLibraryHandles.Add(LoadLibrary(extra_lib_path));
                        }
                    }
                }
                LibraryHandle = LoadLibrary( Path.Combine( exchange_bin_folder, library_name ) );
            } catch( DllNotFoundException ) {
                return false;
            }
            return true;
        }

        static public void Free( ) {
            NativeLibrary.Free( LibraryHandle );

            if( null != ExtraLibraryHandles ) {
                foreach( var handle in ExtraLibraryHandles ) {
                    NativeLibrary.Free( handle );
                }
                ExtraLibraryHandles = null;
            }
        }

        static public bool IsLoaded {
            get {
                return LibraryHandle != IntPtr.Zero;
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

            if( major_version != VERSION.DLL_MAJORVERSION || minor_version != VERSION.DLL_MINORVERSION ) {
                var sb = new StringBuilder();
                sb.AppendLine("The DLL version does not match the C# version." );
                sb.AppendLine(
                    "DLL: (" + major_version + ", " + minor_version + ")"
                    + " != " + 
                    "C# (" + VERSION.DLL_MAJORVERSION + ", " + VERSION.DLL_MINORVERSION + ")");
                throw new InitializationException( sb.ToString() );
            }

            if( A3DStatus.A3D_SUCCESS != API.A3DDllInitialize( major_version, minor_version ) ) {
                throw new InitializationException("Failed to initialize the Exchange DLL." );
            }
        }

        public delegate IntPtr PFA3DGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string fcn_spelling, UInt32 apI_flags);
        static private PFA3DGetProcAddress _A3DGetProcAddress;
        static public PFA3DGetProcAddress A3DGetProcAddress {
            get {
                if( null == _A3DGetProcAddress) {
                    var fcn = NativeLibrary.GetExport( LibraryHandle, "A3DGetProcAddress" );
                    _A3DGetProcAddress = Marshal.GetDelegateForFunctionPointer<PFA3DGetProcAddress>( fcn );
                }
                return _A3DGetProcAddress;
            }
        }
    }
}
