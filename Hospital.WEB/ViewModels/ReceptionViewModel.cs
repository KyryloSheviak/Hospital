using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.Models
{
    public class ReceptionViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Doctor { get; set; }
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
    }
}
