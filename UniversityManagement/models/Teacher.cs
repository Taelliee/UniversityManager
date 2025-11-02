using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public class Teacher : Person
    {
        public Teacher(string name, string email, string phone, string egn) 
            : base(name, email, phone)
        {
            this.EGN = egn;
        }

        public string EGN { get; set; }
    }
}
