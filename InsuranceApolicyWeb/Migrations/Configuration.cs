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

            var policies = new List<PolicyModel> {
                new PolicyModel { UserViewModelID = 1, PolicyNumber = 123456789, PolicyType = PolicyType.Travel, TotalAnnualReward = 1234567, State = "Activo", CriationDate = DateTime.Now , BusinessUnity = "Coqueiros" , Product = "Responsabilidade Civil", Currency = "Euro", ExpirationDate = DateTime.Now.AddMonths(12),
                MediatingAgent = "-", Branch = "Não vida", PaymentMethod = "Numerario", Fractionation = "Trimestral", LocationWarranty = "-"  },

                new PolicyModel { UserViewModelID = 1, PolicyNumber = 123456789, PolicyType = PolicyType.Travel, TotalAnnualReward = 1234567, State = "Activo", CriationDate = DateTime.Now , BusinessUnity = "Coqueiros" , Product = "Responsabilidade Civil", Currency = "Euro", ExpirationDate = DateTime.Now.AddMonths(12),
                MediatingAgent = "-", Branch = "Não vida", PaymentMethod = "Numerario", Fractionation = "Trimestral", LocationWarranty = "-"  },

                new PolicyModel { UserViewModelID = 1, PolicyNumber = 123456789, PolicyType = PolicyType.Travel, TotalAnnualReward = 1234567, State = "Activo", CriationDate = DateTime.Now , BusinessUnity = "Coqueiros" , Product = "Responsabilidade Civil", Currency = "Euro", ExpirationDate = DateTime.Now.AddMonths(12),
                MediatingAgent = "-", Branch = "Não vida", PaymentMethod = "Numerario", Fractionation = "Trimestral", LocationWarranty = "-"  },

                new PolicyModel { UserViewModelID = 1, PolicyNumber = 123456789, PolicyType = PolicyType.Travel, TotalAnnualReward = 1234567, State = "Activo", CriationDate = DateTime.Now , BusinessUnity = "Coqueiros" , Product = "Responsabilidade Civil", Currency = "Euro", ExpirationDate = DateTime.Now.AddMonths(12),
                MediatingAgent = "-", Branch = "Não vida", PaymentMethod = "Numerario", Fractionation = "Trimestral", LocationWarranty = "-"  }
            };
            policies.ForEach(p => context.Policies.Add(p));
            context.SaveChanges();

            var vehicles = new List<UserVehicleModel> {
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 1},
                new UserVehicleModel { Brand = "Toyoya1", Model = "Corola1", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 1},
                new UserVehicleModel { Brand = "Toyoya2", Model = "Corola", LicensePlate = "12-52-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 4, PolicyModelID = 1},
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola3", LicensePlate = "34-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 1},
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 2, PolicyModelID = 2},
                new UserVehicleModel { Brand = "Toyoya2", Model = "Corola", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 2},
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola", LicensePlate = "12-34-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 2, PolicyModelID = 3},
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola2", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 4},
                new UserVehicleModel { Brand = "Toyoya", Model = "Corola", LicensePlate = "12-78-QA", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 5, PolicyModelID = 2},
                new UserVehicleModel { Brand = "Toyoya1", Model = "Corola", LicensePlate = "12-51-WE", Capacity = 1600.0 ,  GrossWeight = 1500.0, NumberOfSeats = 2, PolicyModelID = 4},
            };
            vehicles.ForEach(p => context.Vehicles.Add(p));
            context.SaveChanges();

            var rewards = new List<PolicyRewardModel>
            {
                new PolicyRewardModel { SimpleReward = 12500.0, TotalReward = 123000.0, PolicyModelID = 1},
                new PolicyRewardModel { SimpleReward = 11500.0, TotalReward = 145000.0, PolicyModelID = 2},
                new PolicyRewardModel { SimpleReward = 14500.0, TotalReward = 178000.0, PolicyModelID = 3},
                new PolicyRewardModel { SimpleReward = 17500.0, TotalReward = 190000.0, PolicyModelID = 4}
            };
            rewards.ForEach(r => context.Rewards.Add(r));
            context.SaveChanges();
        }
    }
}
