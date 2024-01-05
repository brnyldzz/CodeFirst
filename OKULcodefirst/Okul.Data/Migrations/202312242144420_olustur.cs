namespace Okul.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class olustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        adresID = c.Int(nullable: false, identity: true),
                        adresAdi = c.String(nullable: false, maxLength: 100),
                        adresAciklama = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.adresID);
            
            CreateTable(
                "dbo.Bolum",
                c => new
                    {
                        bolumID = c.Int(nullable: false, identity: true),
                        bolumAdi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.bolumID);
            
            CreateTable(
                "dbo.Brans",
                c => new
                    {
                        bransID = c.Int(nullable: false, identity: true),
                        bransAdi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.bransID);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false, identity: true),
                        ogrenciNo = c.String(nullable: false, maxLength: 10),
                        ogrenciAdi = c.String(nullable: false, maxLength: 20),
                        ogrenciSoyadi = c.String(nullable: false, maxLength: 30),
                        dogumTarihi = c.DateTime(nullable: false),
                        adres_adresID = c.Int(),
                        bolum_bolumID = c.Int(),
                    })
                .PrimaryKey(t => t.ogrenciID)
                .ForeignKey("dbo.Adres", t => t.adres_adresID)
                .ForeignKey("dbo.Bolum", t => t.bolum_bolumID)
                .Index(t => t.adres_adresID)
                .Index(t => t.bolum_bolumID);
            
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        ogretmenID = c.Int(nullable: false, identity: true),
                        sicilNo = c.String(nullable: false, maxLength: 10),
                        ogretmenAdi = c.String(nullable: false, maxLength: 20),
                        ogretmenSoyadi = c.String(nullable: false, maxLength: 30),
                        adres_adresID = c.Int(),
                        brans_bransID = c.Int(),
                    })
                .PrimaryKey(t => t.ogretmenID)
                .ForeignKey("dbo.Adres", t => t.adres_adresID)
                .ForeignKey("dbo.Brans", t => t.brans_bransID)
                .Index(t => t.adres_adresID)
                .Index(t => t.brans_bransID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogretmen", "brans_bransID", "dbo.Brans");
            DropForeignKey("dbo.Ogretmen", "adres_adresID", "dbo.Adres");
            DropForeignKey("dbo.Ogrenci", "bolum_bolumID", "dbo.Bolum");
            DropForeignKey("dbo.Ogrenci", "adres_adresID", "dbo.Adres");
            DropIndex("dbo.Ogretmen", new[] { "brans_bransID" });
            DropIndex("dbo.Ogretmen", new[] { "adres_adresID" });
            DropIndex("dbo.Ogrenci", new[] { "bolum_bolumID" });
            DropIndex("dbo.Ogrenci", new[] { "adres_adresID" });
            DropTable("dbo.Ogretmen");
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Brans");
            DropTable("dbo.Bolum");
            DropTable("dbo.Adres");
        }
    }
}
