using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class Doctor : BaseEntities
    {
        public string Degree { get; set; }
        public int Price { get; set; }
        public int RoomNumber { get; set; }
        public int Expirience { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<WorkDay> WorkDays { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}