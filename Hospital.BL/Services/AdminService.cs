using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.DAL.Interface;
using System.Collections.Generic;
using Hospital.DAL.Entities;

namespace Hospital.BL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AdminService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<ApplicationUserDTO> GetUsers()
        {
            var users = _unitOfWork.Repository<ApplicationUser>().Get();
            return _mapper.Map<IEnumerable<ApplicationUserDTO>>(users);
        }
    }
}
