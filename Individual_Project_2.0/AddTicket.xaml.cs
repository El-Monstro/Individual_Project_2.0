using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Ticket> tickets;


        public AddTicket(ObservableCollection<Ticket> tickets)
        {
            InitializeComponent();

            // Инициализация коллекции билетов
            this.tickets = tickets;
            DataContext = this;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Ticket newTicket = new Ticket
            {
                FullName = TextBoxFullName.Text,
                DepartureTime = TextBoxDepartureTime.Text,
                Direction = (ComboBoxDirection.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                SeatNumber = TextBoxSeatNumber.Text,
                Price = decimal.Parse(TextBoxPrice.Text),
                Comments = TextBoxComments.Text
            };

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            mainWindow.Coloms.Items.Add(newTicket);

            TextBoxFullName.Text = string.Empty;
            TextBoxDepartureTime.Text = string.Empty;
            ComboBoxDirection.SelectedIndex = -1;
            TextBoxSeatNumber.Text = string.Empty;
            TextBoxPrice.Text = string.Empty;
            TextBoxComments.Text = string.Empty;
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
