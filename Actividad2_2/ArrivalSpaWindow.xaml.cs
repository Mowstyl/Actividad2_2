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
    /// Interaction logic for ArrivalSpaWindow.xaml
    /// </summary>
    public partial class ArrivalSpaWindow : Window
    {
        public ArrivalSpaWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        public void Reset()
        {
            dpArrival.SelectedDate = DateTime.Today;
        }
    }
}
