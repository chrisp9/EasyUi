using ManagedInjector;
using System.Diagnostics;
using System.Linq;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = Process.GetProcessesByName("HardDiskBackup").FirstOrDefault();
            Injector.Launch(proc.MainWindowHandle, typeof(Bootstrapper.Loader).Assembly.Location, typeof(Bootstrapper.Loader).FullName, "Inject");
        }
    }
}
