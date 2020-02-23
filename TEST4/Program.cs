using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TEST4
{
    
    static class Program
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bvk, byte bScan, uint dwFlags, uint dwExtraIfo);
        /// <summary>
        /// The main entry point for the application.
        const int VK_UP = 0x26;
        const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        /// </summary>
        [STAThread]
        static void Main()
        {
            while (true){
                keybd_event((byte)VK_UP, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());
            }
        }
    }
}
