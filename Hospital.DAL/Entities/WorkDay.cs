using System;
using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class WorkDay : BaseEntities
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public virtual ICollection<DoctorWorkDay> Doctors { get; set; }
    }
}
