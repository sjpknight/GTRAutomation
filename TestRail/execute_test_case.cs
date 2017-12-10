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
    ///The execute_test_case recording.
    /// </summary>
    [TestModule("36cb8f04-13f9-4d37-9074-7f1dc7522a0e", ModuleType.Recording, 1)]
    public partial class Execute_test_case : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static Execute_test_case instance = new Execute_test_case();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Execute_test_case()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Execute_test_case Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(0));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.TestRail1' at 11;1.", repo.LoginTestRail.TestRail1Info, new RecordItemIndex(1));
            repo.LoginTestRail.TestRail1.Click("11;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.TestRunsResults' at 94;14.", repo.LoginTestRail.TestRunsResultsInfo, new RecordItemIndex(2));
            repo.LoginTestRail.TestRunsResults.Click("94;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ATestRun' at 27;3.", repo.LoginTestRail.ATestRunInfo, new RecordItemIndex(3));
            repo.LoginTestRail.ATestRun.Click("27;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AnExecutableTestCase' at 85;6.", repo.LoginTestRail.AnExecutableTestCaseInfo, new RecordItemIndex(4));
            repo.LoginTestRail.AnExecutableTestCase.Click("85;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Sidebar1.AddResult' at 32;3.", repo.LoginTestRail.Sidebar1.AddResultInfo, new RecordItemIndex(5));
            repo.LoginTestRail.Sidebar1.AddResult.Click("32;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AddResultStatus' at 78;20.", repo.LoginTestRail.AddResultStatusInfo, new RecordItemIndex(6));
            repo.LoginTestRail.AddResultStatus.Click("78;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtc' at 83;4.", repo.LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtcInfo, new RecordItemIndex(7));
            repo.LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtc.Click("83;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AddResultStatus' at 300;14.", repo.LoginTestRail.AddResultStatusInfo, new RecordItemIndex(8));
            repo.LoginTestRail.AddResultStatus.Click("300;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AddResultStatus' at 75;17.", repo.LoginTestRail.AddResultStatusInfo, new RecordItemIndex(9));
            repo.LoginTestRail.AddResultStatus.Click("75;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtc' at 68;2.", repo.LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtcInfo, new RecordItemIndex(10));
            repo.LoginTestRail.ColumnResultDialogColumnLeft1.SetTheTestStatusEtc.Click("68;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AddResult1' at 9;9.", repo.LoginTestRail.AddResult1Info, new RecordItemIndex(11));
            repo.LoginTestRail.AddResult1.Click("9;9");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
