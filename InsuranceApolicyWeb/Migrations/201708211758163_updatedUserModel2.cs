namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedUserModel2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserViewModels");
            AddColumn("dbo.UserViewModels", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserViewModels", "Email", c => c.String());
            AddPrimaryKey("dbo.UserViewModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserViewModels");
            AlterColumn("dbo.UserViewModels", "Email", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.UserViewModels", "ID");
            AddPrimaryKey("dbo.UserViewModels", "Email");
        }
    }
}
