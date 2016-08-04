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

        PS4Controller controller;

        SerialHandler serialHandler;

        
        Rectangle testRectangle;

        Rectangle rect;

        public MainWindow()
        {

            Program.rootHub = new DS4Control.ControlService();
            Program.rootHub.Start(true);

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();

            InitializeComponent();

            controller = new PS4Controller();
            
            serialHandler = new SerialHandler();
            serialHandler.FindAvailablePorts(serialPortsBox);

            Loaded += MainWindow_Loaded;


            testRectangle = new Rectangle { Stroke = Brushes.Black, StrokeThickness = 2 };

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            serialHandler.SetUpFilters();

            leftStickCanvas.Children.Insert(0, testRectangle);

            rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 10;
            rect.Stroke = Brushes.Blue;
            rect.Fill = Brushes.Black;
            leftStickCanvas.Children.Add(rect);
            Canvas.SetTop(rect, 10);
            Canvas.SetLeft(rect, 10);

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
                controllerInputLabel.Content = controller.ToString();

                leftStickAxisXSlider.Value = PS4Controller.Inputs[1];
                leftStickAxisYSlider.Value = PS4Controller.Inputs[2];
                rightStickAxisXSlider.Value = PS4Controller.Inputs[3];
                rightStickAxisYSlider.Value = PS4Controller.Inputs[4];

                Canvas.SetLeft(rect, PS4Controller.Inputs[1]);
                Canvas.SetTop(rect, PS4Controller.Inputs[2]);
                
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
