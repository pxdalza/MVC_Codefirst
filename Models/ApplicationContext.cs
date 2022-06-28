namespace MVC_CodeFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }

      
        public DbSet<Curso>Curso { get; set; }
        public DbSet<Seccion>Seccion { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

}