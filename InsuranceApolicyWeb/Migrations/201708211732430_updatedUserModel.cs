namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedUserModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserViewModels");
            AlterColumn("dbo.UserViewModels", "NIF", c => c.String());
            AlterColumn("dbo.UserViewModels", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.UserViewModels", "Email");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserViewModels");
            AlterColumn("dbo.UserViewModels", "Email", c => c.String());
            AlterColumn("dbo.UserViewModels", "NIF", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.UserViewModels", "NIF");
        }
    }
}
