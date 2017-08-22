namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPolicy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PolicyType = c.Int(nullable: false),
                        PolicyNumber = c.Int(nullable: false),
                        TotalAnnualReward = c.Double(nullable: false),
                        State = c.String(),
                        CriationDate = c.DateTime(nullable: false),
                        BusinessUnity = c.String(),
                        Product = c.String(),
                        ClientNumber = c.String(),
                        Currency = c.String(),
                        ExpirationDate = c.DateTime(nullable: false),
                        MediatingAgent = c.String(),
                        Branch = c.String(),
                        PaymentMethod = c.String(),
                        Fractionation = c.String(),
                        LocationWarranty = c.String(),
                        UserViewModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserViewModels", t => t.UserViewModelID, cascadeDelete: true)
                .Index(t => t.UserViewModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Policies", "UserViewModelID", "dbo.UserViewModels");
            DropIndex("dbo.Policies", new[] { "UserViewModelID" });
            DropTable("dbo.Policies");
        }
    }
}
