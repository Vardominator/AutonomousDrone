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
        private string lastArguement;


        public RScriptHandler()
        {
            scriptPath = "";
            executablePath = "";
            lastArguement = "";
            resultFromScript = "";
        }


        public RScriptHandler(string rCodeFilePath, string rScriptExecutablePath)
        {
            scriptPath = rCodeFilePath;
            executablePath = rScriptExecutablePath;
            lastArguement = "";
            resultFromScript = "";
        }


        public string RunFromCommand(string rCodeFilePath, string rScriptExecutablePath, string args)
        {

            try
            {

                ProcessStartInfo info = new ProcessStartInfo();                     // Specifies the values that are present during a process call
                info.FileName = executablePath;                                     // Executable to use
                info.WorkingDirectory = Path.GetDirectoryName(executablePath);      // Set directory of executable
                info.Arguments = scriptPath + " " + args;                       // Set argument

                info.RedirectStandardInput = false;                                 // no need to write the input to the process stream
                info.RedirectStandardOutput = false;                                // no need to write the output to the process stream
                info.UseShellExecute = false;                                       // no need to run using the shell
                info.CreateNoWindow = true;                                         // no external window needed


                Process process = new Process();
                process.StartInfo = info;
                process.Start();
                resultFromScript = process.StandardOutput.ReadToEnd();

                lastArguement = args;

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
