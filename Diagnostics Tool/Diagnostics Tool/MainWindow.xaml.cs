using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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

        SerialHandler serialHandler;
        ControllerTabHandler controllerTab;

        IEnumerable<CheckBox> allCheckBoxes;

        public MainWindow()
        {

            Program.rootHub = new DS4Control.ControlService();
            Program.rootHub.Start(true);

            Loaded += MainWindow_Loaded;

            dispatcherTimer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 0, 20)
            };
            
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Start();

            InitializeComponent();
            
            serialHandler = new SerialHandler();
            serialHandler.FindAvailablePorts(serialPortsBox);

            inputRadioButton.Checked += InputRadioButton_Checked;
            outputRadioButton.Checked += OutputRadioButton_Checked;
            allRadioButton.Checked += AllRadioButton_Checked;

            sonarsCheckBox.IsChecked = true;

        }

        private void AllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var checkbox in allCheckBoxes)
            {
                checkbox.IsChecked = true;
            }
        }

        private void InputRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var checkbox in allCheckBoxes)
            {
                checkbox.IsChecked = (string)checkbox.Tag == "IncomingCheckBox";
            }
        }

        private void OutputRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var checkbox in allCheckBoxes)
            {
                checkbox.IsChecked = (string)checkbox.Tag == "OutgoingCheckBox";
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            serialHandler.SetUpFilters();
            controllerTab = new ControllerTabHandler(leftStickCanvas, rightStickCanvas);

            allCheckBoxes = GetControls<CheckBox>(this);
        }
        
        private void serialGoButton_Click(object sender, RoutedEventArgs e)
        {
            serialHandler.Start(serialPortsBox.SelectedItem.ToString());
        }
        
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            serialHandler.UpdateFilters();
            serialHandler.UpdateMonitorIncoming(serialView);
                
            if (PS4Controller.Enabled)
            {
                controllerInputLabel.Content = "";
                controllerInputLabel.Content = PS4Controller.FullOutput;

                controllerTab.UpdateIndicators();
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(serialPortsBox.SelectedIndex != -1)
            {
                serialGoButton.IsEnabled = true;
            }
        }

        private void outputRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        
        public IEnumerable<T> GetControls<T>(DependencyObject obj) where T: DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child is T)
                {
                    yield return (T)child;
                }

                foreach (var grandChild in GetControls<T>(child))
                {
                    yield return grandChild;
                }
            }
        }

        private void inputRadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
