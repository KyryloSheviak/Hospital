using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Fio { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public char Sex { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}