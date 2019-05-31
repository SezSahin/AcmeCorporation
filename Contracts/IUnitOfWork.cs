using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        ITicketRepository TicketRepository { get; }
        int Complete();
    }
}
