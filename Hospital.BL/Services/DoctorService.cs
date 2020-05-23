using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.DAL.Entities;
using Hospital.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.BL.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void AddWordDays(IEnumerable<DoctorWorkDaysDTO> doctorWorkDays)
        {
            // TODO: заменить сущность
            var days = _mapper.Map<IEnumerable<DoctorWorkDay>>(doctorWorkDays);

        }
    }
}
