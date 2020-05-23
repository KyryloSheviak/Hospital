using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class Patient : BaseEntities
    {
        public string Address { get; set; }
        public string BloodType { get; set; }
        public string Allergy { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<WorkDay> Receptions { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
