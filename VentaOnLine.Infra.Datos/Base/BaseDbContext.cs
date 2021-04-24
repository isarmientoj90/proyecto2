using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnLine.Domain.Models;

namespace VentaOnLine.Infra.Datos.Base
{
    public abstract class BaseDbContext: DbContext
    {

        public BaseDbContext(string connectionStringName)
            : base(connectionStringName)
        {
           

        }

        public virtual DbSet<Categoria> Categoria {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
