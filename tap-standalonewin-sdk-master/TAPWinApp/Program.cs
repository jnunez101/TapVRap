using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAPWin;
using System.IO;
using System.Text;

namespace TAPWinApp


{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]


        static void Main()
        {



            
            TAPManager.Instance.SetTapInputMode(TAPInputMode.RawSensor(new RawSensorSensitivity()));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            



        }

        
    }
}
