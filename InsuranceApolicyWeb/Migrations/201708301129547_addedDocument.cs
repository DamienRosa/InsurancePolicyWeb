namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDocument : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDocumentModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DocumentType = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Document = c.String(),
                        PolicyModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyModels", t => t.PolicyModelID, cascadeDelete: true)
                .Index(t => t.PolicyModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDocumentModels", "PolicyModelID", "dbo.PolicyModels");
            DropIndex("dbo.UserDocumentModels", new[] { "PolicyModelID" });
            DropTable("dbo.UserDocumentModels");
        }
    }
}
