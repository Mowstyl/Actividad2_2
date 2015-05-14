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

        private string[] divingtypes = { "3 días iniciación", "3 días alta mar" };

        private void Reset()
        {
            foreach (string dtype in divingtypes)
                cbDive.Items.Add(dtype);
            cbDive.Text = cbDive.Items[0].ToString();
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
    }
}
