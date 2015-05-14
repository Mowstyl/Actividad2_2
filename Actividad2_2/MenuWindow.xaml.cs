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

namespace Actividad2_2
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void menuLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
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

        private void bBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow book = new BookingWindow();
            book.ShowDialog();
        }

        private void bClient_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow client = new ClientWindow();
            client.ShowDialog();
        }

        private void bServices_Click(object sender, RoutedEventArgs e)
        {
            ServicesWindow serv = new ServicesWindow();
            serv.ShowDialog();
        }

        private void bBookSpa_Click(object sender, RoutedEventArgs e)
        {
            SpaBookWindow spab = new SpaBookWindow();
            spab.ShowDialog();
        }
    }
}
