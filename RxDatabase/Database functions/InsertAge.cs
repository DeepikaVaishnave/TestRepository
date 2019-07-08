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

namespace RxDatabase.Database_functions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsertAge recording.
    /// </summary>
    [TestModule("163ce2f5-351a-4796-9548-ff58210bf2d3", ModuleType.Recording, 1)]
    public partial class InsertAge : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static global::RxDatabase.RxDatabaseRepository repo = global::RxDatabase.RxDatabaseRepository.Instance;

        static InsertAge instance = new InsertAge();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertAge()
        {
            intAge = "48";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertAge Instance
        {
            get { return instance; }
        }

#region Variables

        string _intAge;

        /// <summary>
        /// Gets or sets the value of variable intAge.
        /// </summary>
        [TestVariable("ee0ced35-280a-4e0b-9e20-f7ef33f0a631")]
        public string intAge
        {
            get { return _intAge; }
            set { _intAge = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.Age' at 56;11.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(0));
            repo.DemoApplication.DatabaseTab.Age.Click("56;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Delete}' with focus on 'DemoApplication.DatabaseTab.Age'.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(1));
            repo.DemoApplication.DatabaseTab.Age.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$intAge' with focus on 'DemoApplication.DatabaseTab.Age'.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(2));
            repo.DemoApplication.DatabaseTab.Age.PressKeys(intAge);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
