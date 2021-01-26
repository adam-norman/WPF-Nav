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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatrialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPopupLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnSideMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            btnSideMenuOpen.Visibility = Visibility.Collapsed;
            btnSideMenuClose.Visibility = Visibility.Visible;
        }

        private void btnSideMenuClose_Click(object sender, RoutedEventArgs e)
        {
            btnSideMenuOpen.Visibility = Visibility.Visible;
            btnSideMenuClose.Visibility = Visibility.Collapsed;
        }
    }
}
