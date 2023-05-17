using System;
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

namespace Individual_Project_2._0
{
    /// <summary>
    /// Логика взаимодействия для AddTicket.xaml
    /// </summary>
    public partial class AddTicket : Window
    {
        private List<Ticket> tickets; // Коллекция билетов

        public AddTicket()
        {
            InitializeComponent();
            tickets = new List<Ticket>(); // Инициализация коллекции билетов
            Coloms.ItemsSource = tickets; // Установка источника данных для DataGrid
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Получение выбранного билета из DataGrid
            var selectedTicket = (Ticket)Coloms.SelectedItem;

            // Проверка наличия выбранного билета
            if (selectedTicket != null)
            {
                // Создание нового окна для отображения сохраненных данных
                SavedTicketWindow savedTicketWindow = new SavedTicketWindow(selectedTicket);
                savedTicketWindow.Show();
            }
        }


        private void Clear_Click_1(object sender, RoutedEventArgs e)
        {
            TextBoxFullName.Text = string.Empty;
            TextBoxDepartureTime.Text = string.Empty;
            ComboBoxDirection.SelectedIndex = -1;
            TextBoxSeatNumber.Text = string.Empty;
            TextBoxPrice.Text = string.Empty;
            TextBoxComments.Text = string.Empty;
        }


        
    }
}
