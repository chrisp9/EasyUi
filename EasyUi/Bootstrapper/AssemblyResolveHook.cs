using System;
using System.Linq;

namespace Bootstrapper
{
    public static class AssemblyResolveHook
    {
        public static void Attach()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (o, e) =>
            {
                return ExternalAssemblyRepository.AllAssemblies.FirstOrDefault(item => item.FullName.Contains(e.Name));
            };
        }
    }
}