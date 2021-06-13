using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.Requests
{
    public class IndexVM
    {
        public User User { get; set; }
        public int ParentId { get; set; }
        public TravelPost Post { get; set; }
        public List<Request> Items { get; set; }


        //public List<int> UserIds { get; set; }
        //public int PostId { get; set; }
        //public List<User> SharedWith { get; set; }
        //public List<User> Users { get; set; }
    }
}
