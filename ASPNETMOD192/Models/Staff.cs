using System.ComponentModel.DataAnnotations;

namespace ASPNETMOD192.Models
{
    public class Staff
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string StaffNumber {  get; set; }
        public DateOnly Birthday { get; set; }
        [Required]
        [StringLength(100)]
        public string Addresss { get; set; }
        [Required]
        public string VatNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DeactivationDate { get; set; }
        public string? CellPhoneNumber { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
