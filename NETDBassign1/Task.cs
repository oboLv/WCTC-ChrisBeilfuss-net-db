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

        public string TaskCSVFormat()
        {
            string ticketWatching = $"{Submitter}|{Watching}|Bill Jones";
            string ticketCSV = $"{ID},{Summary},{Status},{Priority},{Submitter},{Assigned},{ticketWatching},{ProjectName},{DueDate}";
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
        public void PrintTask()
        {
            string format = $"{ID,-10}\t{Summary,-25}\t{Status,-10}\t{Priority,-10}\t{Submitter,-10}\t{Assigned,-10}\t{Watching,-40}\t{ProjectName,-10}\t{DueDate,-10}";
            Console.WriteLine(format);
        }
        public string ProjectName { get; set; }
        public string DueDate { get; set; }
    }
}