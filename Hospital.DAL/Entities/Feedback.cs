using System;

namespace Hospital.DAL.Entities
{
    public class Feedback : BaseEntities
    {
        public bool IsPublish { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string FeedbackMessage { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
