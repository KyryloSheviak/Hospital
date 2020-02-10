namespace Hospital.DAL.Entities
{
    public class Patient : BaseEntities
    {
        public string Address { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
