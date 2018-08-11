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

namespace YetAnotherMinesweeper.View
{
    /// <summary>
    /// Interaction logic for GameSuperviser.xaml
    /// </summary>
    public partial class GameSuperviser : UserControl
    {
        public GameSuperviser()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            ((YetAnotherMinesweeper.ViewModel.GameSuperviser)(this.DataContext)).CreateMinefield();
        }
    }
}
