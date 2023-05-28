using Individual_Project_2._0;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Individual_Project_2._0
{
    public class Ticket
    {
        public string FullName { get; set; }
        public string DepartureTime { get; set; }
        public string Direction { get; set; }
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }
        public string Comments { get; set; }




        private void GenerateSalesReport(List<Ticket> tickets)
        {
            decimal totalSales = tickets.Sum(ticket => ticket.Price);
            string reportText = $"Всего продано: {totalSales.ToString("C")}";

            string reportFilePath = "C:\\Users\\Admin\\source\\repos\\Individual_Project_2.0";
            File.WriteAllText(reportFilePath, reportText);
        }

    }


}



