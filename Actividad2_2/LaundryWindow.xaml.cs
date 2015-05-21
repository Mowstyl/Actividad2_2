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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
