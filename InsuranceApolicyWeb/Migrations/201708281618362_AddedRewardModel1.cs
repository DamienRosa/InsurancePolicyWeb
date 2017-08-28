namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRewardModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolicyRewardModels",
                c => new
                    {
                        PolicyModelID = c.Int(nullable: false),
                        SimpleReward = c.Double(nullable: false),
                        TotalReward = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PolicyModelID)
                .ForeignKey("dbo.PolicyModels", t => t.PolicyModelID)
                .Index(t => t.PolicyModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PolicyRewardModels", "PolicyModelID", "dbo.PolicyModels");
            DropIndex("dbo.PolicyRewardModels", new[] { "PolicyModelID" });
            DropTable("dbo.PolicyRewardModels");
        }
    }
}
