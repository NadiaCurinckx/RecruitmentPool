namespace RP_DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersoonKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persoon",
                c => new
                    {
                        IdPersoon = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Voornaam = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.IdPersoon);
            
            CreateTable(
                "dbo.Sollicitatie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        Opmerkingen = c.String(),
                        PersoonId_IdPersoon = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persoon", t => t.PersoonId_IdPersoon)
                .Index(t => t.PersoonId_IdPersoon);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sollicitatie", "PersoonId_IdPersoon", "dbo.Persoon");
            DropIndex("dbo.Sollicitatie", new[] { "PersoonId_IdPersoon" });
            DropTable("dbo.Sollicitatie");
            DropTable("dbo.Persoon");
        }
    }
}
