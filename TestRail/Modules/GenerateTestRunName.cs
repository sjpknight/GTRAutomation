/*
 * Created by Ranorex
 * User: sjpkn
 * Date: 02/12/2017
 * Time: 12:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestRail.Modules
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("1A211683-8978-4D4F-AE4C-DE4FE5B63CAE", ModuleType.UserCode, 1)]
    public class GenerateTestRunName : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GenerateTestRunName()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _TestRunNameOuput = "";
        [TestVariable("165786d7-938c-465e-a6cb-f1af0a3b1d60")]
        public string TestRunNameOuput
        {
        	get { return _TestRunNameOuput; }
        	set { _TestRunNameOuput = value; }
        }
        
        public static string getRandomTestRunName() 
        {
        	var random = new Random();
        	var randomNum = random.Next();
        	string randomTestRunName = "TestRun-" + randomNum;
        	return randomTestRunName;
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	_TestRunNameOuput = getRandomTestRunName();
        }
    }
}
