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
            lbBooks.Items.Add("XXX - XXXXXXXX-X, XX/XX/XXXX");
        }

        private void bNew_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow b = new BookingWindow();
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
            b.ShowDialog();
        }
    }
}
