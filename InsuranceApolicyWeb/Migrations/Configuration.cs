namespace InsuranceApolicyWeb.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InsuranceApolicyWeb.DAL.InsurancePolicyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InsuranceApolicyWeb.DAL.InsurancePolicyContext context)
        {
            var users = new List<UserViewModel>
            {
                new UserViewModel { NIF = "123149789", Role = RoleType.Mr, ClientType = ClientType.P, Name = "John Doe", DocumentType = DocumentType.CC, DocumentNumber = "15698850", AddressStreet = "Rua José Falcão", AddressNumber = 12, AddressTown = "Porto", AddressCity = "Porto", AddressDistrict = "-", AddressNeighborhood = "-", PhoneNumberHome = "+35191000000", PhoneNumberPersonal = "-", ClientNumber = "123456", Email = "damien.rosa@itsector.pt" }
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}
