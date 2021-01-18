namespace Blog18Ocak2021.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yazilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false),
                        KisaAciklama = c.String(),
                        Icerik = c.String(),
                        Foto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yazilar");
        }
    }
}
