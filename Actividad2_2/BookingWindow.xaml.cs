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
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingWindow()
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
            foreach (string nRoom in nRooms)
                cbNRoom.Items.Add(nRoom);
            cbNRoom.Text = cbNRoom.Items[0] as string;

            foreach (string roomType in roomTypes)
            {
                cbType0.Items.Add(roomType);
                cbType1.Items.Add(roomType);
                cbType2.Items.Add(roomType);
                cbType3.Items.Add(roomType);
            }
            cbType0.Text = cbType0.Items[0] as string;
            cbType1.Text = cbType1.Items[0] as string;
            cbType2.Text = cbType2.Items[0] as string;
            cbType3.Text = cbType3.Items[0] as string;
        }

        private string[] nRooms = { "1", "2", "3", "4" };

        private string[] roomTypes = { "Estándar", "Vistas al mar", "Superior vistas al mar", "Suite" };

        private void cbNRoom_DropDownClosed(object sender, EventArgs e)
        {
            switch (cbNRoom.Text)
            {
                case "1":
                    cbType1.IsEnabled = false;
                    cbType2.IsEnabled = false;
                    cbType3.IsEnabled = false;
                    break;
                case "2":
                    cbType1.IsEnabled = true;
                    cbType2.IsEnabled = false;
                    cbType3.IsEnabled = false;
                    break;
                case "3":
                    cbType1.IsEnabled = true;
                    cbType2.IsEnabled = true;
                    cbType3.IsEnabled = false;
                    break;
                case "4":
                    cbType1.IsEnabled = true;
                    cbType2.IsEnabled = true;
                    cbType3.IsEnabled = true;
                    break;
            }
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelationWindow cancel = new CancelationWindow();
            cancel.ShowDialog();
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bFood_Click(object sender, RoutedEventArgs e)
        {
            MealWindow m = new MealWindow();
            m.cbTime.Visibility = Visibility.Hidden;
            m.lTime.Visibility = Visibility.Hidden;
            m.ShowDialog();
        }
    }
}
