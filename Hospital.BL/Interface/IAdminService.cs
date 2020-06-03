using Hospital.BL.DTO;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.BL.Interface
{
    public interface IAdminService
    {
        IEnumerable<UserDTO> GetUsers();
        Task<IEnumerable<UserDTO>> GetUsersByRole(string role);
        Task<IdentityResult> DeleteUserById(int id);
        IEnumerable<SpecialtyDTO> GetSpecialties();
    }
}
