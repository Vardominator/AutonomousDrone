using Diagnostics_Tool.DS4Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Diagnostics_Tool
{
    public static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        // Add "global\" in front of the EventName, then only one instance is allowed on the
        // whole system, including other users. But the application can not be brought
        // into view, of course. 
        private static String SingleAppComEventName = "{a52b5b20-d9ee-4f32-8518-307fa14aa0c6}";
        static Mutex mutex = new Mutex(true, "{FI329DM2-DS4W-J2K2-HYES-92H21B3WJARG}");
        private static BackgroundWorker singleAppComThread = null;
        private static EventWaitHandle threadComEvent = null;
        public static ControlService rootHub;

        [STAThread]
        public static void Main()
        {
            var application = new App();
            application.InitializeComponent();
            application.Run();

            rootHub = new ControlService();

        }
    }
}
