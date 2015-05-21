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

        private string[] sItems = { "Agua", "Bañadores", "Sombreros", "Gafas", "Flotadores", "Sombrillas"
                                      , "Souvenirs", "Producto SPA 1", "Producto SPA 2", "Producto SPA 3"
                                      ,"Bebida 1", "Bebida 2", "Bebida 3", "Ingrediente 1", "Ingrediente 2"
                                      , "Ingrediente 3", "Ingrediente 4"};

        private string[] providers = { "Nabla S.A.", "Greyarch", "Lil' minotaur" };

        private void Reset()
        {
            tbQt.Text = "0";
            foreach (string sItem in sItems)
                cbSItems.Items.Add(sItem);
            cbSItems.Text = cbSItems.Items[0].ToString();

            foreach (string provider in providers)
                cbProvider.Items.Add(provider);
            cbProvider.Text = cbProvider.Items[0].ToString();
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

        private void bCheckout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Pedido realizado con éxito.",
                "Éxito",
                MessageBoxButton.OK);
        }
    }
}
