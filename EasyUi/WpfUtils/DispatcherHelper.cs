using System;
using System.Windows;

namespace WpfUtils
{
    public class DispatcherHelper
    {
        public static void Invoke(Action a)
        {
            Application.Current.Dispatcher.Invoke(a);
        }

        public static void BeginInvoke(Action a)
        {
            Application.Current.Dispatcher.BeginInvoke(a);
        }
    }
}
