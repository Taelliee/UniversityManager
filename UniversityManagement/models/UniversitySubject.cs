using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public class UniversitySubject
    {
        public UniversitySubject(string subjectName)
        {
            SubjectName = subjectName;
        }

        public string SubjectName { get; set; }
        //public Teacher Teacher { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is UniversitySubject other)
            {
                return SubjectName == other.SubjectName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return SubjectName.GetHashCode();
        }
    }
}
