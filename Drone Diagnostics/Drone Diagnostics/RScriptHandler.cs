using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone_Diagnostics
{

    /// <summary>
    /// Rscript.exe : C:\Program Files\Microsoft\MRO\R-3.2.5\bin
    /// </summary>
    class RScriptHandler
    {

        public string ScriptPath { get; set; }
        public string ScriptName { get; set; }
        public string ExecutablePath { get; set; }
        public string ResultFromScript { get; private set; }

        // Placeholder for automatically implemented properties
        public RScriptHandler() { }

        
        public RScriptHandler(string rScriptPath, string rScriptName, string rScriptExecutablePath)
        {
            ScriptPath = rScriptPath;
            ScriptName = rScriptName;
            ExecutablePath = rScriptExecutablePath;
            ResultFromScript = "";
        }


        public string RunFromCommand(string args)
        {

            try
            {

                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = ExecutablePath;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(ScriptPath);
                process.StartInfo.Arguments = ScriptName + " " + args;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                ResultFromScript = process.StandardOutput.ReadToEnd();

                return ResultFromScript;

            }
            catch(Exception exception)
            {

                throw new Exception($"R Script failed: {ResultFromScript}", exception);

            }
            
        }







    }
}
