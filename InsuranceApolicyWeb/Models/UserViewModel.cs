using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsuranceApolicyWeb.Models
{
    public enum DocumentType { BI, CC,
        [Display(Name = "Passaport")]
        PASSPORT }

    public enum ClientType {
        [Display(Name = "Particulares")]
        P,
        [Display(Name = "Empresas")]
        E }

    public enum RoleType {
        [Display(Name = "Sr.")]
        Mr,
        [Display(Name = "Sra.")]
        Ms,
        [Display(Name = "Sra.")]
        Mrs }

    public class UserViewModel
    {
        public int ID { get; set; }

        public string NIF { get; set; }

        [Display(Name = "Título")]
        public RoleType Role { get; set; }

        [Display(Name = "Tipo Cliente")]
        public ClientType ClientType { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Tipo Documento")]
        public DocumentType DocumentType { get; set; }

        [Display(Name = "Nº Documento")]
        public string DocumentNumber { get; set; }

        [Display(Name = "Rua")]
        public string AddressStreet { get; set; }

        [Display(Name = "Nº")]
        public int AddressNumber { get; set; }

        [Display(Name = "Bairro")]
        public string AddressNeighborhood { get; set; }

        [Display(Name = "Município")]
        public string AddressTown { get; set; }

        [Display(Name = "Cidade")]
        public string AddressCity { get; set; }

        [Display(Name = "Província")]
        public string AddressDistrict { get; set; }

        [Display(Name = "Telefone")]
        public string PhoneNumberHome { get; set; }

        [Display(Name = "Telemóvel")]
        public string PhoneNumberPersonal { get; set; }

        public string Email { get; set; }

        public string Photo { get; set; }

        public string ClientNumber { get; set; }
    }
}