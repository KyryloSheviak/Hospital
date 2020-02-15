using Hospital.BL.DTO;
using System.Collections.Generic;

namespace Hospital.BL.Interface
{
    public interface IAdminService
    {
        IEnumerable<ApplicationUserDTO> GetUsers();
    }
}
