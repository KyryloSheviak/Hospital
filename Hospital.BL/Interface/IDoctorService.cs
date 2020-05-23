using Hospital.BL.DTO;
using System.Collections.Generic;

namespace Hospital.BL.Interface
{
    public interface IDoctorService
    {
        void AddWordDays(IEnumerable<DoctorWorkDaysDTO> doctorWorkDays);
    }
}