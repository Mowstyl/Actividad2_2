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
    /// Interaction logic for ShopStockWindow.xaml
    /// </summary>
    public partial class ShopStockWindow : Window
    {
        public ShopStockWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private string[] sItems = { "Agua", "Bañadores", "Sombreros", "Gafas", "Flotadores", "Sombrillas", "Souvenirs" };

        private void Reset()
        {
            tbQt.Text = "0";
            foreach (string sItem in sItems)
                cbSItems.Items.Add(sItem);
            cbSItems.Text = cbSItems.Items[0].ToString();
        }

        private void bOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbQt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                bCheckout.IsEnabled = Convert.ToInt32(tbQt.Text) > 0;
            }
            catch
            {
                bCheckout.IsEnabled = false;
            }
        }
    }
}
