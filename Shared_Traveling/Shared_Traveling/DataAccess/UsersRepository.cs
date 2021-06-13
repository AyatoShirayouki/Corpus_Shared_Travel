using Shared_Traveling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.DataAccess
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(UnitOfWork uow) : base(uow)
        {

        }
        public UsersRepository() : base()
        {

        }
    }
}
