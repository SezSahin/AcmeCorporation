using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        bool Any();
    }
}
