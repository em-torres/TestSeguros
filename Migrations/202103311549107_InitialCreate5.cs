namespace AfiliadosTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Afiliados", "FechaRegistro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Afiliados", "FechaRegistro", c => c.DateTime());
        }
    }
}
