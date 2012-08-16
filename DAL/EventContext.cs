using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventContext : DbContext
    {
        public EventContext():base("DefaultConnection3"){}

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EventRecord> Records { get; set; }
    }
}
