using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TicketApp
{
    class Bug : Ticket
    {
        public Bug(int id, string sum, string pri, string stat, string sub, string assi, string watch, string severity)
        {
            ID = id;
            Summary = sum;
            Priority = pri;
            Status = stat;
            Submitter = sub;
            Assigned = assi;
            Watching = watch;
            Severity = severity;
        }
        public Bug()
        {

        }
        public static Bug CreateBug(int id)
        {
            Bug newTicket = new Bug();
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
            Console.WriteLine("Enter bug severity");
            newTicket.Severity = Console.ReadLine();
            return newTicket;
            
        }

        public string BugCSVFormat()
        {
            string ticketWatching = $"{Submitter}|{Watching}|Bill Jones";
            string ticketCSV = $"{ID},{Summary},{Status},{Priority},{Submitter},{Assigned},{ticketWatching},{Severity}";
            return ticketCSV;
        }

        public Bug(string s)
        {
            string[] arr = s.Split(',');
            ID = Int32.Parse(arr[0]);
            Summary = arr[1];
            Status = arr[2];
            Priority = arr[3];
            Submitter = arr[4];
            Assigned = arr[5];
            Watching = arr[6];
            Severity = arr[7];
        }
        public void PrintBug()
        {
            string format = $"{ID,-10}\t{Summary,-25}\t{Status,-10}\t{Priority,-10}\t{Submitter,-10}\t{Assigned,-10}\t{Watching,-40}\t{Severity,-10}";
            Console.WriteLine(format);
        }
        public string Severity { get; set; }
    }
}
