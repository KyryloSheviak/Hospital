using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hospital.WEB.ViewModels
{
    public class DoctorAddWorkDays
    {
        [Required]
        [Display(Name = "Дата рабочего дня")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public List<DateTime> DateOfWork { get; set; }
    }
}