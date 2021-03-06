﻿using System;
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
    /// Interaction logic for WorkersWindow.xaml
    /// </summary>
    public partial class WorkersWindow : Window
    {
        public WorkersWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        public bool save = false;

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

        private string[] workerTypes ={"Recepcionista","Auxiliar de recepción","Cociner@", "Ayudante de cocina","Camarer@",
                                     "Limpiador/a","Gobernant@", "Fisioterapeuta","Médico", "Socorrista", "Mantenimiento",
                                     "Administrativ@", "Director/a gerente del hotel"};

        private void Reset()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/BookBG.jpg", UriKind.Absolute));
            Background = ib;

            foreach (string workerType in workerTypes)
                cbType.Items.Add(workerType);
            cbType.Text = cbType.Items[0].ToString();
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            save = true;
            this.Close();
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            save = false;
            this.Close();
        }
    }
}
