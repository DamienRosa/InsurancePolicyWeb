using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApolicyWeb.Models
{
    public class PolicyRewardModel
    {
        [Key, ForeignKey("PolicyModel")]
        public int PolicyModelID { get; set; }
        
        [Display(Name = "Prémio Simples")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SimpleReward { get; set; }

        [Display(Name = "Prémio Total")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalReward { get; set; }
        
        public virtual PolicyModel PolicyModel { get; set; }
    }
}