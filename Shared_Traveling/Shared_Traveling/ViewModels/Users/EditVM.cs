using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.Users
{
    public class EditVM
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string LastName { get; set; }
    }
}
