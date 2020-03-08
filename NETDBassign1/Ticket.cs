using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicketApp
{
    public abstract class Ticket
    {
        public int ID { get; set; }
        public string Summary { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Submitter { get; set; }
        public string Watching { get; set; }
        public string Assigned { get; set; }


    }
}
