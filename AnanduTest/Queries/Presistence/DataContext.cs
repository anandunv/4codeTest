using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Presistence
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=ConnectionName")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }

        //dbset here
        //  public virtual DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //EntityTypeConfiguration setter here
            //   modelBuilder.Configurations.Add(new CustomerConfiguration());

        }
    }
}
