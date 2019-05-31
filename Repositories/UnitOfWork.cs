using Contracts;
using Entities.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _db;
        public UnitOfWork(DataContext db)
        {
            _db = db;
            ProductRepository = new ProductRepository(_db);
            TicketRepository = new TicketRepository(_db);
        }
        public IProductRepository ProductRepository { get; }
        public ITicketRepository TicketRepository { get; }

        public int Complete()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
