using InsuranceApolicyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.DAL
{
    public class InsurancePolicyContext : DbContext
    {
        public InsurancePolicyContext() : base("InsurancePolicyContext")
        {
        }

        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<PolicyModel> Policies { get; set; }
        public DbSet<UserVehicleModel> Vehicles { get; set; }
        public DbSet<PolicyRewardModel> Rewards { get; set; }
        public DbSet<UserDocumentModel> Documents { get; set; }
    }
    
}