using AfiliadosTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AfiliadosTest.Data
{
    public class AfiliadosTestContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AfiliadosTestContext() : base("name=AFILIADOS_EDWIN")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afiliados>()
                .HasRequired<Estatus>(s => s.Estatus)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<AfiliadosTest.Models.Estatus> Estatus { get; set; }

        public System.Data.Entity.DbSet<AfiliadosTest.Models.Planes> Planes { get; set; }

        public System.Data.Entity.DbSet<AfiliadosTest.Models.Afiliados> Afiliados { get; set; }
    }
}
