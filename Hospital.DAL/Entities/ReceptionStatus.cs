namespace Hospital.DAL.Entities
{
    public class ReceptionStatus : BaseEntities
    {
        public string Status { get; set; }

        public int ReceptionId { get; set; }
        public virtual WorkDay Reception { get; set; }
    }
}
