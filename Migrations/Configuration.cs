namespace MVC_CodeFirst.Migrations
{
    using MVC_CodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_CodeFirst.Models.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_CodeFirst.Models.ApplicationContext context)
        {
           
            //context.Curso.AddOrUpdate(new Curso() { Nombre = "Visual Studio Fundamentals", Codigo = "VSF21" });

            //base.Seed(context);
        }
    }
}
