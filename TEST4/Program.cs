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
        const int VK_Z = 0x5A;
        const int VK_Left = 0x25;
        const int VK_Right = 0x27;
        const int VK_C = 0x43;
        const int VK_X = 0x58;
        const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        /// </summary>
        [STAThread]
        static void Main()
        {
            while (true){
                if () 
                {
                    keybd_event((byte)VK_Z, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                }
                else if ()
                {
                    keybd_event((byte)VK_Left, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                }
                else if ()
                {
                    keybd_event((byte)VK_Right, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                }
                else if ()
                {
                    keybd_event((byte)VK_C, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                }
                else if () 
                {
                    keybd_event((byte)VK_X, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                }
                
            }
        }
    }
}
