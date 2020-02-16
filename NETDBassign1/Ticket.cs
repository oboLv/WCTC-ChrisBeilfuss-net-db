using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NETDBassign1
{
    class Ticket
    {
        public Ticket(int id, string sum, string pri, string stat, string sub, string assi, string watch)
        {
            ID = id;
            Summary = sum;
            Priority = pri;
            Status = stat;
            Submitter = sub;
            Assigned = assi;
            Watching = watch;

        }
        
        










        public int ID { get; set; }
        public string Summary { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Submitter { get; set; }
        public string Watching { get; set; }
        public string Assigned { get; set; }


    }
}
