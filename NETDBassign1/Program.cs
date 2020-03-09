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
            bool exit = false;
            while (!exit)
            {
                List<Ticket> tickets = new List<Ticket>();
                List<Bug> bugs = new List<Bug>();
                List<Enhancement> enhancements = new List<Enhancement>();
                List<Task> tasks = new List<Task>();
                var ui = new UI();

                string userInput = ui.MainMenu();

                ui.FillBugList(bugs, tickets);
                ui.FillEnhancementList(enhancements, tickets);
                ui.FillTaskList(tasks, tickets);

                if (userInput == "1")//view bug tickets
                {
                    ui.BugTable(bugs);
                }
                else if(userInput == "2")//view enhancements
                {
                    ui.EnhancementTable(enhancements);
                }
                else if(userInput == "3")//view tasks
                {
                    ui.TaskTable(tasks);
                }
                else if(userInput == "4")//search tickets
                {

                    List<Ticket> search = tickets.OrderBy(x => x.Priority == "High").ToList();
                    int o = search.Count();
                    Console.WriteLine(o);
                    Console.ReadLine();
                }
                else if (userInput == "5")//create new bug ticket
                {
                    
                    Bug newBug = Bug.CreateBug(ui.GetID(bugs, enhancements, tasks));
                    bugs.Add(newBug);
                    tickets.Add(newBug);
                    StreamWriter sW = new StreamWriter("Tickets.csv", true);
                    sW.WriteLine(newBug.BugCSVFormat());
                    sW.Close();
                }
                else if(userInput == "6")//create new enhancement ticket
                {
                    Enhancement newEnhancement = Enhancement.CreateEnhancement(ui.GetID(bugs, enhancements, tasks));
                    enhancements.Add(newEnhancement);
                    tickets.Add(newEnhancement);
                    StreamWriter sW = new StreamWriter("Enhancements.csv", true);
                    sW.WriteLine(newEnhancement.EnhancementCSVFormat());
                    sW.Close();
                }
                else if(userInput == "7")//create new task ticket
                {
                    Task newTask = Task.CreateTask(ui.GetID(bugs, enhancements, tasks));
                    tasks.Add(newTask);
                    tickets.Add(newTask);
                    StreamWriter sW = new StreamWriter("Tasks.csv", true);
                    sW.WriteLine(newTask.TaskCSVFormat());
                    sW.Close();
                }
                else if (userInput == "8")//exit app
                {
                    exit = true;
                }
            }
        }
    }
}