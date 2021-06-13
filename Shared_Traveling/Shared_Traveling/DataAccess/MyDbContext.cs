using Microsoft.EntityFrameworkCore;
using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TravelPost> TravelPosts { get; set; }
        public DbSet<AprovedRequest> AprovedRequests { get; set; }
        public DbSet<Request> Requests { get; set; }

        public MyDbContext()
        {
            
            Users = this.Set<User>();
            TravelPosts = this.Set<TravelPost>();
            AprovedRequests = this.Set<AprovedRequest>();
            Requests = this.Set<Request>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SharedTravelingDB;User Id=alex;Password=rexibexi1;");
        }
    }
}
