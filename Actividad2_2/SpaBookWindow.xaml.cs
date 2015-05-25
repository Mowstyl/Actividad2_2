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
        private string[] hours = {"00:00", "00:30", "01:00", "01:30", "02:00","02:30", "03:00", "03:30"
                                     , "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00"
                                     , "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"
                                     , "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00"
                                     , "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30"
                                     , "22:00", "22:30", "23:00", "23:30"};


        private void Reset()
        {
            rbCash.IsChecked = true;
            tbCard.IsEnabled = false;
            cbIsClient.IsChecked = false;
            foreach (string service in services)
                cbService.Items.Add(service);
            cbService.Text = cbService.Items[0].ToString();

            foreach (string hour in hours)
                cbTime.Items.Add(hour);
            cbTime.Text = cbTime.Items[0] as string;
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

        private void rb_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbCard.IsChecked)
                tbCard.IsEnabled = true;
            else
                tbCard.IsEnabled = false;
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
