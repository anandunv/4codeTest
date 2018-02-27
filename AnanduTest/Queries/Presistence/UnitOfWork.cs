using Queries.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Presistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;

            // Assign Context for repositories here
            // Customers = new CustomerRepository(_context);

        }

        // proprty for customer repositories
        //public ICustomerRepository Customers { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
