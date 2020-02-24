using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class Enhancement : Ticket
    {
        public string Software { get; set; }
        public string Cost { get; set; }
        public string Reason { get; set; }
        public int Estimate { get; set; }
    }
}
