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

namespace Drone_Diagnostics
{
    public partial class Form1 : Form
    {

        SerialPort testPort;

        string[] availablePorts;
        Random motorValueGenerator;
        int[] motorVals;

        string rScriptPath = @"F:\GitHub\AutonomousDrone\Drone Diagnostics\";
        string rScriptName = "testScript.R";
        string rScriptExecutablePath = @"C:\Program Files\Microsoft\MRO\R-3.2.5\bin\Rscript.exe";
        string rScriptArgument = "";

        RScriptHandler rScriptTest;

        Thread rCallingThread;

        public Form1()
        {

            motorValueGenerator = new Random();
            motorVals = new int[4];
            
            rScriptTest = new RScriptHandler(rScriptPath, rScriptName, rScriptExecutablePath);
                
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


            for (int i = 0; i < motorVals.Length; i++)
            {
                motorVals[i] = motorValueGenerator.Next(0, 101);
                rScriptArgument += motorVals[i] + " ";
            }


            // Read from serial and flush
            if (testPort != null)
            {
                
                serialMonitor.Items.Add(testPort.ReadLine());
                testPort.DiscardInBuffer();
            }


            //serialMonitor.Items.Add($"{motorVals[0]},{motorVals[1]},{motorVals[2]},{motorVals[3]}");


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


    }
}
