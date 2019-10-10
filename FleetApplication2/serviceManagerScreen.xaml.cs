using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FleetApplication2
{
    /// <summary>
    /// Interaction logic for serviceManagerScreen.xaml
    /// </summary>
    public partial class serviceManagerScreen : Window
    {
        
        public serviceManagerScreen()
        {
            InitializeComponent();
        }

        private void topBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void minimizeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void closeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void vehiclesButton_MouseEnter(object sender, MouseEventArgs e)
        {
            vehiclesButton.Background = smWindow.Background;
            //smWindow.Children.Clear(); // to clear out the main window
            //smWindow.Children.Add(); //add the new one
        }

        private void vehiclesButton_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FF5494D4");
            brush.Freeze();
            vehiclesButton.Background = brush;
        }

        private void reportsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            reportsButton.Background = smWindow.Background;
        }

        private void reportsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FF5494D4");
            brush.Freeze();
            reportsButton.Background = brush;
        }
    }
}
