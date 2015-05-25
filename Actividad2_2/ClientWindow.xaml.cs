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
            tbAccount.Text = String.Empty;
            tbAccount.IsEnabled = false;
            tbPrice.Text = "0 €";
            t0.IsEnabled = false;
            t0.Header = "Habitación ";
            t1.IsEnabled = false;
            t1.Header = "Habitación ";
            t2.IsEnabled = false;
            t2.Header = "Habitación ";
            t3.IsEnabled = false;
            t3.Header = "Habitación ";
            g0.IsEnabled = false;
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

        private void tbCDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbCDNI.Text == "11111111-A")
            {
                tbAccount.IsEnabled = true;
                tbAccount.Text = "0000-0000-0000-0001";
                tbPrice.Text = "500 €";
                t0.IsEnabled = true;
                t0.Header = "Habitación 310";
                g0.IsEnabled = true;
                t1.IsEnabled = true;
                t1.Header = "Habitación 311";
            }
            else
                this.Reset();
        }

        private void bBook_Click(object sender, RoutedEventArgs e)
        {
            if (tbCDNI.Text == "11111111-A")
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
                b.IsEnabled = false;
                b.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                "No existe reserva. DNI/Día incorrectos.",
                "Error",
                MessageBoxButton.OK);
            }
        }
    }
}
