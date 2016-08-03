﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagnostics_Tool.DS4Control
{
    public class Log
    {
        public static event EventHandler<DebugEventArgs> TrayIconLog;
        public static event EventHandler<DebugEventArgs> GuiLog;

        public static void LogToGui(string data, bool warning)
        {
            if (GuiLog != null)
            {
                GuiLog(null, new DebugEventArgs(data, warning));
            }
        }

        public static void LogToTray(string data, bool warning = false, bool ignoreSettings = false)
        {
            if (TrayIconLog != null)
            {
                if (ignoreSettings)
                    TrayIconLog(ignoreSettings, new DebugEventArgs(data, warning));
                else
                    TrayIconLog(null, new DebugEventArgs(data, warning));
            }
        }
    }
}

