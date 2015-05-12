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
    /// Interaction logic for CancelationWindow.xaml
    /// </summary>
    public partial class CancelationWindow : Window
    {
        public CancelationWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private void Reset()
        {
            rbNo.IsChecked = true;
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bAccept_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
