using System;

namespace Hospital.DAL.Entities
{
    public class Review : BaseEntities
    {
        public bool IsPublish { get; set; }
        public DateTime DateOfReview { get; set; }
        public string ReviewText { get; set; }
        public int ApplicatioUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
