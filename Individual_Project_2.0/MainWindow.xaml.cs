﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace Individual_Project_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Ticket> tickets = new ObservableCollection<Ticket>();


        public object DataGridTickets { get; internal set; }

        public MainWindow()
        {
            InitializeComponent();
            Ticket ticket = new Ticket();
            DataContext = ticket;

        }

        private void Reset_Filters(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Bilet(object sender, RoutedEventArgs e)
        {
            AddTicket redaktWindow = new AddTicket(tickets);

            // Отображение второго окна
            redaktWindow.ShowDialog();
        }


        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //дирижабль
    }
}
