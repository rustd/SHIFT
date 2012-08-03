using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    enum EventGenre
    {
        Meal,
        Movie,
        Other
    }
    enum EventStatus
    {
        Proposed,
        Approved,
        Scheduled,
        Canceled,
        Completed
    }

    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; } // in hours
        public string TentativeDate { get; set; }
        public string Venue { get; set; }
        public List<User> Participants { get; set; }
        public EventGenre Genre { get; set; }
        public int NumberOfYes { get; set; }
        public int NumberOfNo { get; set; }
        public int Cost { get; set; }
        public EventStatus Status { get; set; }
    }
}
