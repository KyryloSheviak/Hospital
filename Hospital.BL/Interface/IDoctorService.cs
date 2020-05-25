using Hospital.BL.DTO;
using System;
using System.Collections.Generic;

namespace Hospital.BL.Interface
{
    public interface IDoctorService
    {
        void AddWordDays(IEnumerable<DateTime> doctorWorkDays, int userId);
        AboutUserDTO GetUserInfoById(int id);
    }
}