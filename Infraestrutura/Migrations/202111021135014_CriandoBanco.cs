namespace Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ControleDeJogos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Adquirir = c.Boolean(nullable: false),
                        DataAdquirir = c.DateTime(nullable: false),
                        Troco = c.Boolean(nullable: false),
                        Vendo = c.Boolean(nullable: false),
                        JogoPlataforma_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JogoDaPlataforma", t => t.JogoPlataforma_Id)
                .Index(t => t.JogoPlataforma_Id);
            
            CreateTable(
                "dbo.JogoDaPlataforma",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataLancamento = c.DateTime(nullable: false),
                        Jogos_Id = c.Guid(),
                        Plataforma_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogos", t => t.Jogos_Id)
                .ForeignKey("dbo.Plataforma", t => t.Plataforma_Id)
                .Index(t => t.Jogos_Id)
                .Index(t => t.Plataforma_Id);
            
            CreateTable(
                "dbo.Jogos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomeJogo = c.String(maxLength: 100, unicode: false),
                        DescricaoJogo = c.String(maxLength: 100, unicode: false),
                        Produtora = c.String(maxLength: 100, unicode: false),
                        Distribuidora = c.String(maxLength: 100, unicode: false),
                        Genero = c.String(maxLength: 100, unicode: false),
                        Site = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomePlataforma = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jogador",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome_PrimeiroNome = c.String(maxLength: 100, unicode: false),
                        Nome_UltimoNome = c.String(maxLength: 100, unicode: false),
                        Email_Endereco = c.String(maxLength: 100, unicode: false),
                        Senha = c.String(maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ControleDeJogos", "JogoPlataforma_Id", "dbo.JogoDaPlataforma");
            DropForeignKey("dbo.JogoDaPlataforma", "Plataforma_Id", "dbo.Plataforma");
            DropForeignKey("dbo.JogoDaPlataforma", "Jogos_Id", "dbo.Jogos");
            DropIndex("dbo.JogoDaPlataforma", new[] { "Plataforma_Id" });
            DropIndex("dbo.JogoDaPlataforma", new[] { "Jogos_Id" });
            DropIndex("dbo.ControleDeJogos", new[] { "JogoPlataforma_Id" });
            DropTable("dbo.Jogador");
            DropTable("dbo.Plataforma");
            DropTable("dbo.Jogos");
            DropTable("dbo.JogoDaPlataforma");
            DropTable("dbo.ControleDeJogos");
        }
    }
}
