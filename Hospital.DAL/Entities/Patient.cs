using System;
using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class Patient : BaseEntities
    {
        public string Address { get; set; }
        public string BloodType { get; set; }
        public string Allergy { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
