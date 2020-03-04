using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;

namespace Avalon.Plugins.DarkAndShatteredLands
{
    public class TestMenuItem : MenuItem
    {
        public TestMenuItem()
        {
            this.Header = "DSL Website";
            this.Click += this.TestMenuItem_Click;
        }

        private void TestMenuItem_Click(object sender, System.Windows.RoutedEventArgs e)
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

    }
}
