using Microsoft.EntityFrameworkCore;
using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.DataAccess
{
    public class TravelPostsRepository : BaseRepository<TravelPost>
    {
        public TravelPostsRepository(UnitOfWork uow) : base(uow)
        {

        }
        public TravelPostsRepository() : base()
        {

        }
        protected override IQueryable<TravelPost> CascadeInclude(IQueryable<TravelPost> query)
        {
            return query.Include(c => c.ParentUser);
        }
    }
}
