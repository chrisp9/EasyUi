using System.Windows.Forms;

namespace Bootstrapper
{
    public class Loader
    {
        public static void Inject()
        {
            ExternalAssemblyRepository.Initialize();
            AssemblyResolveHook.Attach();

            MessageBox.Show("Hello");
            ServiceHoster.Host();
        }
    }
}