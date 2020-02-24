using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class Task : Ticket
    {
        public string ProjectName { get; set; }
        public string DueDate { get; set; }
    }
}
