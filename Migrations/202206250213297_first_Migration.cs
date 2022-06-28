namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 250),
                        Codigo = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Seccions",
                c => new
                    {
                        SeccionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 6),
                    })
                .PrimaryKey(t => t.SeccionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seccions");
            DropTable("dbo.Cursoes");
        }
    }
}
