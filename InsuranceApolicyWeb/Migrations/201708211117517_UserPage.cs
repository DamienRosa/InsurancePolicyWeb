namespace InsuranceApolicyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserViewModels",
                c => new
                    {
                        NIF = c.String(nullable: false, maxLength: 128),
                        Role = c.Int(nullable: false),
                        ClientType = c.Int(nullable: false),
                        Name = c.String(),
                        DocumentType = c.Int(nullable: false),
                        DocumentNumber = c.String(),
                        AddressStreet = c.String(),
                        AddressNumber = c.Int(nullable: false),
                        AddressNeighborhood = c.String(),
                        AddressTown = c.String(),
                        AddressCity = c.String(),
                        AddressDistrict = c.String(),
                        PhoneNumberHome = c.String(),
                        PhoneNumberPersonal = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                        ClientNumber = c.String(),
                    })
                .PrimaryKey(t => t.NIF);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserViewModels");
        }
    }
}
