﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01b
{
    /// <summary>
    /// Chap2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chap2 : Page
    {
        public Chap2()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            //Chap1_0 newPage = new Chap1_0();
            //NavigationService.Navigate(newPage);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Chap2_1 newPage = new Chap2_1();
            NavigationService.Navigate(newPage);
        }
    }
}

