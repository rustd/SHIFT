using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;

namespace API
{
    public class EventsController : ApiController
    {
        EventContext context = new EventContext();

        // GET api/<controller>
        public IEnumerable<Event> Get()
        {
            //context.Events.Add(new Event() { Id = 23, Name = "foo" });
            //context.SaveChanges();
            return context.Events.AsEnumerable();
        }

        // GET api/<controller>/5
        public Event Get(int id)
        {
            return context.Events.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Event e)
        {
            context.Events.Add(e);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}