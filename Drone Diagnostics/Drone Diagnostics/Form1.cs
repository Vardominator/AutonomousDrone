using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Diagnostics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            comPort_SetDefaultText();
        }

        protected void comPort_SetDefaultText()
        {
            comPort.Text = "Port...";
            comPort.ForeColor = Color.Gray;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comPort_TextChanged(object sender, EventArgs e)
        {

        }



        #region
        private void comPort_Enter(object sender, EventArgs e)
        {
            if(comPort.ForeColor == Color.Black)
            {
                return;
            }
            comPort.Text = "";
            comPort.ForeColor = Color.Black;
        }
        private void comPort_Leave(object sender, EventArgs e)
        {
            if(comPort.Text.Trim() == "")
            {
                comPort_SetDefaultText();
            }
        }
        private void checkComPortsButton_Click(object sender, EventArgs e)
        {

        }
        #endregion


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
            serialMonitor.Items.Add("Praise the sun");
        }
    }
}
