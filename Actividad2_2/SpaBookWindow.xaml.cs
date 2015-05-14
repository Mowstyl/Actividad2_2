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
    /// Interaction logic for SpaBookWindow.xaml
    /// </summary>
    public partial class SpaBookWindow : Window
    {
        public SpaBookWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private string[] services = { "Piscina de chorros de agua", "Tratamiento 1", "Tratamiento 2", "Tratamiento 3" };

        private void Reset()
        {
            rbCash.IsChecked = true;
            cbIsClient.IsChecked = false;
            foreach (string service in services)
                cbService.Items.Add(service);
            cbService.Text = cbService.Items[0].ToString();
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

        private void cbIsClient_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)cbIsClient.IsChecked)
                tbRoom.IsEnabled = true;
            else
                tbRoom.IsEnabled = false;
        }
    }
}
