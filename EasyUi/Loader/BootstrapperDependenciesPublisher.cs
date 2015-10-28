using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loader
{
    public class BootstrapperDependenciesPublisher
    {
        public BootstrapperDependenciesPublisher()
        {
            
        }

        public static void PublishBootstrapperDependencies()
        {
            var userTempDirectory = Path.GetTempPath();

            var bootstrapperTempFile = Path.Combine(userTempDirectory, "EasyUiBootstrap.tmp");
            if(File.Exists(bootstrapperTempFile))
                File.Delete(bootstrapperTempFile);

            var xy = AppDomain.CurrentDomain.GetAssemblies();

            var bootstrapperAssembly = AppDomain.CurrentDomain.GetAssemblies().Single(x => x.FullName.Contains("Bootstrapper"));
            var allAssemblies = new StringBuilder();

            foreach (var item in bootstrapperAssembly.GetReferencedAssemblies())
            {
                var assembly = Assembly.Load(item);
                allAssemblies.Append(assembly.Location +",");
            }

            File.WriteAllText(bootstrapperTempFile, allAssemblies.ToString());
        }
    }
}
