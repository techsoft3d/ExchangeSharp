using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TS3D.Exchange;
using TS3D.Exchange.Direct;

namespace CountPartInstances
{
    using InstancePath = List<IntPtr>;
    using InstancePathArray = List<List<IntPtr> >;
    class Program
    {   
        static IntPtr GetPartDefinition( IntPtr po ) {
            if( po == IntPtr.Zero ) {
                return IntPtr.Zero;
            }

            var d = new A3DAsmProductOccurrenceWrapper(po);
            return d.m_pPart != IntPtr.Zero ? d.m_pPart : GetPartDefinition( d.m_pPrototype );
        }

        static InstancePathArray GetAllPartInstances( IntPtr po, InstancePath owners )
        {
            InstancePathArray result = new InstancePathArray();
            var current_owners = new InstancePath( owners );
            current_owners.Add( po );

            var part = GetPartDefinition( po );
            if( IntPtr.Zero != part ) {
                current_owners.Add( part );
                result.Add( current_owners );
                return result;
            }

            var po_data = new A3DAsmProductOccurrenceWrapper( po );
            for( var idx = 0; idx < po_data.m_uiPOccurrencesSize; ++idx)
            {
                var child_po = Marshal.ReadIntPtr(po_data.m_ppPOccurrences, idx * Marshal.SizeOf( typeof( IntPtr ) ) );
                var child_paths = GetAllPartInstances(child_po, current_owners);
                result.AddRange( child_paths );
            }

            return result;
        }

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

            var model_file_data = new A3DAsmModelFileWrapper( model_file );
            InstancePath owners = new InstancePath();
            owners.Add( model_file );
            var po = Marshal.ReadIntPtr(model_file_data.m_ppPOccurrences);
            var result = GetAllPartInstances(po, owners);
            Console.WriteLine( "There are " + result.Count + " part instances." );

        }
    }
}
