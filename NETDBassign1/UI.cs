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
    }
}
