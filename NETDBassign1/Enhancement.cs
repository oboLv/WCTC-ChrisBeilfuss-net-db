using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    public class Enhancement : Ticket
    {
        public Enhancement()
        {

        }
        public static Enhancement CreateEnhancement(int id)
        {
            Enhancement newTicket = new Enhancement();
            newTicket.ID = id++;
            Console.WriteLine("Enter the ticket summary");
            newTicket.Summary = Console.ReadLine();
            Console.WriteLine("Enter the ticket status");
            newTicket.Status = Console.ReadLine();
            Console.WriteLine("Enter the ticket priority");
            newTicket.Priority = Console.ReadLine();
            Console.WriteLine("Enter the ticket submitter");
            newTicket.Submitter = Console.ReadLine();
            Console.WriteLine("Enter who is assigned to this ticket");
            newTicket.Assigned = Console.ReadLine();
            Console.WriteLine("Enter the relevant software");
            newTicket.Software = Console.ReadLine();
            Console.WriteLine("Enter enhancement cost");
            newTicket.Cost = Console.ReadLine();
            Console.WriteLine("Enter reason for enhancement");
            newTicket.Reason = Console.ReadLine();
            Console.WriteLine("Enter enhancement estimate");
            newTicket.Estimate = Console.ReadLine();
            return newTicket;
        }
        public static string EnhanvementCSVFormat(Enhancement ticket)
        {
            string ticketWatching = $"{ticket.Submitter}|{ticket.Watching}|Bill Jones";
            string ticketCSV = $"{ticket.ID},{ticket.Summary},{ticket.Status},{ticket.Priority},{ticket.Submitter},{ticket.Assigned},{ticketWatching},{ticket.Software},{ticket.Cost},{ticket.Reason},{ticket.Estimate}";
            return ticketCSV;
        }
        public Enhancement(string s)
        {
            string[] arr = s.Split(',');
            ID = Int32.Parse(arr[0]);
            Summary = arr[1];
            Status = arr[2];
            Priority = arr[3];
            Submitter = arr[4];
            Assigned = arr[5];
            Watching = arr[6];
            Software = arr[7];
            Cost = arr[8];
            Reason = arr[9];
            Estimate = arr[10];
        }

        public string Software { get; set; }
        public string Cost { get; set; }
        public string Reason { get; set; }
        public string Estimate { get; set; }
    }
}
