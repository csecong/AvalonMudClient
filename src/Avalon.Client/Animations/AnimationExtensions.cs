using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Avalon.Common.Colors;

namespace Avalon.Animations
{
    public static class AnimationExtensions
    {

        public static async Task Pulse(this Control c, DependencyProperty dp, Color color, int durationMilliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();

            try
            {
                if (c?.Dispatcher == null)
                {
                    return;
                }

                await c.Dispatcher.BeginInvoke(new Action(() =>
                {
                    // The color animation of the pulse
                    var ca = new ColorAnimation
                    {
                        Duration = new Duration(TimeSpan.FromMilliseconds(durationMilliseconds)),
                        To = color,
                        AutoReverse = true,
                        FillBehavior = FillBehavior.Stop
                    };

                    c.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                    c.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);

                    ca.Completed += delegate
                    {
                        tcs.SetResult(true);
                    };
                }));
            }
            catch (Exception ex)
            {
                //Task was canceled
                c.Background = Brushes.White;
                return;
            }

            await tcs.Task;

        }
    }

}