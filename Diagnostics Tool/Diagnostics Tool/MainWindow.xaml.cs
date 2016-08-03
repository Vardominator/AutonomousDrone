using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
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
        
        string[] availablePorts;

        PS4Controller controller;

        SerialHandler serialHandler;

        public MainWindow()
        {

            Program.rootHub = new DS4Control.ControlService();
            Program.rootHub.Start(true);

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dispatcherTimer.Start();

            InitializeComponent();

            controller = new PS4Controller();
            
            serialHandler = new SerialHandler();
            serialHandler.FindAvailablePorts(serialPortsBox);

            Loaded += MainWindow_Loaded;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            serialHandler.SetUpFilters();
        }
        
        
        private void serialGoButton_Click(object sender, RoutedEventArgs e)
        {

            serialHandler.Start(serialPortsBox.SelectedItem.ToString());
            
        }


        private async void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            serialHandler.UpdateFilters();
            
            serialHandler.UpdateMonitorIncoming(serialView);

            if (PS4Controller.Enabled)
            {
                controllerInputLabel.Content = "";
                controllerInputLabel.Content = controller.ToString();
            }

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(serialPortsBox.SelectedIndex != -1)
            {
                serialGoButton.IsEnabled = true;
            }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sonarsCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
