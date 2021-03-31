namespace AfiliadosTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estatus", "Estado", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estatus", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
