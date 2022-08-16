using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TS3D.Exchange;
using TS3D.Exchange.Direct;

namespace CallbacksReport
{
    class Program
    {   

        public static int MessageCallback( string message ) {
            Console.Write( "[INFO] " + message );
            return 0;
        }

        public static int WarningCallback( string message ) {
            Console.Write( "[WARN] " + message );
            return 0;
        }
        public static int ErrorCallback( string message ) {
            Console.Write( "[ERR] " + message );
            return 0;
        }
        static void Main(string[] args)
        {   
            string exchange_folder = null;
            string input_file = null;
            for(var arg = 0; arg < args.Length; ++arg ) {
                if( arg < args.Length-1 ) {
                    if( args[arg] == "--exchange" ) {
                        exchange_folder = args[++arg];
                        continue;
                    }
                }
                input_file = args[arg];
            }

            if( null == input_file ) {
                Console.WriteLine("Please provide an input file as an argument." );
                return;
            }


            try {
                Library.Initialize( HOOPS_LICENSE.KEY, exchange_folder );
            } catch( Library.InitializationException e ) {
                Console.WriteLine( e.Message );
                return;
            }

            API.A3DDllSetCallbacksReport( 
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( MessageCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( WarningCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( ErrorCallback ) ) );

            A3DRWParamsLoadData load_params;
            API.Initialize(out load_params);
            IntPtr model_file;
            if(A3DStatus.A3D_SUCCESS != API.A3DAsmModelFileLoadFromFile(input_file, ref load_params, out model_file )) {
                Console.WriteLine( "Failed to load input file." );
                return;
            }

            

        }
    }
}
