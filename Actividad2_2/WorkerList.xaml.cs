using System;
using System.Collections;
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
    /// Interaction logic for WorkerList.xaml
    /// </summary>
    public partial class WorkerList : Window
    {
        public WorkerList()
        {
            InitializeComponent();
            this.Reset();
        }

        private bool active = true;

        private string[] workerTypes ={"Recepcionista","Auxiliar de recepción","Cociner@", "Ayudante de cocina","Camarer@",
                                     "Limpiador/a","Gobernant@", "Fisioterapeuta","Médico", "Socorrista", "Mantenimiento",
                                     "Administrativ@", "Director/a gerente del hotel"};

        public void Reset()
        {
            lbJob.Items.Clear();
            foreach (string workerType in workerTypes)
                lbJob.Items.Add(workerType);
            lbWorker.Items.Clear();
        }

        private void bNew_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow worwin = new WorkersWindow();
            worwin.tbWorkerID.Text = "1";
            worwin.ShowDialog();
        }

        private void bOpen_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow worwin = new WorkersWindow();
            worwin.tbWorkerID.Text = "0";
            worwin.tbName.Text = "Éster";
            worwin.tbDNI.Text = "12345678-A";
            worwin.tbSurname.Text = "Píscore";
            worwin.tbPhone0.Text = "612345789";
            worwin.tbPhone1.Text = "912345678";
            worwin.tbProvince.Text = "Cuenca";
            worwin.tbCity.Text = "Villaverde";
            worwin.dpStart.Text = "01/05/2015";
            worwin.dpEnd.Text = "01/09/2015";
            worwin.tbAccount.Text = "1234-5678-9000-0000";
            worwin.tbSalary.Text = "1000 €";
            worwin.cbType.Text = "Recepcionista";
            worwin.tbNotes.Text = "Buena trabajadora";
            worwin.ShowDialog();
        }

        private void lbJob_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbWorker.Items.Clear();
            bOpen.IsEnabled = false;
            if (lbJob.SelectedItem.ToString() == "Recepcionista")
                lbWorker.Items.Add("0 - Píscore, Éster");
        }

        private void lbWorker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbWorker.SelectedItem != null)
            {
                bOpen.IsEnabled = true;
                bStart.IsEnabled = !active;
                bStop.IsEnabled = active;
            }
            else
            {
                bOpen.IsEnabled = false;
                bStart.IsEnabled = false;
                bStop.IsEnabled = false;
            }
        }

        private void bStop_Click(object sender, RoutedEventArgs e)
        {
            active = false;
            lbWorker.Items.Clear();
            lbWorker.Items.Add("BAJA - Píscore, Éster");
        }

        private void bStart_Click(object sender, RoutedEventArgs e)
        {
            active = true;
            lbWorker.Items.Clear();
            lbWorker.Items.Add("0 - Píscore, Éster");
        }
    }
}
