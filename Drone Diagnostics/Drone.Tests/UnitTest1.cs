using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drone_Diagnostics;

namespace Drone.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string rScriptPath = @"F:\GitHub\AutonomousDrone\Drone Diagnostics\";
            string rScriptName = "sonarPlotsScript.R";
            string rScriptExecutablePath = @"C:\Program Files\Microsoft\MRO\R-3.2.5\bin\Rscript.exe";
            string rScriptArgument = "10 10 10 10";

            RScriptHandler testHandler = new RScriptHandler(rScriptPath, rScriptName, rScriptExecutablePath);

            string result = testHandler.RunFromCommand(rScriptArgument);

            Assert.AreEqual("blah", result);

        }
    }
}
