using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Record
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public bool? Vote { get; set; }
    }
}
