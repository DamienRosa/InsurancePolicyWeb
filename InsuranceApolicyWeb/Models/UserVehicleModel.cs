using System.ComponentModel.DataAnnotations;

namespace InsuranceApolicyWeb.Models
{
    public class UserVehicleModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Matrícula")]
        public string LicensePlate { get; set; }

        [Display(Name = "Marca")]
        public string Brand { get; set; }

        [Display(Name = "Modelo")]
        public string Model { get; set; }

        [Display(Name = "Peso bruto")]
        public double GrossWeight { get; set; }

        [Display(Name = "Cilindrada")]
        public double Capacity { get; set; }

        [Display(Name = "Nº Lugares")]
        public int NumberOfSeats { get; set; }

        public int PolicyModelID { get; set; }

        public virtual PolicyModel PolicyModel { get; set; }

    }
}