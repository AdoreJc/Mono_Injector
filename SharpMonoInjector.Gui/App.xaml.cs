using System;
using System.IO;
using System.Windows;

namespace GBMod
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\DebugLog.txt");
        }
    }
}
