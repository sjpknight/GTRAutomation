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
    ///The edit_role recording.
    /// </summary>
    [TestModule("7757b365-574e-45e6-800c-2120372fface", ModuleType.Recording, 1)]
    public partial class Edit_role : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static Edit_role instance = new Edit_role();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_role()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_role Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Administration' at 44;14.", repo.LoginTestRail.AdministrationInfo, new RecordItemIndex(0));
            repo.LoginTestRail.Administration.Click("44;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Sidebar1.UsersRoles' at 82;8.", repo.LoginTestRail.Sidebar1.UsersRolesInfo, new RecordItemIndex(1));
            repo.LoginTestRail.Sidebar1.UsersRoles.Click("82;8");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.HttpLocalhost8080TestrailImagesIc1' at 7;0.", repo.LoginTestRail.HttpLocalhost8080TestrailImagesIc1Info, new RecordItemIndex(2));
            //repo.LoginTestRail.HttpLocalhost8080TestrailImagesIc1.Click("7;0");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AnEditableRole' at 51;10.", repo.LoginTestRail.AnEditableRoleInfo, new RecordItemIndex(3));
            repo.LoginTestRail.AnEditableRole.Click("51;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.AttachmentsAddedit' at 5;6.", repo.LoginTestRail.AttachmentsAddeditInfo, new RecordItemIndex(4));
            repo.LoginTestRail.AttachmentsAddedit.Click("5;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ButtonTagSaveRole' at 78;7.", repo.LoginTestRail.ButtonTagSaveRoleInfo, new RecordItemIndex(5));
            repo.LoginTestRail.ButtonTagSaveRole.Click("78;7");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Successfully updated the role.') on item 'LoginTestRail.SuccessfullyUpdatedTheUser'.", repo.LoginTestRail.SuccessfullyUpdatedTheUserInfo, new RecordItemIndex(6));
                Validate.Attribute(repo.LoginTestRail.SuccessfullyUpdatedTheUserInfo, "InnerText", "Successfully updated the role.", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Dashboard' at 34;14.", repo.LoginTestRail.DashboardInfo, new RecordItemIndex(7));
            repo.LoginTestRail.Dashboard.Click("34;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
