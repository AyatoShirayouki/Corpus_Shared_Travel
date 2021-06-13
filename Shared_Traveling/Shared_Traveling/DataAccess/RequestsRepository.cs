using Microsoft.EntityFrameworkCore;
using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.DataAccess
{
    public class RequestsRepository : BaseRepository<Request>
    {
        public RequestsRepository() : base() { }
        public RequestsRepository(UnitOfWork uow) : base(uow) { }
        protected override IQueryable<Request> CascadeInclude(IQueryable<Request> query)
        {
            return query.Include(c => c.ParentPost);
        }
    }
}
