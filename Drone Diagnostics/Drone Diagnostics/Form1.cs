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

namespace Drone_Diagnostics
{
    public partial class Form1 : Form
    {


        string[] availablePorts;
        Random motorValueGenerator;
        int[] motorVals;


        public Form1()
        {

            motorValueGenerator = new Random();
            motorVals = new int[4];

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
            SerialHandler serialHandle = new SerialHandler();
        }
        private void serialClearButton_Click(object sender, EventArgs e)
        {
            serialMonitor.Items.Clear();
        }
        private void serialStopButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void serialMonitorTestTimer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < motorVals.Length; i++)
            {
                motorVals[i] = motorValueGenerator.Next(0, 101);    
            }

            serialMonitor.Items.Add($"{motorVals[0]},{motorVals[1]},{motorVals[2]},{motorVals[3]}");

        }

        private void comPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
