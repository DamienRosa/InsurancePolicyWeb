namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameToPolicyModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Policies", newName: "PolicyModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PolicyModels", newName: "Policies");
        }
    }
}
