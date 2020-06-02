using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.ViewModels
{
    public class DoctorViewModel
    {
        public UserViewModel UserViewModel { get; set;}

        [DisplayName("Степень *")]
        [Required(ErrorMessage = "Вы не указали степень доктора")]
        public string Degree { get; set; }
        
        [Range(0, 1000.00)]
        [DisplayName("Цена приема *")]
        [Required(ErrorMessage = "Вы не указали цену приема")]
        public int Cost { get; set; }

        [StringLength(100)]
        [DisplayName("О себе")]
        public string About { get; set; }

        [DisplayName("Номер кабинета *")]
        [Required(ErrorMessage = "Вы не указали номер телефона")]
        public int RoomNumber { get; set; }

        [Range(0, 60)]
        [DisplayName("Опыт работы *")]
        [Required(ErrorMessage = "Вы не указали опыт работы")]
        public int Expirience { get; set; }

        [DisplayName("Специальность *")]
        [Required(ErrorMessage = "Вы не указали специальность")]
        public string Specialty { get; set; }
    }
}
