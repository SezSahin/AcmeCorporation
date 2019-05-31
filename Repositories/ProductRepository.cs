using Contracts;
using Entities.Data;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataContext db) : base(db)
        {

        }

        public bool Any()
        {
            return _db.Set<Product>().Any();
        }
    }
}
