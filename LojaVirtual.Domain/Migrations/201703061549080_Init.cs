namespace LojaVirtual.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TbProduto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Descricao = c.String(maxLength: 300),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TbProduto");
        }
    }
}
