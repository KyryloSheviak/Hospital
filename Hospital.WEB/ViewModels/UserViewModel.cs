using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [DisplayName("ФИО *")]
        [Required(ErrorMessage = "Вы не указали ФИО")]
        public string Fio { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("Email *")]
        [Required(ErrorMessage = "Вы не указали Email")]
        public string Email { get; set; }

        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DisplayName("Пароль *")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Поле пароль обязательное!")]
        public string Password { get; set; }

        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DisplayName("Повторите пароль *")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Повторите пароль!")]
        public string ConfirmPassword { get; set; }

        [Phone]
        [Display(Name = "Номер телефона *")]
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Пол")]
        [Required(ErrorMessage = "Не указан пол")]
        public Sex Sex { get; set; }
    }
}