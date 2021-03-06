﻿using System;
using Avalon.Common.Interfaces;
using Avalon.Common.Models;

namespace Avalon.HashCommands
{

    /// <summary>
    /// Command used for debugging.
    /// </summary>
    public class Debug : HashCommand
    {
        public Debug(IInterpreter interp) : base(interp)
        {
        }

        public override string Name { get; } = "#debug";

        public override string Description { get; } = "Command used for developer debugging.";

        public override void Execute()
        {
            //string json = System.IO.File.ReadAllText(@"");
            //App.Settings.ImportPackageFromJson(json);

            //App.MainWindow.ScheduledTasks.AddTask("say 1", false, DateTime.Now.AddSeconds(1));
            //App.MainWindow.ScheduledTasks.AddTask("say 2", false, DateTime.Now.AddSeconds(2));
            //App.MainWindow.ScheduledTasks.AddTask("say 3", false, DateTime.Now.AddSeconds(3));
            //App.MainWindow.ScheduledTasks.AddTask("say 4", false, DateTime.Now.AddSeconds(4));
            //App.MainWindow.ScheduledTasks.AddTask("say 5", false, DateTime.Now.AddSeconds(5));

            //App.MainWindow.BatchTasks.AddTask("say 1", false);
            //App.MainWindow.BatchTasks.AddTask("say 2", false);
            //App.MainWindow.BatchTasks.AddTask("say 3", false);
            //App.MainWindow.BatchTasks.AddTask("say 4", false);
            //App.MainWindow.BatchTasks.AddTask("say 5", false);

            //App.MainWindow.BatchTasks.StartBatch(1);

        }

    }
}
