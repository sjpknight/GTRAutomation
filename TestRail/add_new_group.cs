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
    ///The add_new_group recording.
    /// </summary>
    [TestModule("a1465a95-d996-4688-b36e-3dbc8fbac6e6", ModuleType.Recording, 1)]
    public partial class Add_new_group : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static Add_new_group instance = new Add_new_group();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_new_group()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_new_group Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Administration' at 50;16.", repo.LoginTestRail.AdministrationInfo, new RecordItemIndex(0));
            repo.LoginTestRail.Administration.Click("50;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Sidebar1.UsersRoles' at 75;18.", repo.LoginTestRail.Sidebar1.UsersRolesInfo, new RecordItemIndex(1));
            repo.LoginTestRail.Sidebar1.UsersRoles.Click("75;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ATagAddGroup' at 74;11.", repo.LoginTestRail.ATagAddGroupInfo, new RecordItemIndex(2));
            repo.LoginTestRail.ATagAddGroup.Click("74;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Name' at 51;10.", repo.LoginTestRail.NameInfo, new RecordItemIndex(3));
            repo.LoginTestRail.Name.Click("51;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test{Space}group' with focus on 'LoginTestRail.Name'.", repo.LoginTestRail.NameInfo, new RecordItemIndex(4));
            repo.LoginTestRail.Name.PressKeys("test{Space}group");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ButtonTagAddGroup' at 52;18.", repo.LoginTestRail.ButtonTagAddGroupInfo, new RecordItemIndex(5));
            repo.LoginTestRail.ButtonTagAddGroup.Click("52;18");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Successfully added the new user group.') on item 'LoginTestRail.SuccessfullyAddedTheNewTestCase'.", repo.LoginTestRail.SuccessfullyAddedTheNewTestCaseInfo, new RecordItemIndex(6));
                Validate.Attribute(repo.LoginTestRail.SuccessfullyAddedTheNewTestCaseInfo, "InnerText", "Successfully added the new user group.", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Dashboard' at 48;15.", repo.LoginTestRail.DashboardInfo, new RecordItemIndex(7));
            repo.LoginTestRail.Dashboard.Click("48;15");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
