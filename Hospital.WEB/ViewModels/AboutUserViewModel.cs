using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.ViewModels
{
    public class AboutUserViewModel
    {
        [DisplayName("ФИО")]
        public string Fio { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }

        [DisplayName("Пол")]
        public char Sex { get; set; }

        [DisplayName("Дата рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime BirthDate { get; set; }
    }
}