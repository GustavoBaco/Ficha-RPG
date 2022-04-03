namespace Ficha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segundo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClasseModels", "teste", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClasseModels", "teste");
        }
    }
}
