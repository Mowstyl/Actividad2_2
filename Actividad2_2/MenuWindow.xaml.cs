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
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBG.jpg", UriKind.Absolute));
            Background = ib;
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
            ListBookWindow book = new ListBookWindow();
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

        private void bShopSpa_Click(object sender, RoutedEventArgs e)
        {
            SpaShopWindow spas = new SpaShopWindow();
            spas.ShowDialog();
        }

        private void bShop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shop = new ShopWindow();
            shop.ShowDialog();
        }

        private void bWorkers_Click(object sender, RoutedEventArgs e)
        {
            WorkerList wor = new WorkerList();
            wor.ShowDialog();
        }

        private void bBar_Click(object sender, RoutedEventArgs e)
        {
            BarWindow bar = new BarWindow();
            bar.ShowDialog();
        }

        private void bLaundry_Click(object sender, RoutedEventArgs e)
        {
            LaundryWindow laun = new LaundryWindow();
            laun.ShowDialog();
        }

        private void bStock_Click(object sender, RoutedEventArgs e)
        {
            ShopStockWindow stock = new ShopStockWindow();
            stock.ShowDialog();
        }

        private void bArrSpa_Click(object sender, RoutedEventArgs e)
        {
            ArrivalSpaWindow arrspa = new ArrivalSpaWindow();
            arrspa.ShowDialog();
        }

        private void bLeave_Click(object sender, RoutedEventArgs e)
        {
            LeaveHotelWindow lvh = new LeaveHotelWindow();
            lvh.ShowDialog();
        }
    }
}
