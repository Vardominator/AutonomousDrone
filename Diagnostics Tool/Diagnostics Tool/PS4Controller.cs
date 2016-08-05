using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostics_Tool
{
    public class PS4Controller
    {
        public enum PS4Button
        {
            HOME,
            LEFTSTICK,
            RIGHTSTICK
        }

        public static byte[] Inputs { get; set; }
        public static bool Enabled { get; set; }

        public static string FullOutput
        {
            get
            {
                StringBuilder inputsSB = new StringBuilder();

                foreach (byte value in Inputs)
                {
                    inputsSB.Append(value + ", ");
                }

                return inputsSB.ToString();
            }
        }

    }
}
