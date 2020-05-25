using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.BL.DTO
{
    public class AboutUserDTO : BaseDTO
    {
        public string Fio { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
