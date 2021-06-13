using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.TravelPosts
{
    public class ApproveVM
    {
        public User User { get; set; }
        public List<int> UserIds { get; set; }
        public int PostId { get; set; }
        public TravelPost TravelPost { get; set; }
        public List<User> Approved { get; set; }
        public List<User> Users { get; set; }
    }
}
