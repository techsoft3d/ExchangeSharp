using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TS3D.Exchange;
using TS3D.Exchange.Direct;

namespace DriverApp
{
    class Program
    {   
        static string GetName( IntPtr ntt ) {
            var d = new A3DRootBaseWrapper( ntt );
            var t = A3DEEntityType.kA3DTypeUnknown;
            API.A3DEntityGetType( ntt, ref t );
            var type = Marshal.PtrToStringUTF8(  API.A3DMiscGetEntityTypeMsg( t ) );
            return d.m_pcName + " [" + type + "]";
        }

        static void Write( string msg, int indent ) {
            while( indent != 0) {
                Console.Write("    ");
                indent--;
            }
            Console.WriteLine( msg );
        }

        static IntPtr GetPartDefinition( IntPtr po ) {
            if( po == IntPtr.Zero ) {
                return IntPtr.Zero;
            }

            var d = new A3DAsmProductOccurrenceWrapper(po);
            return d.m_pPart != IntPtr.Zero ? d.m_pPart : GetPartDefinition( d.m_pPrototype );
        }

        static void RecursivelyPrintName( IntPtr po, int indent ) {
            Write( GetName( po ), indent );
            indent++;
            var d = new A3DAsmProductOccurrenceWrapper( po );
            for( var idx = 0; idx < d.m_uiPOccurrencesSize; idx++ ) {
                var child_po = Marshal.ReadIntPtr( d.m_ppPOccurrences, idx * Marshal.SizeOf( typeof (IntPtr) ) );
                RecursivelyPrintName( child_po, indent );
            }
            var part = GetPartDefinition( po );
            if( part != IntPtr.Zero ) {
                Write( GetName( part ), indent + 1 );                
            }
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

            A3DRWParamsLoadData load_params;
            API.Initialize(out load_params);
            IntPtr model_file;
            if(A3DStatus.A3D_SUCCESS != API.A3DAsmModelFileLoadFromFile(input_file, ref load_params, out model_file )) {
                Console.WriteLine( "Failed to load input file." );
                return;
            }

            var model_file_data = new A3DAsmModelFileWrapper( model_file );
            int indent = 0;
            Write( GetName( model_file ), indent++ );
            for( int idx = 0; idx < model_file_data.m_uiPOccurrencesSize; ++idx ) {
                var po = Marshal.ReadIntPtr(model_file_data.m_ppPOccurrences, idx * Marshal.SizeOf( typeof(IntPtr) ) );
                RecursivelyPrintName( po, indent );
            }
        }
    }
}
