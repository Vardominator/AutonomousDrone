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

<<<<<<< HEAD
        private string scriptPath;
        private string scriptName;
        private string executablePath;
        private string resultFromScript;
=======
        public string ScriptPath { get; set; }
        public string ScriptName { get; set; }
        public string ExecutablePath { get; set; }
        public string ResultFromScript { get; private set; }
>>>>>>> 7121bf8bf3a707685cbfbadd02ace0f9ac64f7ec

        // Placeholder for automatically implemented properties
        public RScriptHandler() { }

<<<<<<< HEAD
        public RScriptHandler()
        {
            scriptPath = "";
            scriptName = "";
            executablePath = "";
            resultFromScript = "";
        }


        public RScriptHandler(string rScriptPath, string rScriptName,string rScriptExecutablePath)
        {
            scriptPath = rScriptPath;
            scriptName = rScriptName;
            executablePath = rScriptExecutablePath;
            resultFromScript = "";
=======
        
        public RScriptHandler(string rScriptPath, string rScriptName, string rScriptExecutablePath)
        {
            ScriptPath = rScriptPath;
            ScriptName = rScriptName;
            ExecutablePath = rScriptExecutablePath;
            ResultFromScript = "";
>>>>>>> 7121bf8bf3a707685cbfbadd02ace0f9ac64f7ec
        }


        public string RunFromCommand(string args)
        {

            try
            {

                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
<<<<<<< HEAD
                process.StartInfo.FileName = executablePath;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(scriptPath);
                process.StartInfo.Arguments = scriptName + " " + args;
=======
                process.StartInfo.FileName = ExecutablePath;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(ScriptPath);
                process.StartInfo.Arguments = ScriptName + " " + args;
>>>>>>> 7121bf8bf3a707685cbfbadd02ace0f9ac64f7ec
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
