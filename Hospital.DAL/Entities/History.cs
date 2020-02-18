using System;
using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class History : BaseEntities
    {
        public string Diagnosis { get; set; }
        public string Recipe { get; set; }
        public string DoctorsComment { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Analysis> Analyses { get; set; }
    }
}
