﻿using System.Windows;
using System.Windows.Controls;

namespace Individual_Project_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ticket ticket = new Ticket();
            DataContext = ticket;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Reset_Filters(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Bilet(object sender, RoutedEventArgs e)
        {
            AddTicket redaktWindow = new AddTicket();

            // Отображение второго окна
            redaktWindow.ShowDialog();
        }
    }
}