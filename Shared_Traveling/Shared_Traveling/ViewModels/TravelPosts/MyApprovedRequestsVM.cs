﻿using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.ViewModels.TravelPosts
{
    public class MyApprovedRequestsVM
    {
        public List<TravelPost> Items { get; set; }
        public List<User> Users { get; set; }
    }
}
