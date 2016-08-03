using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Diagnostics_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer dispatcherTimer;

        SerialPort currentPort;
        string[] availablePorts;

        public MainWindow()
        {

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            
            InitializeComponent();
            availablePorts = SerialPort.GetPortNames();

            foreach (string portName in availablePorts)
            {
                serialPortsBox.Items.Add(portName);
            }

        }



        private void serialGoButton_Click(object sender, RoutedEventArgs e)
        {

            dispatcherTimer.Start();
            currentPort = new SerialPort(serialPortsBox.SelectedItem.ToString(), 9600);
            currentPort.Open();

        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            serialView.SelectedIndex = serialView.Items.Count - 1;

            if(currentPort != null)
            {
                string currentSerialLine = currentPort.ReadLine();
                serialView.Items.Add(currentSerialLine);
                currentPort.DiscardInBuffer();
            }

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(serialPortsBox.SelectedIndex != -1)
            {
                serialGoButton.IsEnabled = true;
            }
        }
    }
}
