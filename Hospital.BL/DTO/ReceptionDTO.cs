using System;

namespace Hospital.BL.DTO
{
    public class ReceptionDTO : BaseDTO
    {
        public string ReceptionDateTime { get; set; }
        public int RoomNumber { get; set; }
        public string ReceptionDuration { get; set; }

        public string Doctor { get; set; }
        public ReceptionStatus ReceptionStatus { get; set; }
    }

    public enum ReceptionStatus
    {
        VISITED,
        NOT_VISITED,
        CANCELED
    }
}
