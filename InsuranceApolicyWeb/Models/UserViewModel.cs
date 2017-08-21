using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.Models
{
    public enum DocumentType { BI, CC, PASSPORT }

    public enum ClientType { P, E }

    public enum RoleType { Mr, Ms, Mrs }

    public class UserViewModel
    {
        [Required]
        [Key]
        public string NIF { get; set; }

        public RoleType Role { get; set; }

        public ClientType ClientType { get; set; }

        public string Name { get; set; }

        public DocumentType DocumentType { get; set; }

        public string DocumentNumber { get; set; }

        public string AddressStreet { get; set; }

        public int AddressNumber { get; set; }

        public string AddressNeighborhood { get; set; }

        public string AddressTown { get; set; }

        public string AddressCity { get; set; }

        public string AddressDistrict { get; set; }

        public string PhoneNumberHome { get; set; }

        public string PhoneNumberPersonal { get; set; }

        public string Email { get; set; }

        public string Photo { get; set; }

        public string ClientNumber { get; set; }
    }
}