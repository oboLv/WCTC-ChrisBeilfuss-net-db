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
            Console.WriteLine("1. View Tickets");
            Console.WriteLine("2. Create New Ticket");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                int lines = 0;
                string format = "{0,-10}\t{1,-25}\t{2,10}\t{3,10}\t{4,10}\t{5,10}\t{6,40}";
                StreamReader sR = new StreamReader(file);
                while (!sR.EndOfStream)
                {
                    string toArray = sR.ReadLine();

                    string[] stringArray = toArray.Split(',');

                    if (lines == 1)
                    {
                        Console.WriteLine(format, "-------", "-------", "-------", "-------", "-------", "-------", "-------");
                    }
                    Console.WriteLine(format, stringArray[0], stringArray[1], stringArray[2], stringArray[3], stringArray[4], stringArray[5], stringArray[6]);
                    lines++;
                }
                sR.Close();
            }
            else if (userInput == "2")
            {
                int ticketID = 0;
                StreamReader sR = new StreamReader(file);
                while (!sR.EndOfStream)//get next TicketID number
                {
                    string toArray = sR.ReadLine();
                    if (sR.EndOfStream)
                    {
                        string[] stringArray = toArray.Split(',');
                        int ticketIDOld = Convert.ToInt32(stringArray[0]);
                        ticketID = ticketIDOld + 1;
                    }
                    
                }
                Console.WriteLine(ticketID);
                Console.WriteLine("Enter the ticket summary");
                string ticketSummary = Console.ReadLine();
                Console.WriteLine("Enter the ticket status");
                string ticketStatus = Console.ReadLine();
                Console.WriteLine("Enter the ticket priority");
                string ticketPriority = Console.ReadLine();
                Console.WriteLine("Enter the ticket submitter");
                string ticketSubmitter = Console.ReadLine();
                Console.WriteLine("Enter who is assigned to this ticket");
                string ticketAssigned = Console.ReadLine();
                string ticketWatching = $"{ticketSubmitter}|{ticketAssigned}|Bill Jones";
                string ticketCSV = "{0},{1},{2},{3},{4},{5},{6}";
                StreamWriter sW = new StreamWriter(file);
                sW.WriteLine(ticketCSV, ticketID, ticketSummary, ticketStatus, ticketPriority, ticketSubmitter, ticketAssigned, ticketWatching);
            }
                Console.ReadKey();
        }
    }
}