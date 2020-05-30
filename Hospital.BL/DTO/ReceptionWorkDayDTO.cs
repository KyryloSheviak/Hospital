using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.BL.DTO
{
    public class ReceptionWorkDayDTO
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime ReceptionTime { get; set; }
    }
}
