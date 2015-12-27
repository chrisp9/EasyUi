using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Loader
{
    public class BootstrapperDependenciesPublisher
    {
        public static void PublishBootstrapperDependencies()
        {
            var userTempDirectory = Path.GetTempPath();

            var bootstrapperTempFile = Path.Combine(userTempDirectory, "EasyUiBootstrap.tmp");
            if(File.Exists(bootstrapperTempFile))
                File.Delete(bootstrapperTempFile);

            var bootstrapperAssembly = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Single(x => x.FullName
                .Contains("Bootstrapper"));

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
