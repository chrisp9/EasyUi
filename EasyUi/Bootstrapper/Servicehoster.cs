using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Bootstrapper
{
    public class Servicehoster
    {
        private static ServiceHost _host;

        public static void Host()
        {
            _host = new ServiceHost(typeof (FindService), new Uri("net.pipe://localhost/easyui"));
            // Enable metadata publishing.

            _host.AddServiceEndpoint(
                typeof (IFindService),
                new NetNamedPipeBinding(), 
                "FindService"
                );


                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                _host.Open();

                Console.WriteLine("The service is ready at {0}", "http://localhost:8080/find");
                Console.WriteLine("Press <Enter> to stop the service.");

                // Close the ServiceHost.
        }
    }
}
