namespace Hospital.DAL.Entities
{
    public class Doctor : BaseEntities
    {
        public string Degree { get; set; }
        public int Cost { get; set; }
        public string About { get; set; }
        public int RoomNumber { get; set; }
        public int Expirience { get; set; }
        public string Specialty { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
