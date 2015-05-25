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
    /// Interaction logic for ListBookWindow.xaml
    /// </summary>
    public partial class ListBookWindow : Window
    {
        public ListBookWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        public void Reset()
        {
            lbBooks.Items.Clear();
            lbBooks.Items.Add("0 - 11111111-A, 21/05/2015");
        }

        private void bNew_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow b = new BookingWindow();
            b.tbBookID.Text = "1";
            b.ShowDialog();
        }

        private void lbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bCancel.IsEnabled = (lbBooks.SelectedItem != null);
            bModify.IsEnabled = bCancel.IsEnabled;
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelationWindow c = new CancelationWindow();
            c.ShowDialog();
            if (c.cancel)
                lbBooks.Items.Remove(lbBooks.SelectedItem);
        }

        private void bModify_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow b = new BookingWindow();
            b.tbBookID.Text = "0";
            b.tbName.Text = "Daniel";
            b.tbDNI.Text = "11111111-A";
            b.tbSurname.Text = "Rabinovich";
            b.tbProvince.Text = "Cuenca";
            b.tbCity.Text = "Pasaconsol";
            b.dpArrival.Text = "21/05/2015";
            b.dpDeparture.Text = "31/05/2015";
            b.tbAccount.Text = "0000-0000-0000-0001";
            b.cbNRoom.Text = "2";
            b.cbType0.Text = "Suite";
            b.cbType1.IsEnabled = true;
            b.cbType1.Text = "Suite";
            b.tbPrice.Text = "500 €";
            b.ShowDialog();
        }
    }
}
