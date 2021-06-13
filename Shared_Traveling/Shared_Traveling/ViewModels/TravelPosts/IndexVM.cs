using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.TravelPosts
{
    public class IndexVM
    {
        public List<TravelPost> Items { get; set; }
        public User User { get; set; }

        public string PUFirstName { get; set; }
        public string PULastName { get; set; }
        public string PUUsername { get; set; }
    }
}
