﻿using Avalon.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Controls;
using Argus.Extensions;

namespace Avalon.Plugins.DarkAndShatteredLands
{
    public partial class DslMenuItem : IMenuItem
    {

        /// <summary>
        /// Gets a casted copy of the interpreter
        /// </summary>
        /// <returns></returns>
        private IInterpreter GetInterpreter()
        {
            try
            {
                return (IInterpreter)((MenuItem)this["PluginMenu"]).Tag;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Opens the DSL website.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDslWebite_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShellLink("http://www.dsl-mud.org");
        }

        /// <summary>
        /// Opens the DSL forum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemForum_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShellLink("http://www.dsl-mud.org/forum/default.asp");
        }

        /// <summary>
        /// Opens the DSL Wiki.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemWiki_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShellLink("https://dslmud.fandom.com/wiki/Dslmud_Wiki");
        }

        /// <summary>
        /// Shells a link via System.Diagnostics.Process.
        /// </summary>
        /// <param name="url"></param>
        public void ShellLink(string url)
        {
            var link = new Uri(url);

            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"/c start {link.AbsoluteUri}"
            };

            Process.Start(psi);
        }

        /// <summary>
        /// Attempts to update triggers and aliases from the DSL shared package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MenuItemUpdateDslPackageAsync_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var interp = GetInterpreter();

            if (interp == null)
            {
                return;
            }

            try
            {
                var uri = new Uri("https://avalon-mud-client.azurewebsites.net/download/dsl-import-package.json");
                string json = "";

                using (var wc = new WebClient())
                {
                    json = await wc.DownloadStringTaskAsync("https://avalon-mud-client.azurewebsites.net/download/dsl-import-package.json");
                }

                interp.Conveyor.ImportPackageFromJson(json);
                interp.Conveyor.EchoText("");
                interp.Conveyor.EchoLog("DSL Shared Aliases, Directions and Triggers imported.", Common.Models.LogType.Success);
            }
            catch (Exception ex)
            {
                interp.Conveyor.EchoText("");
                interp.Conveyor.EchoLog("An error occurred downloading or importing the JSON file.", Common.Models.LogType.Error);
                interp.Conveyor.EchoLog(ex.ToFormattedString(), Common.Models.LogType.Error);
            }
        }

        /// <summary>
        /// Checks the status of a con card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MenuItemCheckConCard_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var interp = GetInterpreter();

            if (interp == null)
            {
                return;
            }

            string value = await interp.Conveyor.InputBox("What is the con card code you would like to check the status of?", "Check Con Card");

            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            await interp.Send($"#con-card {value}");
        }

        /// <summary>
        /// Show who is online according to the web-site.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MenuItemPlayersOnline_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var interp = GetInterpreter();

            if (interp == null)
            {
                return;
            }

            await interp.Send($"#online");
        }
    }
}
