using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public class Mark
    {
        public Mark(UniversitySubject universitySubject, MarkType markType)
        {
            UniversitySubject = universitySubject;
            MarkType = markType;
        }

        //public int MarkID { get; set; } //?
        //public int StudendID { get; set; } //?
        public UniversitySubject UniversitySubject { get; set; }
        public MarkType MarkType { get; set; }
    }
}
