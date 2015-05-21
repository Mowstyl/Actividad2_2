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
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
            this.Reset();
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

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }

        private void Reset()
        {
            dpToday.SelectedDate = DateTime.Today;
            rbClient.IsChecked = true;
            rbComp04.IsChecked = true;
            rbComp08.IsChecked = true;
            rbComp12.IsChecked = true;
            cbBathrobe1.IsChecked = false;
            cbBathrobe2.IsChecked = false;
            cbBathrobe3.IsChecked = false;
            cbBathrobe4.IsChecked = false;
            cbTowel1.IsChecked = false;
            cbTowel2.IsChecked = false;
            cbTowel3.IsChecked = false;
            cbTowel4.IsChecked = false;
            tbDeposit1.Text = "0 €";
            tbDeposit2.Text = "0 €";
            tbDeposit3.Text = "0 €";
            tbDeposit4.Text = "0 €";
            tbRoomDep1.Text = "0 €";
            tbRoomDep2.Text = "0 €";
            tbRoomDep3.Text = "0 €";
            tbRoomDep4.Text = "0 €";
        }
        private int[,] deposit = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        private int[] roomdeposit = { 0, 0, 0, 0 };
        private void cb_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == cbTowel1)
            {
                if ((bool)cbTowel1.IsChecked)
                    deposit[0, 0] += 10;
                else
                    deposit[0, 0] -= 10;
                roomdeposit[0] = 0;
                for (int i = 0; i < 4; i++)
                    roomdeposit[0] += deposit[0, i];
                tbDeposit1.Text = deposit[0, 0] + " €";
                tbRoomDep1.Text = roomdeposit[0] + " €";
            }
            if (e.Source == cbBathrobe1)
            {
                if ((bool)cbBathrobe1.IsChecked)
                    deposit[0, 0] += 20;
                else
                    deposit[0, 0] -= 20;
                roomdeposit[0] = 0;
                for (int i = 0; i < 4; i++)
                    roomdeposit[0] += deposit[0, i];
                tbDeposit1.Text = deposit[0, 0] + " €";
                tbRoomDep1.Text = roomdeposit[0] + " €";
            }
        }

        private void bMeal_Click(object sender, RoutedEventArgs e)
        {
            MealWindow meal = new MealWindow();
            meal.ShowDialog();
        }

        private void bPay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Pago efectuado con éxito.",
                "Éxito",
                MessageBoxButton.OK);
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Cliente guardado.",
                "Éxito",
                MessageBoxButton.OK);
        }

        private void bCreateKey_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Llave creada.",
                "Éxito",
                MessageBoxButton.OK);
        }
    }
}
