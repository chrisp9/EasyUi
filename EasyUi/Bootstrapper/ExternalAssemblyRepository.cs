using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Bootstrapper
{
    public class ExternalAssemblyRepository
    {
        public static List<Assembly> AllAssemblies = new List<Assembly>();

        public static void Initialize()
        {
            var userTempDirectory = Path.GetTempPath();
            var bootstrapperTempFile = Path.Combine(userTempDirectory, "EasyUiBootstrap.tmp");

            var fileString = File.ReadAllText(bootstrapperTempFile);
            var dependencies = fileString.Split(',');

            foreach (var assemblyPath in dependencies)
            {
                try
                {
                    var assembly = Assembly.LoadFrom(assemblyPath);
                    AllAssemblies.Add(assembly);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }
    }
}
