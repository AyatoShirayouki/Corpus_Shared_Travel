using Microsoft.EntityFrameworkCore;
using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.DataAccess
{
    public class AprovedRequestRepository : BaseRepository<AprovedRequest>
    {
        public AprovedRequestRepository(UnitOfWork uow) : base(uow)
        {

        }
        public AprovedRequestRepository() : base()
        {

        }
        protected override IQueryable<AprovedRequest> CascadeInclude(IQueryable<AprovedRequest> query)
        {
            return query.Include(utc => utc.ParentPost)
                .Include(utc => utc.ParentUser);
        }

        public List<User> GetUserByPost(int travelPostId)
        {
            return Items
                .Include(c => c.ParentUser)
                .Include(c => c.ParentPost)
                .Where(u => u.TravelPostId == travelPostId)
                .Select(u => u.ParentUser)
                .ToList();
        }
    }
}
