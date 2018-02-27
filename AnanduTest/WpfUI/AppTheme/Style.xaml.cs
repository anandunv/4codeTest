using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfUI.AppTheme
{
    public partial class Style
    {
        #region //  Window Events

        private void PART_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Button close = sender as Button;
            Window window = close.Tag as Window;
            window.Close();
        }
        private void PART_MINIMIZE_Click(object sender, RoutedEventArgs e)
        {
            Button minize = sender as Button;
            Window window = minize.Tag as Window;
            window.WindowState = System.Windows.WindowState.Minimized;
        }
        private void PART_MAXIMIZE_RESTORE_Click(object sender, RoutedEventArgs e)
        {
            Button minize = sender as Button;
            Window window = minize.Tag as Window;

            var path = new Path();
            path.Data = Geometry.Parse("M4.3685131,23.127279L4.3685131,47.283243 47.117023,47.283243 47.117023,23.127279z M0,10.684L53.755001,10.684 53.755001,51.668001 0,51.668001z M8.5679998,0L58.668022,0 64,0 64,5.6864691 64,45.317999 58.668022,45.317999 58.668022,5.6864691 8.5679998,5.6864691z");

            if (window.WindowState == System.Windows.WindowState.Normal)
            {
                window.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                window.WindowState = System.Windows.WindowState.Normal;
                //M4.3685131,23.127279L4.3685131,47.283243 47.117023,47.283243 47.117023,23.127279z M0,10.684L53.755001,10.684 53.755001,51.668001 0,51.668001z M8.5679998,0L58.668022,0 64,0 64,5.6864691 64,45.317999 58.668022,45.317999 58.668022,5.6864691 8.5679998,5.6864691z"
                //minize.Content = path.Data;
                //minize.Content = path.DataContext;
            }
        }
        private void PART_TITLEBAR_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border dragRectangle = sender as Border;
            Window window = dragRectangle.Tag as Window;
            if (window != null)
            {

                window.DragMove();

            }
        }

        #endregion
    }
}
