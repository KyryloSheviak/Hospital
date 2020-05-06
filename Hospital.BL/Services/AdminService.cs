using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.DAL.Interface;
using System.Collections.Generic;
using Hospital.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;

namespace Hospital.BL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var users = _unitOfWork.Repository<ApplicationUser>().Get();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<IEnumerable<UserDTO>> GetUsersByRole(string role)
        {
            var users = await _userManager.GetUsersInRoleAsync(role);
            var usersDto = _mapper.Map<IEnumerable<UserDTO>>(users);

            return usersDto;
        }

        public async Task<IdentityResult> DeleteUserById(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            var result = await _userManager.DeleteAsync(user);

            return result;
        }
    }
}