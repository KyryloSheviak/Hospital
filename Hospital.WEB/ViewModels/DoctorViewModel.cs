using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.ViewModels
{
    public class DoctorViewModel
    {
        public UserViewModel UserViewModel { get; set;}

        [Required]
        [DisplayName("Степень")]
        //[Required(ErrorMessage = "The Home page field is required")]
        public string Degree { get; set; }

        [Required]
        [Range(0, 1000.00)]
        [DisplayName("Цена приема")]
        public int Cost { get; set; }

        [StringLength(100)]
        [DisplayName("О себе")]
        public string About { get; set; }

        [Required]
        [DisplayName("Номер кабинета")]
        public int RoomNumber { get; set; }

        [Required]
        [Range(0, 60)]
        [DisplayName("Опыт работы")]
        public int Expirience { get; set; }

        [Required]
        [DisplayName("Специальность")]
        public string Specialty { get; set; }
    }
}
