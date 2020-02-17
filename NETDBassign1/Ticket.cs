﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NETDBassign1
{
    class Ticket
    {
        public Ticket(int id, string sum, string pri, string stat, string sub, string assi, string watch)
        {
            ID = id;
            Summary = sum;
            Priority = pri;
            Status = stat;
            Submitter = sub;
            Assigned = assi;
            Watching = watch;
        }
        public Ticket()
        {

        }
        public static Ticket CreateTicket(int id)
        {
            Ticket newTicket = new Ticket();
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
            return newTicket;
        }
        
        public static string TicketCSVFormat(Ticket ticket)
        {
            string ticketWatching = $"{ticket.Submitter}|{ticket.Watching}|Bill Jones";
            string ticketCSV = $"{ticket.ID},{ticket.Summary},{ticket.Status},{ticket.Priority},{ticket.Submitter},{ticket.Assigned},{ticketWatching}";
            return ticketCSV;
        }

        public Ticket(string s)
        {
            string[] arr = s.Split(',');
            ID = Int32.Parse(arr[0]);
            Summary = arr[1];
            Status = arr[2];
            Priority = arr[3];
            Submitter = arr[4];
            Assigned = arr[5];
            Watching = arr[4] + "|" + arr[5] + "|Bill Jones";
        }







        public int ID { get; set; }
        public string Summary { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Submitter { get; set; }
        public string Watching { get; set; }
        public string Assigned { get; set; }


    }
}
