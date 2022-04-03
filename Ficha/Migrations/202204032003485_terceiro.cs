namespace Ficha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terceiro : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClasseModels", "teste");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClasseModels", "teste", c => c.String());
        }
    }
}
