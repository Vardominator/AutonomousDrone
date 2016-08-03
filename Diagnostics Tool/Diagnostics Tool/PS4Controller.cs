using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostics_Tool
{
    public class PS4Controller
    {
        public static byte[] Inputs { get; set; }
        public static bool Enabled { get; set; }

        public override string ToString()
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
