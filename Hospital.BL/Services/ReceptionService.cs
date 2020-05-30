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
    public class ReceptionService : IReceptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReceptionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool CreateVisit(ReceptionWorkDayDTO receptionWorkDayDTO)
        {
            var day = _unitOfWork.Repository<WorkDay>()
                .Get(x => x.DoctorId == receptionWorkDayDTO.DoctorId && x.ReceptionTime == receptionWorkDayDTO.ReceptionTime && x.PatientId == null)
                .FirstOrDefault();
            var patientId = _unitOfWork.Repository<Patient>().Get(x => x.ApplicationUserId == receptionWorkDayDTO.PatientId).FirstOrDefault();

            if (day != null && patientId != null)
            {
                day.PatientId = patientId.Id;
                _unitOfWork.Repository<WorkDay>().Update(day);
                _unitOfWork.Save();
                return true;
            }
            else return false;
        }

        public IEnumerable<ReceptionDoctorDTO> GetReceptionDoctors()
        {
            var doctors = _unitOfWork.Repository<Doctor>().Get(null, null, "ApplicationUser");
            var receptionDoctors = _mapper.Map<IEnumerable<ReceptionDoctorDTO>>(doctors);

            return receptionDoctors;
        }

        public IEnumerable<string> GetReceptionDoctorWorkDays(int doctorId)
        {
            var days = _unitOfWork
                .Repository<WorkDay>()
                .Get(x => x.DoctorId == doctorId && x.PatientId == null && x.ReceptionTime >= DateTime.Now,
                     x => x.OrderBy(x => x.ReceptionTime))
                .Select(x => x.ReceptionTime.ToShortDateString())
                .Distinct()
                .Take(5)
                .ToList();

            return days;
        }

        public IEnumerable<string> GetReceptionDoctorWorkTimes(string day)
        {
            var dateTime = Convert.ToDateTime(day);
            var dateTimeNext = dateTime.AddDays(1);

            var times = _unitOfWork.Repository<WorkDay>()
                .Get(x => x.ReceptionTime >= dateTime && x.ReceptionTime < dateTimeNext && x.PatientId == null)
                .Select(x => x.ReceptionTime.ToShortTimeString())
                .ToList();

            return times;
        }
    }
}
