﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CoastalNav
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnNav_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Navigation));
        }


        private void btnLandMarks_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Landmarks));
        }

        private void btnCoastGaurd_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CoastGaurd));
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void btnWild_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Wild));
        }

        
    }
}
