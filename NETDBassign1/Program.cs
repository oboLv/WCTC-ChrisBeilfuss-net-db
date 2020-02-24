using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TicketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string bugFile = "Tickets.csv";
            string enhanceFile = "Enhancements.csv";
            string taskFile = "Task.csv";
            bool exit = false;
            while (!exit)
            {
                List<Ticket> tickets = new List<Ticket>();
                var ui = new UI();

                string userInput = ui.MainMenu();

                StreamReader sR = new StreamReader(bugFile);
                sR.ReadLine();
                while (!sR.EndOfStream)
                {
                    Bug ticket = new Bug(sR.ReadLine());
                    //tickets.Add(ticket);
                }
                sR.Close();
                if (userInput == "1")//view bug tickets
                {
                    int lines = 0;
                    
                    
                    foreach (Ticket t in tickets)
                    {
                        string format = "{0,-10}\t{1,-25}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-40}";
                        if(lines == 0)
                        {
                            Console.WriteLine(format, "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching");
                            Console.WriteLine(format, "-------", "-------", "-------", "-------", "-------", "-------", "-------");
                            lines++;
                        }
                        Console.WriteLine(ui.Table(t));
                    }
                    
                    Console.WriteLine("Press any key to proceed");
                    Console.ReadKey();
                }
                else if (userInput == "2")//create new ticket
                {
                    int ticketID = 0;
                    foreach(Ticket ticket in tickets)
                    {
                        if(ticket.ID > ticketID)
                        {
                            ticketID = ticket.ID;
                        }
                    }
                    tickets.Add(Bug.CreateBug(ticketID));
                    StreamWriter sW = new StreamWriter(bugFile, true);
                    foreach(Ticket ticket in tickets)
                    {
                        string newTicket = Bug.BugCSVFormat(ticket);
                        sW.WriteLine(newTicket);
                    }
                    sW.Close();
                }
                else if (userInput == "3")//exit app
                {
                    exit = true;
                }
            }
        }
    }
}