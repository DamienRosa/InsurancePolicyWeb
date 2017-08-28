namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVehicleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserVehicleModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LicensePlate = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        GrossWeight = c.Double(nullable: false),
                        Capacity = c.Double(nullable: false),
                        NumberOfSeats = c.Int(nullable: false),
                        PolicyModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyModels", t => t.PolicyModelID, cascadeDelete: true)
                .Index(t => t.PolicyModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVehicleModels", "PolicyModelID", "dbo.PolicyModels");
            DropIndex("dbo.UserVehicleModels", new[] { "PolicyModelID" });
            DropTable("dbo.UserVehicleModels");
        }
    }
}
