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
    /// Interaction logic for ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public ShopWindow()
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

        private void bStock_Click(object sender, RoutedEventArgs e)
        {
            ShopStockWindow sstk = new ShopStockWindow();
            sstk.ShowDialog();
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            int qt;
            try
            {
                qt = Convert.ToInt32(tbQt.Text);
            }
            catch
            {
                qt = 0;
            }
            if (qt > 0)
            {
                lbBuyList.Items.Add(cbSItems.Text+" x "+qt);
            }
        }
    }
}
