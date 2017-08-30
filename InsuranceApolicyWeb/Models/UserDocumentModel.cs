using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApolicyWeb.Models
{
    public class UserDocumentModel
    {
        [Key]
        public int ID { get; set; }

        public string DocumentType { get; set; }

        public DateTime CreationDate { get; set; }

        public string Document { get; set; }
        
        public int PolicyModelID { get; set; }

        public virtual PolicyModel PolicyModel { get; set; }
    }
}