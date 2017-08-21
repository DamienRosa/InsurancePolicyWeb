using InsuranceApolicyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.DAL
{
    public class InsurancePolicyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InsurancePolicyContext>
    {
        protected override void Seed(InsurancePolicyContext context)
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