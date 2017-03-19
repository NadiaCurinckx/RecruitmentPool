namespace RP_DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SollicitatieKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sollicitatie");
            DropColumn("dbo.Sollicitatie", "Id");
            AddColumn("dbo.Sollicitatie", "IdSollicitatie", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Sollicitatie", "IdSollicitatie");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sollicitatie", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Sollicitatie");
            DropColumn("dbo.Sollicitatie", "IdSollicitatie");
            AddPrimaryKey("dbo.Sollicitatie", "Id");
        }
    }
}
