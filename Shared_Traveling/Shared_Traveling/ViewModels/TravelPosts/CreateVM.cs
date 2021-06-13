using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.TravelPosts
{
    public class CreateVM
    {
        public User User { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string CityOfDeparture { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string AddressOfDeparture { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string HourOfDeparture { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string CityOfDestination { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string AddressOfDestination { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string HourOfDestination { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public int AvailableSeats { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public double Price { get; set; }
    }
}
