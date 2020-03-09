using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TicketApp
{
    class UI
    {
        public string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. View Bug Tickets");
            Console.WriteLine("2. View Enhancement Tickets");
            Console.WriteLine("3. View Task Tickets");
            Console.WriteLine("4. Search Tickets");
            Console.WriteLine("5. Create Bug Ticket");
            Console.WriteLine("6. Create Enhancement Ticket");
            Console.WriteLine("7. Create Task Ticket");
            Console.WriteLine("8. Exit Application");
            string input = Console.ReadLine();
            return input;
        }
        public void BugTable(List<Bug> b)
        {
            string format = "{0,-10}\t{1,-25}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-40}\t{7,-10}";
            Console.WriteLine(format, "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "Severity");
            Console.WriteLine(format, "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------");
            foreach(Bug bug in b)
            {
                bug.PrintBug();
            }
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }
        public void EnhancementTable(List<Enhancement> e)
        {
            string format = "{0,-10}\t{1,-25}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-40}\t{7,-10}\t{8,-10}\t{9,-10}\t{10,-20}\t{11,-10}";
            Console.WriteLine(format, "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "Software", "Cost", "Reason", "Estimate");
            Console.WriteLine(format, "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------");
            foreach (Enhancement en in e)
            {
                en.PrintEnhancement();
            }
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }
        public void TaskTable(List<Task> t)
        {
            string format = "{0,-10}\t{1,-25}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-40}\t{7,-10}\t{8,-10}";
            Console.WriteLine(format, "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "ProjectName", "Due Date");
            Console.WriteLine(format, "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------", "-------");
            foreach (Task task in t)
            {
                task.PrintTask();
            }
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }
        public void FillBugList(List<Bug> bugs, List<Ticket> t)
        {
            StreamReader sR = new StreamReader("Tickets.csv");
            sR.ReadLine();
            while (!sR.EndOfStream)
            {
                Bug bug = new Bug(sR.ReadLine());
                bugs.Add(bug);
                t.Add(bug);
            }
            sR.Close();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }
        public void FillEnhancementList(List<Enhancement> e, List<Ticket> t)
        {
            StreamReader sR = new StreamReader("Enhancements.csv");
            sR.ReadLine();
            while (!sR.EndOfStream)
            {
                Enhancement enhancement = new Enhancement(sR.ReadLine());
                e.Add(enhancement);
                t.Add(enhancement);
            }
            sR.Close();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }
        public void FillTaskList(List<Task> tasks, List<Ticket> t)
        {
            StreamReader sR = new StreamReader("Task.csv");
            sR.ReadLine();
            while (!sR.EndOfStream)
            {
                Task task = new Task(sR.ReadLine());
                tasks.Add(task);
                t.Add(task);
            }
            sR.Close();
        }
        public int GetID(List<Bug> bugs, List<Enhancement> enhancements, List<Task> tasks)
        {
            int ticketID = 0;
            foreach (Bug bug1 in bugs)
            {
                if (bug1.ID > ticketID)
                {
                    ticketID = bug1.ID;
                }
            }
            foreach (Enhancement e in enhancements)
            {
                if (e.ID > ticketID)
                {
                    ticketID = e.ID;
                }
            }
            foreach (Task t in tasks)
            {
                if (t.ID > ticketID)
                {
                    ticketID = t.ID;
                }
            }
            return ticketID;
        }
    }
}
