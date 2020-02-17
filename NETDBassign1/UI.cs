using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDBassign1
{
    class UI
    {
        public string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. View Tickets");
            Console.WriteLine("2. Create New Ticket");
            Console.WriteLine("3. Exit Application");
            string input = Console.ReadLine();
            return input;
        }
        public string Table(Ticket t)
        {
            string format = $"{t.ID,-10}\t{t.Summary,-25}\t{t.Status,-10}\t{t.Priority,-10}\t{t.Submitter,-10}\t{t.Assigned,-10}\t{t.Watching,-40}";
            return format;
        }
    }
}
