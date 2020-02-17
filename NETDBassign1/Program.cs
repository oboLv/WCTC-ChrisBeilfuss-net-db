using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NETDBassign1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            bool exit = false;
            while (!exit)
            {
                List<Ticket> tickets = new List<Ticket>();
                var ui = new UI();

                string userInput = ui.MainMenu();

                StreamReader sR = new StreamReader(file);
                sR.ReadLine();
                while (!sR.EndOfStream)
                {
                    Ticket ticket = new Ticket(sR.ReadLine());
                    tickets.Add(ticket);
                }
                sR.Close();
                if (userInput == "1")//view tickets
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
                    tickets.Add(Ticket.CreateTicket(ticketID));
                    StreamWriter sW = new StreamWriter(file, true);
                    foreach(Ticket ticket in tickets)
                    {
                        string newTicket = Ticket.TicketCSVFormat(ticket);
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