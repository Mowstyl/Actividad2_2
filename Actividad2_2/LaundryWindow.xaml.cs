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
    /// Interaction logic for LaundryWindow.xaml
    /// </summary>
    public partial class LaundryWindow : Window
    {
        public LaundryWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private string[] cTypes = { "Algodón", "Poliester", "Lana", "Nylon" };

        private string[] pTypes = { "Lavar en frío", "Lavar en caliente", "Lavar y planchar", "Tintar" };

        public void Reset()
        {
            foreach (string cType in cTypes)
                cbType.Items.Add(cType);
            cbType.Text = cbType.Items[0].ToString();

            foreach (string pType in pTypes)
                cbProcess.Items.Add(pType);
            cbProcess.Text = cbProcess.Items[0].ToString();
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbRoom.Text != String.Empty)
                lbToDo.Items.Add(tbRoom.Text + " - " + cbType.Text + " - " + cbProcess.Text);
            else
                MessageBox.Show(
                "Introduce un número de habitación",
                "Error",
                MessageBoxButton.OK);
        }

        private void bReady_Click(object sender, RoutedEventArgs e)
        {
            if (lbToDo.SelectedItem != null)
            {
                lbToSend.Items.Add(lbToDo.SelectedItem);
                lbToDo.Items.Remove(lbToDo.SelectedItem);
            }
            else
                MessageBox.Show(
                "Selecciona un paquete",
                "Error",
                MessageBoxButton.OK);
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            if (lbToSend.SelectedItem != null)
                lbToSend.Items.Remove(lbToSend.SelectedItem);
            else
                MessageBox.Show(
                "Selecciona un paquete",
                "Error",
                MessageBoxButton.OK);
        }
    }
}
