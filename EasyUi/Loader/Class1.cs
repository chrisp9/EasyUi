using ManagedInjector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
