using System;

namespace Hospital.DAL.Entities
{
    public class DoctorWorkDay
    {
        public int DoctorId { get; set; }
        public int WorkdDayId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual WorkDay WorkDay { get; set; }

    }
}
