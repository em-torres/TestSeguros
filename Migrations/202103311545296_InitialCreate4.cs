namespace AfiliadosTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Afiliados", "Planes_Id", "dbo.Planes");
            DropIndex("dbo.Afiliados", new[] { "Estatus_Id" });
            DropIndex("dbo.Afiliados", new[] { "Planes_Id" });
            RenameColumn(table: "dbo.Afiliados", name: "Planes_Id", newName: "PlanesID");
            RenameColumn(table: "dbo.Afiliados", name: "Estatus_Id", newName: "EstatusID");
            AlterColumn("dbo.Afiliados", "EstatusID", c => c.Int(nullable: false));
            AlterColumn("dbo.Afiliados", "PlanesID", c => c.Int(nullable: false));
            CreateIndex("dbo.Afiliados", "PlanesID");
            CreateIndex("dbo.Afiliados", "EstatusID");
            AddForeignKey("dbo.Afiliados", "PlanesID", "dbo.Planes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Afiliados", "PlanesID", "dbo.Planes");
            DropIndex("dbo.Afiliados", new[] { "EstatusID" });
            DropIndex("dbo.Afiliados", new[] { "PlanesID" });
            AlterColumn("dbo.Afiliados", "PlanesID", c => c.Int());
            AlterColumn("dbo.Afiliados", "EstatusID", c => c.Int());
            RenameColumn(table: "dbo.Afiliados", name: "EstatusID", newName: "Estatus_Id");
            RenameColumn(table: "dbo.Afiliados", name: "PlanesID", newName: "Planes_Id");
            CreateIndex("dbo.Afiliados", "Planes_Id");
            CreateIndex("dbo.Afiliados", "Estatus_Id");
            AddForeignKey("dbo.Afiliados", "Planes_Id", "dbo.Planes", "Id");
        }
    }
}
