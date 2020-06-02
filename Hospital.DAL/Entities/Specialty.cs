using System.Collections.Generic;

namespace Hospital.DAL.Entities
{
    public class Specialty : BaseEntities
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
