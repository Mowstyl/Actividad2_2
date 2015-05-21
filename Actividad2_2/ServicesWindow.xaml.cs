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
    /// Interaction logic for ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        public ServicesWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private string[] divingTypes = { "3 días iniciación", "3 días alta mar" };
        private string[] carTypes = { "Modelo 1", "Modelo 2", "Modelo 3" };
        private string[] hours = {"00:00", "00:30", "01:00", "01:30", "02:00","02:30", "03:00", "03:30"
                                     , "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00"
                                     , "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"
                                     , "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00"
                                     , "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30"
                                     , "22:00", "22:30", "23:00", "23:30"};

        private void Reset()
        {
            foreach (string dType in divingTypes)
                cbDive.Items.Add(dType);
            cbDive.Text = cbDive.Items[0].ToString();
            foreach (string cType in carTypes)
                cbModel.Items.Add(cType);
            cbModel.Text = cbModel.Items[0].ToString();
            foreach (string hour in hours)
            {
                cbHE0.Items.Add(hour);
                cbHE1.Items.Add(hour);
                cbHE2.Items.Add(hour);
                cbHE3.Items.Add(hour);
                cbHE4.Items.Add(hour);
                cbHS0.Items.Add(hour);
                cbHS1.Items.Add(hour);
                cbHS2.Items.Add(hour);
                cbHS3.Items.Add(hour);
                cbHS4.Items.Add(hour);
            }
            cbHE0.Text = cbHE0.Items[0] as string;
            cbHE1.Text = cbHE0.Items[0] as string;
            cbHE2.Text = cbHE0.Items[0] as string;
            cbHE3.Text = cbHE0.Items[0] as string;
            cbHE4.Text = cbHE0.Items[0] as string;
            cbHS0.Text = cbHE0.Items[0] as string;
            cbHS1.Text = cbHE0.Items[0] as string;
            cbHS2.Text = cbHE0.Items[0] as string;
            cbHS3.Text = cbHE0.Items[0] as string;
            cbHS4.Text = cbHE0.Items[0] as string;
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show(
                "¿Está usted seguro de que desea cerrar?",
                "Confirmar",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.No);
            e.Cancel = exit == MessageBoxResult.No;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show(
                "Servicio cancelado.",
                "Éxito",
                MessageBoxButton.OK);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show(
                "Cambios guardados.",
                "Éxito",
                MessageBoxButton.OK);
        }
    }
}
