using InsuranceApolicyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.DAL
{
    public class InsurancePolicyContext : DbContext
    {
        public InsurancePolicyContext() : base("InsurancePolicyContext") {
        }

        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<PolicyModel> Policies { get; set; }
    }
}