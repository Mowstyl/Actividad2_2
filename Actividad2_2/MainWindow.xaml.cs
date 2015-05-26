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

namespace Actividad2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBG.jpg", UriKind.Absolute));
            Background = ib;
        }

        private void menuLogIn_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog();
            if (login.tbUser.Text == String.Empty && login.pbPass.Password == String.Empty)
            {
                MenuWindow menu = new MenuWindow();
                this.Close();
                menu.Show();
            }
            else if (login.tbUser.Text == "admin" && login.pbPass.Password == "admin")
            {
                MenuWindow menu = new MenuWindow();
                this.Close();
                menu.Show();
            }
            else if (login.tbUser.Text == "user" && login.pbPass.Password == "user")
            {
                MenuWindow menu = new MenuWindow();
                this.Close();
                menu.bBar.IsEnabled = false;
                menu.bBookSpa.IsEnabled = false;
                menu.bLaundry.IsEnabled = false;
                menu.bServices.IsEnabled = false;
                menu.bShop.IsEnabled = false;
                menu.bShopSpa.IsEnabled = false;
                menu.bWorkers.IsEnabled = false;
                menu.Show();
            }
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }
    }
}
