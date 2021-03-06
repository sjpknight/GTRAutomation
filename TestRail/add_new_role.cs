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
    ///The add_new_role recording.
    /// </summary>
    [TestModule("bc78495f-be32-4d8c-912b-62a00825436f", ModuleType.Recording, 1)]
    public partial class add_new_role : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static add_new_role instance = new add_new_role();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public add_new_role()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static add_new_role Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Administration' at 35;18.", repo.LoginTestRail.AdministrationInfo, new RecordItemIndex(0));
            repo.LoginTestRail.Administration.Click("35;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ViewUsersRoles' at 75;6.", repo.LoginTestRail.ViewUsersRolesInfo, new RecordItemIndex(1));
            repo.LoginTestRail.ViewUsersRoles.Click("75;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ATagAddRole' at 35;22.", repo.LoginTestRail.ATagAddRoleInfo, new RecordItemIndex(2));
            repo.LoginTestRail.ATagAddRole.Click("35;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Name' at 104;15.", repo.LoginTestRail.NameInfo, new RecordItemIndex(3));
            repo.LoginTestRail.Name.Click("104;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testrole'.", new RecordItemIndex(4));
            Keyboard.Press("testrole");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ButtonTagAddRole' at 31;13.", repo.LoginTestRail.ButtonTagAddRoleInfo, new RecordItemIndex(5));
            repo.LoginTestRail.ButtonTagAddRole.Click("31;13");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Successfully added the new role.') on item 'LoginTestRail.SuccessfullyAddedTheNewTestCase'.", repo.LoginTestRail.SuccessfullyAddedTheNewTestCaseInfo, new RecordItemIndex(6));
                Validate.Attribute(repo.LoginTestRail.SuccessfullyAddedTheNewTestCaseInfo, "InnerText", "Successfully added the new role.", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Dashboard' at 57;15.", repo.LoginTestRail.DashboardInfo, new RecordItemIndex(7));
            repo.LoginTestRail.Dashboard.Click("57;15");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
