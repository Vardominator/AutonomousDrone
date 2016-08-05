using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class ControllerTabHandler
    {

        //IEnumerable<Canvas> analogStickCanvases;
        //Canvas leftStickCanvas;
        //Canvas rightStickCanvas;

        System.Windows.Shapes.Rectangle leftStickIndicator;
        System.Windows.Shapes.Rectangle rightStickIndicator;
        
        public ControllerTabHandler(Canvas leftStickCanvas, Canvas rightStickCanvas)
        {
            //analogStickCanvases = ControllerChildren<Canvas>(tabs);
            //leftStickCanvas = analogStickCanvases.ElementAt(0);
            //rightStickCanvas = analogStickCanvases.ElementAt(1);

            leftStickIndicator = new System.Windows.Shapes.Rectangle
            {
                Stroke = System.Windows.Media.Brushes.Black,
                Fill = System.Windows.Media.Brushes.Blue,
                StrokeThickness = 2,
                Width = 10,
                Height = 10
            };

            rightStickIndicator = new System.Windows.Shapes.Rectangle
            {
                Stroke = System.Windows.Media.Brushes.Black,
                Fill = System.Windows.Media.Brushes.Blue,
                StrokeThickness = 2,
                Width = 10,
                Height = 10
            };

            leftStickCanvas.Children.Add(leftStickIndicator);
            rightStickCanvas.Children.Add(rightStickIndicator);

        }

        public void UpdateIndicators()
        {
            if (PS4Controller.Enabled)
            {
                Canvas.SetLeft(leftStickIndicator, PS4Controller.Inputs[1] - leftStickIndicator.Width / 2 + 6);
                Canvas.SetTop(leftStickIndicator, PS4Controller.Inputs[2] - leftStickIndicator.Height / 2 + 6);

                Canvas.SetLeft(rightStickIndicator, PS4Controller.Inputs[3] - rightStickIndicator.Width / 2 + 6);
                Canvas.SetTop(rightStickIndicator, PS4Controller.Inputs[4] - rightStickIndicator.Height / 2 + 6);
            }
        }

        public void UpdateSliders(Slider leftX, Slider leftY, Slider rightX, Slider rightY)
        {
            if (PS4Controller.Enabled)
            {
                leftX.Value = PS4Controller.Inputs[1];
                leftY.Value = PS4Controller.Inputs[2];
                rightX.Value = PS4Controller.Inputs[3];
                rightY.Value = PS4Controller.Inputs[4];
            }
        }

        public static IEnumerable<T> ControllerChildren<T>(DependencyObject obj) where T: DependencyObject
        {
            if(obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                    if(child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T grandChild in ControllerChildren<T>(child))
                    {
                        yield return grandChild;
                    }
                }
            }
        }

    }
}
