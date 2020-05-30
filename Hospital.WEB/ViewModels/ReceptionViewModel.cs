using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.Models
{
    public class ReceptionViewModel
    {
        [Required(ErrorMessage = "Вы не выбрали доктора")]
        [Display(Name = "Выберите доктора...")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Вы не выбрали день приема")]
        [Display(Name = "Выберите день приема...")]
        public DateTime WorkDay { get; set; }

        [Required(ErrorMessage = "Вы не выбрали время посещения")]
        [Display(Name = "Выберите время приема...")]
        public DateTime Time { get; set; }
    }
}