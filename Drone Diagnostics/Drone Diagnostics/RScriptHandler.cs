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

        private string scriptPath;
        private string executablePath;
        private string resultFromScript;


        public RScriptHandler()
        {
            scriptPath = "";
            executablePath = "";
            resultFromScript = "";
        }


        public RScriptHandler(string rCodeFilePath, string rScriptExecutablePath)
        {
            scriptPath = rCodeFilePath;
            executablePath = rScriptExecutablePath;
            resultFromScript = "";
        }


        public string RunFromCommand(string args)
        {

            try
            {

                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = executablePath;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(scriptPath);
                process.StartInfo.Arguments = "testScript.R" + " " + args;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                resultFromScript = process.StandardOutput.ReadToEnd();

                return resultFromScript;

            }
            catch(Exception exception)
            {
                throw new Exception($"R Script failed: {resultFromScript}", exception);
            }
            
        }



        public string ScriptPath
        {
            get { return scriptPath; }
            set
            {
                if (value != null && value != "")
                {
                    scriptPath = value;
                }
                else
                {
                    Console.WriteLine("Invalid script path");
                }
            }
        }

        public string ExecutablePath
        {
            get { return executablePath; }
            set
            {
                if (value != null && value != "")
                {
                    executablePath = value;
                }
                else
                {
                    Console.WriteLine("Invalid executable path");
                }
            }
        }
        

    }
}
