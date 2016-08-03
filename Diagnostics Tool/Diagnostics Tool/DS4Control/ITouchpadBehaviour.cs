using Diagnostics_Tool.DS4Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagnostics_Tool.DS4Control
{
    interface ITouchpadBehaviour
    {
        void touchesBegan(object sender, TouchpadEventArgs arg);
        void touchesMoved(object sender, TouchpadEventArgs arg);
        void touchButtonUp(object sender, TouchpadEventArgs arg);
        void touchButtonDown(object sender, TouchpadEventArgs arg);
        void touchesEnded(object sender, TouchpadEventArgs arg);
        void sixaxisMoved(object sender, SixAxisEventArgs unused);
        void touchUnchanged(object sender, EventArgs unused);
    }
}
