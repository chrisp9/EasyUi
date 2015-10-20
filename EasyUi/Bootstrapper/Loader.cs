using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootstrapper
{
    public class Loader
    {
        public static void Inject()
        {
            MessageBox.Show("Hello");
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("Hello again");
                Thread.Sleep(5000);
                MessageBox.Show("Hello again again");
            });
        }
    }
}
