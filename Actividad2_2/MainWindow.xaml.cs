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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividad2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuLogIn_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog();
            if (login.tbUser.Text == String.Empty && login.pbPass.Password == String.Empty)
            {
                MenuWindow menu = new MenuWindow();
                this.Close();
                menu.Show();
            }
        }

        private void menuDatabase_Click(object sender, RoutedEventArgs e)
        {
            DatabaseWindow database = new DatabaseWindow();
            database.ShowDialog();
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
    }
}
