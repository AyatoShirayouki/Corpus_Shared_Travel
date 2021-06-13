using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Entities
{
    public class TravelPost : BaseEntity
    {
        public int UserId { get; set; }
        public string CityOfDeparture { get; set; }
        public string AddressOfDeparture { get; set; }
        public string HourOfDeparture { get; set; }
        public string CityOfDestination { get; set; }
        public string AddressOfDestination { get; set; }
        public string HourOfDestination { get; set; }
        public int AvailableSeats { get; set; }
        public double Price { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
    }
}
