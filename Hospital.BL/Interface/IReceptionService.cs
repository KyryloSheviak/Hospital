using Hospital.BL.DTO;
using System.Collections.Generic;

namespace Hospital.BL.Interface
{
    public interface IReceptionService
    {
        IEnumerable<ReceptionDoctorDTO> GetReceptionDoctors();
        IEnumerable<string> GetReceptionDoctorWorkDays(int doctorId);
        IEnumerable<string> GetReceptionDoctorWorkTimes(string day);
        bool CreateVisit(ReceptionWorkDayDTO receptionWorkDayDTO);
    }
}
