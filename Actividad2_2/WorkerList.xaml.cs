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

        public ArrayList workers = new ArrayList();

        private string[] workerTypes ={"Recepcionista","Auxiliar de recepción","Cociner@", "Ayudante de cocina","Camarer@",
                                     "Limpiador/a","Gobernant@", "Fisioterapeuta","Médico", "Socorrista", "Mantenimiento",
                                     "Administrativ@", "Director/a gerente del hotel"};

        public void Reset()
        {
            foreach (string workerType in workerTypes)
                lbJob.Items.Add(workerType);
            lbWorker.Items.Clear();
            Worker work = new Worker();
            work.job = "Recepcionista";
            work.name = "Ester";
            work.surname = "Píscore";
            work.phone[0] = "612345789";
            work.phone[1] = "912345678";
            work.salary = 1000;
            work.startDate = "01/06/2014";
            work.endDate = "01/09/2014";
            work.notes = "Buena trabajadora";
            work.accountNumber = "1234-5678-9000-0000";
            work.province = "Cuenca";
            work.town = "Villaverde";
            work.dni = "12345678-A";
            work.active = true;
            workers.Add(work);
        }

        private void bNew_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow worwin = new WorkersWindow();
            Worker wor = new Worker();
            worwin.tbWorkerID.Text = wor.getId().ToString();
            worwin.ShowDialog();
            if (worwin.save)
            {
                wor.name = worwin.tbName.Text;
                wor.dni = worwin.tbDNI.Text;
                wor.surname = worwin.tbSurname.Text;
                wor.phone[0] = worwin.tbPhone0.Text;
                wor.phone[1] = worwin.tbPhone1.Text;
                wor.province = worwin.tbProvince.Text;
                wor.town = worwin.tbCity.Text;
                wor.startDate = worwin.dpStart.Text;
                wor.endDate = worwin.dpEnd.Text;
                wor.accountNumber = worwin.tbAccount.Text;
                wor.salary = Convert.ToInt32(worwin.tbSalary.Text);
                wor.job = worwin.cbType.Text;
                wor.notes = worwin.tbNotes.Text;
                workers.Add(wor);
                this.Reset();
            }
        }

        private void bOpen_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow worwin = new WorkersWindow();
            Worker wor = (Worker)lbWorker.SelectedItem;
            worwin.tbWorkerID.Text = wor.getId().ToString();
            worwin.tbName.Text = wor.name;
            worwin.tbDNI.Text = wor.dni;
            worwin.tbSurname.Text = wor.surname;
            worwin.tbPhone0.Text = wor.phone[0];
            worwin.tbPhone1.Text = wor.phone[1];
            worwin.tbProvince.Text = wor.province;
            worwin.tbCity.Text = wor.town;
            worwin.dpStart.Text = wor.startDate;
            worwin.dpEnd.Text = wor.endDate;
            worwin.tbAccount.Text = wor.accountNumber;
            worwin.tbSalary.Text = wor.salary.ToString();
            worwin.cbType.Text = wor.job;
            worwin.tbNotes.Text = wor.notes;
            worwin.ShowDialog();
            if (worwin.save)
            {
                workers.Remove(wor);
                wor.name = worwin.tbName.Text;
                wor.dni = worwin.tbDNI.Text;
                wor.surname = worwin.tbSurname.Text;
                wor.phone[0] = worwin.tbPhone0.Text;
                wor.phone[1] = worwin.tbPhone1.Text;
                wor.province = worwin.tbProvince.Text;
                wor.town = worwin.tbCity.Text;
                wor.startDate = worwin.dpStart.Text;
                wor.endDate = worwin.dpEnd.Text;
                wor.accountNumber = worwin.tbAccount.Text;
                wor.salary = Convert.ToInt32(worwin.tbSalary.Text);
                wor.job = worwin.cbType.Text;
                wor.notes = worwin.tbNotes.Text;
                workers.Add(wor);
                this.Reset();
            }
        }

        private void lbJob_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbWorker.Items.Clear();
            bOpen.IsEnabled = false;
            foreach (Worker worker in workers)
            {
                if (worker.job == Convert.ToString(lbJob.SelectedItem))
                {
                    lbWorker.Items.Add(worker);
                }
            }
        }

        private void lbWorker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bOpen.IsEnabled = true; //Esto hay que cambiarlo luego, prototipo.
        }
    }
}
