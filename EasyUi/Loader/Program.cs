using System;
using ManagedInjector;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.ServiceModel;
using Bootstrapper;
using MessagingMessages;
using Server;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            BootstrapperDependenciesPublisher.PublishBootstrapperDependencies();
            
            var proc = Process.GetProcessesByName("HardDiskBackup").FirstOrDefault();

            Injector.Launch(
                proc.MainWindowHandle, 
                typeof(Bootstrapper.Loader).Assembly.Location, 
                typeof(Bootstrapper.Loader).FullName, "Inject");

            Console.WriteLine("Injection completed");
            Thread.Sleep(5000);

            var httpFactory =
                new ChannelFactory<IFindService>(
                  new NetNamedPipeBinding(),
                  new EndpointAddress(
                    "net.pipe://localhost/easyui/findservice"));

            var proxy = httpFactory.CreateChannel();

            proxy.GetData(new FindMessage());
        }
    }
}
