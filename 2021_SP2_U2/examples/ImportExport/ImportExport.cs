using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TS3D.Exchange;
using TS3D.Exchange.Direct;

namespace ImportExport
{
    class Program
    {   
        static void PrintUsage() {
            Console.WriteLine( "ImportExport [--exchange <exchange_bin_folder>] <input> <output>");
        }

        static void Main(string[] args)
        {   
            string exchange_folder = null;
            string input_file = null;
            string output_file = null;
            for(var arg = 0; arg < args.Length; ++arg ) {
                if( arg < args.Length-1 ) {
                    if( args[arg] == "--exchange" ) {
                        exchange_folder = args[++arg];
                        continue;
                    }
                }
                if( null == input_file ) {
                    input_file = args[arg];
                } else if( null == output_file ) {
                    output_file = args[arg];
                } else {
                    Console.WriteLine("Too many arguments.");
                    PrintUsage();
                    return;
                }
            }

            if( null == input_file || null == output_file ) {
                Console.WriteLine("Please specify input and output files." );
                PrintUsage();
                return;
            }

            try {
                Library.Initialize( HOOPS_LICENSE.KEY, exchange_folder );
            } catch( Library.InitializationException e ) {
                Console.WriteLine( e.Message );
                return;
            }

            A3DRWParamsLoadData load_params;
            API.Initialize(out load_params);
            load_params.m_sGeneral.m_bReadSolids = true;
            load_params.m_sGeneral.m_bReadSurfaces = true;
            load_params.m_sGeneral.m_bReadWireframes = true;
            load_params.m_sGeneral.m_bReadPmis = true;
            load_params.m_sGeneral.m_bReadAttributes = true;
            load_params.m_sGeneral.m_bReadHiddenObjects = true;
            load_params.m_sGeneral.m_bReadConstructionAndReferences = false;
            load_params.m_sGeneral.m_bReadActiveFilter = true;
            load_params.m_sGeneral.m_eReadingMode2D3D = A3DEReadingMode2D3D.kA3DRead_3D;
            load_params.m_sGeneral.m_eReadGeomTessMode = A3DEReadGeomTessMode.kA3DReadGeomAndTess;
            load_params.m_sGeneral.m_eDefaultUnit = A3DEUnits.kA3DUnitUnknown;
            load_params.m_sTessellation.m_eTessellationLevelOfDetail = A3DETessellationLevelOfDetail.kA3DTessLODMedium;
            load_params.m_sAssembly.m_bUseRootDirectory = true;
            load_params.m_sMultiEntries.m_bLoadDefault = true;
            load_params.m_sPmi.m_bAlwaysSubstituteFont = false;
            load_params.m_sPmi.m_pcSubstitutionFont = "Myriad CAD";

            IntPtr model_file;
            if(A3DStatus.A3D_SUCCESS != API.A3DAsmModelFileLoadFromFile(input_file, ref load_params, out model_file )) {
                Console.WriteLine( "Failed to load input file." );
                return;
            }
            
            var foo = API.A3DMiscGetEntityTypeMsg( A3DEEntityType.kA3DTypeAsmModelFile );
            Console.WriteLine( Marshal.PtrToStringUTF8( foo ) );
            
            A3DStatus write_status = A3DStatus.A3D_SUCCESS;
            switch( GetModellerType( output_file ) ) {
                case A3DEModellerType.kA3DModellerIges:
                {
                    A3DRWParamsExportIgesData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToIgesFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerStep:
                {
                    A3DRWParamsExportStepData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToStepFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerJt:
                {
                    A3DRWParamsExportJTData d;
                    API.Initialize( out d );
                    d.m_eWriteGeomTessMode = A3DEWriteGeomTessMode.kA3DWriteGeomAndTess;
                    d.m_bWritePMI = true;
                    write_status = API.A3DAsmModelFileExportToJTFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerStl:
                {
                    A3DRWParamsExportStlData d;
                    API.Initialize( out d );
                    d.m_eTessellationLevelOfDetail = A3DETessellationLevelOfDetail.kA3DTessLODMedium;
                    write_status = API.A3DAsmModelFileExportToStlFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerXML:
                {
                    A3DRWParamsExportXMLData d;
                    API.Initialize( out d );
                    d.m_bExportMetadata=true;
                    d.m_bExportTransformations=true;
                    d.m_bExportColorMaterial=true;
                    d.m_bExportProductInformationByFormat = false;
                    write_status = API.A3DAsmModelFileExportToXMLFile( model_file, ref d, output_file, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero );
                    break;
                }
                case A3DEModellerType.kA3DModellerU3D:
                {
                    A3DRWParamsExportU3DData d;
                    API.Initialize( out d );
                    d.m_eU3DVersion = A3DEU3DVersion.kA3DECMA3;
                    write_status = API.A3DAsmModelFileExportToU3DFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerPrc:
                {
                    A3DRWParamsExportPrcData d;
                    API.Initialize( out d );
                    d.m_eCompressBrepType = A3DECompressBrepType.kA3DCompressionMedium;
                    IntPtr prc_write_helper = IntPtr.Zero;
                    write_status = API.A3DAsmModelFileExportToPrcFile( model_file, ref d, output_file, out prc_write_helper );
                    break;
                }
                case A3DEModellerType.kA3DModeller3mf:
                {
                    A3DRWParamsExport3mfData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportTo3mfFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerOBJ:
                {
                    A3DRWParamsExportObjData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToObjFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerFBX:
                {
                    A3DRWParamsExportFbxData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToFbxFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerParasolid:
                {
                    A3DRWParamsExportParasolidData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToParasolidFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerAcis:
                {
                    A3DRWParamsExportAcisData d;
                    API.Initialize( out d );
                    write_status = API.A3DAsmModelFileExportToAcisFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModellerScs:
                {
                    // A3DRWParamsExportScsData d;
                    // API.Initialize( out d );
                    // write_status = API.A3DAsmModelFileExportToScsFile( model_file, ref d, output_file );
                    break;
                }
                case A3DEModellerType.kA3DModeller3dHtml:
                {
                    // A3DRWParamsExportHtmlData d;
                    // API.Initialize( out d );
                    // write_status = API.A3DAsmModelFileExportToHtmlFile( model_file, ref d, output_file );
                    break;
                }
                default:
                {
                    break;
                }
            }

            if( A3DStatus.A3D_SUCCESS == write_status ) {
                Console.WriteLine( "Success." );
            } else {
                Console.WriteLine( "Failure." );
            }
        }

        static private A3DEModellerType GetModellerType( string fn ) {
            if( fn.EndsWith("IGS", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("IGS", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerIges;
            } else if( fn.EndsWith("STP", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("STEP", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("STPZ", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerStep;
            } else if( fn.EndsWith("U3D", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerU3D;
            } else if( fn.EndsWith("X_T", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("XMT_TXT", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerParasolid;
            } else if( fn.EndsWith("PRC", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerPrc;
            } else if( fn.EndsWith("JT", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerJt;
            } else if( fn.EndsWith("WRL", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("VRML", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerWrl;
            } else if( fn.EndsWith("STL", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerStl;
            } else if( fn.EndsWith("SAT", StringComparison.OrdinalIgnoreCase ) || fn.EndsWith("SAB", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerAcis;
            } else if( fn.EndsWith("XML", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerXML;
            } else if( fn.EndsWith("3MF", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModeller3mf;
            } else if( fn.EndsWith("SCS", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerScs;
            } else if( fn.EndsWith("HTML", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModeller3dHtml;
            } else if( fn.EndsWith("OBJ", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerOBJ;
            } else if( fn.EndsWith("FBX", StringComparison.OrdinalIgnoreCase ) ) {
                return A3DEModellerType.kA3DModellerFBX;
            }
            return A3DEModellerType.kA3DModellerUnknown;
        }
    }
}
