using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SideScroller.Win32
{
    class Console
    {
        [DllImport("kernel32")]
        public static extern bool AllocConsole();
    }
}
