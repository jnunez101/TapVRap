using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using TAPWin;
using System.IO;
using System.Runtime.InteropServices;

namespace TAPWinApp
{
    public partial class Form1 : Form
    {
        
        private bool once;
        StreamWriter data = new StreamWriter("data.txt");
        private int counter;
        private bool triggerThumb = false;


        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        

        public Form1()
        {
            this.once = true;
            TAPManager.Instance.SetTapInputMode(TAPInputMode.RawSensor(new RawSensorSensitivity()));
            InitializeComponent();
            
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (this.once)
            {
                this.once = false;
                TAPManager.Instance.OnMoused += this.OnMoused;
                TAPManager.Instance.OnTapped += this.OnTapped;
                TAPManager.Instance.OnTapConnected += this.OnTapConnected;
                TAPManager.Instance.OnTapDisconnected += this.OnTapDisconnected; 

                TAPManager.Instance.OnAirGestured += this.OnAirGestured;
                TAPManager.Instance.OnChangedAirGestureState += this.OnChangedAirGestureState;
                TAPManager.Instance.OnRawSensorDataReceieved += this.OnRawSensorDataReceieved;


                TAPManager.Instance.SetTapInputMode(TAPInputMode.RawSensor(new RawSensorSensitivity()));
                counter = 0;
                //button1.Click += new EventHandler(button1_Click);
                TAPManager.Instance.Start();
                

            }
            
            
        }

        private void OnTapped(string identifier, int tapcode)
        {
            
            this.LogLine(identifier + " tapped " + tapcode.ToString());
            


        }

        private void OnTapConnected(string identifier, string name, int fw)
        {
            this.LogLine(identifier + " connected. (" + name + ", fw " + fw.ToString() + ")");
            TAPManager.Instance.SetTapInputMode(TAPInputMode.RawSensor(new RawSensorSensitivity()));

        }

        private void OnTapDisconnected(string identifier)
        {
            this.LogLine(identifier + " disconnected.");
        }

        private void OnMoused(string identifier, int vx, int vy, bool isMouse)
        {
            if (isMouse)
            {
                this.LogLine(identifier + " moused (" + vx.ToString() + "," + vy.ToString() + ")");
            }
            
        }

        private void LogLine(string line)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBox1.AppendText(line + Environment.NewLine);
               
            });
            
        }
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bvk, byte bScan, uint dwFlags, uint dwExtraIfo);
        const int VK_Z = 0x5A;
        const int VK_Left = 0x25;
        const int VK_Right = 0x27;
        const int VK_C = 0x43;
        const int VK_X = 0x58;
        const int VKSPACE = 0x20;
        const int KEYEVENTF_EXTENDEDKEY = 0x0001;
       // private void button1_Click(object sender, EventArgs e)
       // {
        //    TAPManager.Instance.Vibrate(new int[] { 100, 300, 100 });
        //}

        private void OnAirGestured(string identifier, TAPAirGesture airGesture)
        {
            Console.WriteLine("AirGestured " + identifier + ", code: " + (int)airGesture);
        }

        private void OnChangedAirGestureState(string identifier, bool isInAirGestureState)
        {
            Console.WriteLine("Changed AirGesture State " + identifier + "isInAirGestureState: " + isInAirGestureState.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get a handle to the Calculator application. The window class
            // and window name were obtained using the Spy++ tool.
            IntPtr gameHandle = FindWindow(null, "Geometry Dash");
            Console.WriteLine("1");
            
            // Verify that Calculator is a running process.
            if (gameHandle == IntPtr.Zero)
            {
                MessageBox.Show("Calculator is not running.");
                return;
            }
            SetForegroundWindow(gameHandle);
            SendKeys.SendWait("0x20");
            
        }

            private void OnRawSensorDataReceieved(string identifier, RawSensorData rsData)
        {
            double thumbTotal;
            data.AutoFlush = true;
            Point3 thumb = rsData.GetPoint(RawSensorData.indexof_DEV_THUMB);
            Point3 index = rsData.GetPoint(RawSensorData.indexof_DEV_INDEX);
            Point3 middle = rsData.GetPoint(RawSensorData.indexof_DEV_MIDDLE);
            Point3 ring = rsData.GetPoint(RawSensorData.indexof_DEV_RING);
            Point3 pinky = rsData.GetPoint(RawSensorData.indexof_DEV_PINKY);

            if (counter == 10)
            {
                counter = 0;
            }
     
            if (counter == 0)
            {
                try
                {  
                    thumbTotal = thumb.x + thumb.y + thumb.z;

                    //press space
                        
                        if (triggerThumb)
                        {
                            triggerThumb = false;
                        }
                        else if(thumbTotal >= 250000){
                            //button1_Click("uwu", EventArgs.Empty);
                            
                            triggerThumb = true;
                            //triggerThumb = true;

                        }

                    
                    data.WriteLine(RawSensorData.indexof_DEV_THUMB + "," + thumb.x + "," + thumb.y + "," + thumb.z);
                    data.WriteLine(RawSensorData.indexof_DEV_INDEX + "," + index.x + "," + index.y + "," + index.z);
                    data.WriteLine(RawSensorData.indexof_DEV_MIDDLE + "," + middle.x + "," + middle.y + "," + middle.z);
                    data.WriteLine(RawSensorData.indexof_DEV_RING + "," + ring.x + "," + ring.y + "," + ring.z);
                    data.WriteLine(RawSensorData.indexof_DEV_PINKY + "," + pinky.x + "," + pinky.y + "," + pinky.z);
                }
                catch (NullReferenceException e)
                {

                }

                data.Flush();
            }
            counter += 1;
            
            


        }
    }
}
