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
    /// Interaction logic for MealWindow.xaml
    /// </summary>
    public partial class MealWindow : Window
    {
        public MealWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private string[] time = { "17:30", "21:00" };

        private void Reset()
        {
            rbMid.IsChecked = true;
            cbInclude.IsEnabled = false;
            cbTime.IsEnabled = false;

            foreach (string hour in time)
                cbTime.Items.Add(hour);
            cbTime.Text = cbTime.Items[0].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rb_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == rbMid)
            {
                cbInclude.IsEnabled = false;
                cbTime.IsEnabled = false;
            }
            else
            {
                cbInclude.IsEnabled = true;
                cbTime.IsEnabled = true;
            }
        }
    }
}
