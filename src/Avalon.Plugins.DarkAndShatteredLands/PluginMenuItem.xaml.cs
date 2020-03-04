using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Avalon.Plugins.DarkAndShatteredLands
{
    public partial class PluginMenuItem
    {

        public void MenuItemDslWebite_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var link = new Uri("http://www.dsl-mud.org");

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

        private void MenuItemForum_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var link = new Uri("http://www.dsl-mud.org/forum/default.asp");

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
    }
}
