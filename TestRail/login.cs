﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace TestRail
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The login recording.
    /// </summary>
    [TestModule("85b6a78d-20db-45c7-bf81-ecc0d3486310", ModuleType.Recording, 1)]
    public partial class login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static login instance = new login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public login()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static login Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://localhost:8080/testrail/index.php' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("http://localhost:8080/testrail/index.php", "chrome", "", false, false, false, true, false);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Name' at 190;12.", repo.LoginTestRail.NameInfo, new RecordItemIndex(1));
            repo.LoginTestRail.Name.Click("190;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'automated.test@gurock.io' with focus on 'LoginTestRail.Name'.", repo.LoginTestRail.NameInfo, new RecordItemIndex(2));
            repo.LoginTestRail.Name.PressKeys("automated.test@gurock.io");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Password' at 129;16.", repo.LoginTestRail.PasswordInfo, new RecordItemIndex(3));
            repo.LoginTestRail.Password.Click("129;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testrail123' with focus on 'LoginTestRail.Password'.", repo.LoginTestRail.PasswordInfo, new RecordItemIndex(4));
            repo.LoginTestRail.Password.PressKeys("testrail123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Automated Test') on item 'LoginTestRail.AutomatedTest'.", repo.LoginTestRail.AutomatedTestInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.LoginTestRail.AutomatedTestInfo, "InnerText", "Automated Test");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
