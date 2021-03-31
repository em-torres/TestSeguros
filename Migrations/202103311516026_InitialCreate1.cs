namespace AfiliadosTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Planes", "Estatus_Id", "dbo.Estatus");
            DropIndex("dbo.Planes", new[] { "Estatus_Id" });
            RenameColumn(table: "dbo.Planes", name: "Estatus_Id", newName: "EstatusID");
            AlterColumn("dbo.Planes", "EstatusID", c => c.Int(nullable: false));
            CreateIndex("dbo.Planes", "EstatusID");
            AddForeignKey("dbo.Planes", "EstatusID", "dbo.Estatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planes", "EstatusID", "dbo.Estatus");
            DropIndex("dbo.Planes", new[] { "EstatusID" });
            AlterColumn("dbo.Planes", "EstatusID", c => c.Int());
            RenameColumn(table: "dbo.Planes", name: "EstatusID", newName: "Estatus_Id");
            CreateIndex("dbo.Planes", "Estatus_Id");
            AddForeignKey("dbo.Planes", "Estatus_Id", "dbo.Estatus", "Id");
        }
    }
}
