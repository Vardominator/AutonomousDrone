using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Drone_Diagnostics
{
    public partial class Form1 : Form
    {

        SerialPort testPort;
        string currentSerialLine;

        string[] availablePorts;
        Random motorValueGenerator;
        int[] sonarVals;

        string rScriptPath = @"F:\GitHub\AutonomousDrone\Drone Diagnostics\";
        string rScriptName = "sonarPlotsScript.R";
        string rScriptExecutablePath = @"C:\Program Files\Microsoft\MRO\R-3.2.5\bin\Rscript.exe";
        string rScriptArgument = "";

        RScriptHandler rScriptTest;

        Thread rCallingThread;
        Thread imageLoadingThread;

        public Form1()
        {
            
            motorValueGenerator = new Random();
            sonarVals = new int[4];

            

            rScriptTest = new RScriptHandler(rScriptPath, rScriptName, rScriptExecutablePath);
                
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialMonitorTestTimer.Interval = 200;

            availablePorts = SerialPort.GetPortNames();

            foreach (var port in availablePorts)
            {
                comPortList.Items.Add(port);
            }
            
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        #region
        private void serialBeginButton_Click(object sender, EventArgs e)
        {
            //SerialHandler serialHandle = new SerialHandler();

            testPort = new SerialPort(comPortList.GetItemText(comPortList.SelectedItem), 9600);
            testPort.Open();

        }
        private void serialClearButton_Click(object sender, EventArgs e)
        {
            serialMonitor.Items.Clear();
        }
        private void serialStopButton_Click(object sender, EventArgs e)
        {
            testPort.Close();
        }
        #endregion

        private void serialMonitorTestTimer_Tick(object sender, EventArgs e)
        {

            // Scrolling for listboxes
            serialMonitor.SelectedIndex = serialMonitor.Items.Count - 1;
            resultsFromR.SelectedIndex = resultsFromR.Items.Count - 1;


            // Read from serial and flush
            if (testPort != null)
            {
                currentSerialLine = testPort.ReadLine();
                serialMonitor.Items.Add(testPort.ReadLine());
                testPort.DiscardInBuffer();
            }
            

            // Load sonar values to array
            if (currentSerialLine != null)
            {

                for (int i = 0; i < sonarVals.Length; i++)
                {
                    sonarVals[i] = int.Parse(currentSerialLine);
                    rScriptArgument += sonarVals[i] + " ";
                }

                string rScriptResult = "";

                // Lambda expression captures return value from thread
                rCallingThread = new Thread(() =>
                {
                    rScriptResult = rScriptTest.RunFromCommand(rScriptArgument);
                });
                rCallingThread.Start();
                rCallingThread.Join();

                resultsFromR.Items.Add(rScriptResult);

                rScriptArgument = "";

                // View sonar plot
                imageLoadingThread = new Thread(() =>
                {
                    FileStream bitmapFile = new FileStream(@"F:\GitHub\AutonomousDrone\Drone Diagnostics\sonarPlots.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                    Image loadedImage = new Bitmap(bitmapFile);

                    sonarViewer.Image = loadedImage;
                    //sonarViewer.BackColor = Color.Gray;
                });
                imageLoadingThread.Start();
                imageLoadingThread.Join();

            }
            

        }

        private void comPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void refreshSerial_Click(object sender, EventArgs e)
        {

            comPortList.Items.Clear();

            availablePorts = SerialPort.GetPortNames();

            foreach (var port in availablePorts)
            {
                comPortList.Items.Add(port);
            }
        }

        private void serialMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sonarViewer_Click(object sender, EventArgs e)
        {

        }
    }
}
