using Microsoft.AspNetCore.Identity;

namespace Hospital.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Fio { get; set; }
        
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
