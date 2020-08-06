using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufthavn
{
    class AirContext : DbContext
    {
        public AirContext() 
        {
        

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<Airplane> irplanes { get; set; }
        public virtual DbSet<Airline> airlines { get; set; }

        public virtual DbSet<Airport> airports { get; set; }

        public virtual DbSet<Rute> rutes { get; set; }

        public virtual DbSet<Airplane> Courses { get; set; }

    }
}
