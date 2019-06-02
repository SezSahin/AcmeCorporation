using Contracts;
using Entities.Data;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    internal class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(DataContext db) : base(db)
        {

        }

        public bool Any()
        {
            return _db.Set<Ticket>().Any();
        }
    }
}
