using System;
using System.Collections.Generic;

namespace Hospital.BL.DTO
{
    public class DoctorWorkDaysDTO : BaseDTO
    {
        public List<DateTime> DateOfWork { get; set; }
    }
}