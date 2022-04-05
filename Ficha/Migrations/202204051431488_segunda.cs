namespace Ficha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segunda : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClasseModels", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.ClasseModels", "Raca", c => c.String(nullable: false));
            AlterColumn("dbo.ClasseModels", "Classe", c => c.String(nullable: false));
            AlterColumn("dbo.JogadorModels", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.JogadorModels", "Celular", c => c.String(nullable: false));
            AlterColumn("dbo.JogadorModels", "Emai", c => c.String());
            AlterColumn("dbo.JogadorModels", "Personagem", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JogadorModels", "Personagem", c => c.String());
            AlterColumn("dbo.JogadorModels", "Emai", c => c.String(nullable: false));
            AlterColumn("dbo.JogadorModels", "Celular", c => c.String());
            AlterColumn("dbo.JogadorModels", "Nome", c => c.String());
            AlterColumn("dbo.ClasseModels", "Classe", c => c.String());
            AlterColumn("dbo.ClasseModels", "Raca", c => c.String());
            AlterColumn("dbo.ClasseModels", "Nome", c => c.String());
        }
    }
}
