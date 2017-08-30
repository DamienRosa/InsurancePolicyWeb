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

        [Display(Name = "Nº Apólice")]
        public int PolicyNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Prémio Total Anual")]
        public double TotalAnnualReward { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CriationDate { get; set; }

        [Display(Name = "Unidade de negócio")]
        public string BusinessUnity { get; set; }

        [Display(Name = "Produto")]
        public string Product { get; set; }

        public string ClientNumber { get; set; }

        [Display(Name = "Moeda Contratada")]
        public string Currency { get; set; }

        [Display(Name = "Período de Validade")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Agente Mediador")]
        public string MediatingAgent { get; set; }

        [Display(Name = "Ramo")]
        public string Branch { get; set; }

        [Display(Name = "Forma de Pagamento")]
        public string PaymentMethod { get; set; }

        [Display(Name = "Fraccionamento")]
        public string Fractionation { get; set; }

        [Display(Name = "Local de Garantia de Riscos")]
        public string LocationWarranty { get; set; }

        public int UserViewModelID { get; set; }

        public virtual UserViewModel User { get; set; }
        
        public virtual PolicyRewardModel PolicyRewardModel { get; set; }

        public virtual ICollection<UserVehicleModel> UserVehicles { get; set; }

        public virtual ICollection<UserDocumentModel> UserDocuments { get; set; }

    }
}