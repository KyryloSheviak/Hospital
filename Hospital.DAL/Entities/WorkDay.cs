using System;

namespace Hospital.DAL.Entities
{
    public class WorkDay : BaseEntities
    {
        public DateTime ReceptionTime { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int? ReceptionStatusId { get; set; }
        public virtual ReceptionStatus ReceptionStatus { get; set; }
    }
}
