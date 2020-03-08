using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class Task : Ticket
    {
        public Task()
        {

        }
        public static Task CreateTask(int id)
        {
            Task newTicket = new Task();
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
            Console.WriteLine("Enter the project name");
            newTicket.ProjectName = Console.ReadLine();
            Console.WriteLine("Enter the task due date");
            newTicket.DueDate = Console.ReadLine();
            return newTicket;
        }

        public static string TaskCSVFormat(Task ticket)
        {
            string ticketWatching = $"{ticket.Submitter}|{ticket.Watching}|Bill Jones";
            string ticketCSV = $"{ticket.ID},{ticket.Summary},{ticket.Status},{ticket.Priority},{ticket.Submitter},{ticket.Assigned},{ticketWatching},{ticket.ProjectName},{ticket.DueDate}";
            return ticketCSV;
        }
        public Task(string s)
        {
            string[] arr = s.Split(',');
            ID = Int32.Parse(arr[0]);
            Summary = arr[1];
            Status = arr[2];
            Priority = arr[3];
            Submitter = arr[4];
            Assigned = arr[5];
            Watching = arr[6];
            ProjectName = arr[7];
            DueDate = arr[8];
        }

        public string ProjectName { get; set; }
        public string DueDate { get; set; }
    }
}