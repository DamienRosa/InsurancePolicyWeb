using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.Models
{

    public enum PolicyType {
        [Display(Name = "Seguro Viagem")]
        Travel,
        [Display(Name = "Seguro Automóvel")]
        Car
    }

    public class PolicyModel
    {
        public int ID { get; set; }

        public PolicyType PolicyType { get; set; }

        public int PolicyNumber { get; set; }

        public double TotalAnnualReward { get; set; }

        public string State { get; set; }

        public DateTime CriationDate { get; set; }

        public string BusinessUnity { get; set; }

        public string Product { get; set; }

        public string ClientNumber { get; set; }

        public string Currency { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string MediatingAgent { get; set; }

        public string Branch { get; set; }

        public string PaymentMethod { get; set; }

        public string Fractionation { get; set; }

        public string LocationWarranty { get; set; }

        public int UserViewModelID { get; set; }

        public virtual UserViewModel User { get; set; }
    }
}