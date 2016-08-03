using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Diagnostics_Tool
{
    public class SerialHandler
    {

        Dictionary<char, bool> serialFilter;

        Dictionary<char, List<int>> message;

        SerialPort activePort;

        string[] availablePorts;

        public SerialHandler()
        {
            serialFilter = new Dictionary<char, bool>();
            message = new Dictionary<char, List<int>>();
        }

        public void FindAvailablePorts(ComboBox serialPortsBox)
        {
            availablePorts = SerialPort.GetPortNames();
            foreach (string portName in availablePorts)
            {
                serialPortsBox.Items.Add(portName);
            }
        }

        public void SetUpFilters()
        {
            foreach (CheckBox checkBox in FindVisualChildren<CheckBox>(Application.Current.MainWindow))
            {
                if (!serialFilter.ContainsKey(checkBox.Content.ToString()[0]))
                {
                    Console.WriteLine(checkBox.Content.ToString());
                    serialFilter.Add((checkBox.Content.ToString())[0], (bool)checkBox.IsChecked);
                }
            }
        }

        public void UpdateFilters()
        {
            foreach (CheckBox checkBox in FindVisualChildren<CheckBox>(Application.Current.MainWindow))
            {
                serialFilter[checkBox.Content.ToString()[0]] = (bool)checkBox.IsChecked;
                Console.WriteLine($"{checkBox.Content.ToString()[0]}:{serialFilter[checkBox.Content.ToString()[0]]}");
            }
        }

        internal void UpdateMonitorIncoming(ListBox serialView)
        {
            serialView.SelectedIndex = serialView.Items.Count - 1;

            if (activePort != null && activePort.IsOpen)
            {

                string currentSerialLine = activePort.ReadLine().TrimEnd(new char[] { '\r', '\n' });

                string[] subMessages = currentSerialLine.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (subMessages[0][0] == 'S')
                {

                    foreach (string subMessage in subMessages)
                    {
                        string[] keyValuePair = subMessage.Split(new char[] { ':' });
                        char key = keyValuePair[0][0];

                        if (serialFilter[key] == true)
                        {
                            serialView.Items.Add(keyValuePair[1]);
                        }

                        List<int> values = new List<int>();

                        foreach (string value in keyValuePair[1].Split(','))
                        {
                            values.Add(int.Parse(value));
                        }

                        message[key] = values;

                    }
                    
                    activePort.DiscardInBuffer();

                }
            }
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject obj) where T : DependencyObject
        {
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i);

                    if (child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T grandChild in FindVisualChildren<T>(child))
                    {
                        yield return grandChild;
                    }
                }
            }
        }
        
        public void Start(string selectedPort)
        {
            activePort = new SerialPort(selectedPort, 9600);
            activePort.Open();
        }

        public void Stop()
        {
            activePort.Close();
        }
        
    }
}
