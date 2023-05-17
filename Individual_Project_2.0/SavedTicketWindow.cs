using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Individual_Project_2._0
{
    public class SavedTicketWindow : Window
    {
        public SavedTicketWindow(Ticket ticket)
        {
            // Создание окна и настройка его свойств
            Title = "Сохраненный билет";
            Width = 400;
            Height = 200;

            // Создание элементов управления для отображения данных билета
            var ticketInfo = new TextBlock
            {
                Text = $"Направление отправления: {ticket.FullName}\n" +
                       $"Направление прибытия: {ticket.DepartureTime}\n" +
                       $"Дата отправления: {ticket.Direction}\n" +
                       $"Время отправления: {ticket.DepartureTime}\n" +
                       $"Цена: {ticket.Price}\n" +
                       $"Места: {ticket.SeatNumber}",
                Margin = new Thickness(10),
                TextWrapping = TextWrapping.Wrap
            };

            // Добавление элемента управления в содержимое окна
            Content = ticketInfo;
        }
    }
}
