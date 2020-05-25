using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.DAL.Entities;
using Hospital.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.BL.Services
{
    public class DoctorService : IDoctorService
    {
        private const int TimePart = 19;
        private int[] FreeTimes = new[] { 8, 9 };

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void AddWordDays(IEnumerable<DateTime> doctorWorkDays, int userId)
        {
            var doctor = _unitOfWork.Repository<Doctor>().Get(x => x.ApplicationUserId == userId).FirstOrDefault();
            if (doctor == null) return;
            
            foreach (var item in doctorWorkDays)
            {
                var nTime = item.AddHours(7).AddMinutes(30);
                for (int i = 0; i < TimePart; i++)
                {
                    nTime = nTime.AddMinutes(30);
                    if (FreeTimes.Any(x => x == i)) continue; 
                    _unitOfWork.Repository<WorkDay>().Insert(new WorkDay { DoctorId = doctor.Id, ReceptionTime = nTime });
                    _unitOfWork.Save();
                }
            }
        }

        public AboutUserDTO GetUserInfoById(int id)
        {
            var user = _unitOfWork.Repository<ApplicationUser>().Get(id);
            var userDto = _mapper.Map<AboutUserDTO>(user);
            return userDto;
        }
    }
}