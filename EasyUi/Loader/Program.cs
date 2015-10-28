using System;
using ManagedInjector;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using Messaging;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            BootstrapperDependenciesPublisher.PublishBootstrapperDependencies();

            var proc = Process.GetProcessesByName("HardDiskBackup").FirstOrDefault();
            Injector.Launch(proc.MainWindowHandle, typeof(Bootstrapper.Loader).Assembly.Location, typeof(Bootstrapper.Loader).FullName, "Inject");
            Console.WriteLine("Injection completed");

            var g = Find<ScrollViewer>.ByAutomationId("");
        }
    }
}
