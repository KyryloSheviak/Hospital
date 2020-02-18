using System;
using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class Doctor : BaseEntities
    {
        public string Degree { get; set; }
        public int Cost { get; set; }
        public string About { get; set; }
        public int RoomNumber { get; set; }
        public int Expirience { get; set; }
        public string Specialty { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<DoctorWorkDay> WorkDays { get; set; }
    }
}
