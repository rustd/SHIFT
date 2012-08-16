using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventContextInitializer : DropCreateDatabaseAlways<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var users = new List<User>()            
            {
                new User() { Name = "Bala" },
                new User() { Name = "Pranav" },
                new User() { Name = "John" },
                new User() { Name = "Suhas" }

            };

            users.ForEach(u => context.Users.Add(u));

            // Team Event 1
            var teamEvent1 = new EventRecord();
            var eventDetails = new List<Event>()
            {
                new Event() { Name="Lunch at Five Guys", Description="Lunch before the movie", Duration = 1},
                new Event() { Name="Batman Movie", Description="AAPT movie event", Duration=4}
            };

            context.EventRecords.Add(teamEvent1);
            eventDetails.ForEach(ed => context.Events.Add(ed));
            teamEvent1.Events = eventDetails;

            // Team Event 2
            var teamEvent2 = new EventRecord();
            var eventDetails2 = new List<Event>()
            {
                new Event() { Name="Lunch at Bai Tong", Description="Lunch", Duration = 1},
                new Event() { Name="Bowling", Description="WPT bowling event", Duration=4}

            };
            context.EventRecords.Add(teamEvent2);
            eventDetails2.ForEach(ed => context.Events.Add(ed));
            teamEvent2.Events = eventDetails2;

            context.SaveChanges();

        }

    }
}
