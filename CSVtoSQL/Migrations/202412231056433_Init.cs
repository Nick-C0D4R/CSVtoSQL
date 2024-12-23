namespace CSVtoSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransferModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TpepPickupDateTime = c.DateTime(nullable: false),
                        TpepDropoffDateTime = c.DateTime(nullable: false),
                        PassengerCount = c.Int(nullable: false),
                        TripDistance = c.Double(nullable: false),
                        PULocationId = c.Int(nullable: false),
                        DOLocationId = c.Int(nullable: false),
                        FareAmount = c.Double(nullable: false),
                        TipAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransferModels");
        }
    }
}
