﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace TelcsikeUwU.Ablakok
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public event EventHandler OpenMainWindow;

        public MainPage()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow mp = new MainWindow();

            mp.Show();
        }

        private void CameraClick(object sender, RoutedEventArgs e)
        {
            Camera cc = new Camera();

            CameraCC.Content = cc;
        }

        private void BrowserClick(object sender, RoutedEventArgs e)
        {
            Browser bc = new Browser();

            BrowserCC.Content = bc;

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.google.com",
                UseShellExecute = true
            });
        }

        private void PhoneClick(object sender, RoutedEventArgs e)
        {
            Phone pc = new Phone();

            PhoneCC.Content = pc;
        }
    }
}
