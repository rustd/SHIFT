using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DAL
{

    public enum EventGenre
    {
        Meal,
        Movie,
        Other
    }
    public enum EventStatus
    {
        Proposed,
        Approved,
        Scheduled,
        Canceled,
        Completed
    }

    public class Event
    {
        public int Id { get; set; }
        public int EventRecordId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; } // in hours
        public string TentativeDate { get; set; }
        public string Venue { get; set; }
        public List<User> Participants { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EventGenre Genre { get; set; }
        public int NumberOfYes { get; set; }
        public int NumberOfNo { get; set; }
        public int Cost { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EventStatus Status { get; set; }
    }
}
