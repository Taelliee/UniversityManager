using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public class Student : Person
    {
        private List<Mark> marks;

        public Student(string name, string email, string phone, int fiv) 
            : base(name, email, phone)
        {
            this.FIV = fiv;
            marks = new List<Mark>();
        }

        public int FIV {  get; set; }

        public void AddMark(Mark mark)
        { 
            marks.Add(mark); 
        }

        public void RemoveMark(Mark mark)
        {
            marks.Remove(mark);
        }

        public void ChangeMark(Mark oldMark, Mark newMark)
        {
            Mark? markToUpdate = marks.Find(m =>
                m.UniversitySubject == oldMark.UniversitySubject &&
                m.MarkType == oldMark.MarkType);

            if (markToUpdate != null)
            {
                markToUpdate.MarkType = newMark.MarkType;
            }
        }

        public List<Mark> GetMarks() 
        {
            return marks;
        }
    }
}
