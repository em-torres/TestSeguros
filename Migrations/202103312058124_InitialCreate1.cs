namespace AfiliadosTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Detalle_Planes", "AfiliadosID", "dbo.Afiliados");
            DropForeignKey("dbo.Detalle_Planes", "Estatus_Id", "dbo.Estatus");
            DropForeignKey("dbo.Detalle_Planes", "PlanesID", "dbo.Planes");
            DropForeignKey("dbo.Detalle_Planes", "Planes_Id", "dbo.Planes");
            DropIndex("dbo.Detalle_Planes", new[] { "PlanesID" });
            DropIndex("dbo.Detalle_Planes", new[] { "AfiliadosID" });
            DropIndex("dbo.Detalle_Planes", new[] { "Estatus_Id" });
            DropIndex("dbo.Detalle_Planes", new[] { "Planes_Id" });
            DropTable("dbo.Detalle_Planes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Detalle_Planes",
                c => new
                    {
                        PlanesID = c.Int(nullable: false),
                        AfiliadosID = c.Int(nullable: false),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Cedula = c.String(),
                        MontoConsumido = c.String(),
                        AfiliadosEstatusEstado = c.String(),
                        Estatus_Id = c.Int(),
                        Planes_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.PlanesID, t.AfiliadosID });
            
            CreateIndex("dbo.Detalle_Planes", "Planes_Id");
            CreateIndex("dbo.Detalle_Planes", "Estatus_Id");
            CreateIndex("dbo.Detalle_Planes", "AfiliadosID");
            CreateIndex("dbo.Detalle_Planes", "PlanesID");
            AddForeignKey("dbo.Detalle_Planes", "Planes_Id", "dbo.Planes", "Id");
            AddForeignKey("dbo.Detalle_Planes", "PlanesID", "dbo.Planes", "Id");
            AddForeignKey("dbo.Detalle_Planes", "Estatus_Id", "dbo.Estatus", "Id");
            AddForeignKey("dbo.Detalle_Planes", "AfiliadosID", "dbo.Afiliados", "Id", cascadeDelete: true);
        }
    }
}
