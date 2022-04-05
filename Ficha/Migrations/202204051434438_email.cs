namespace Ficha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JogadorModels", "Email", c => c.String());
            DropColumn("dbo.JogadorModels", "Emai");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JogadorModels", "Emai", c => c.String());
            DropColumn("dbo.JogadorModels", "Email");
        }
    }
}
