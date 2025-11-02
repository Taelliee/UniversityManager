using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public class University
    {
        private List<Person> uniPeople;
        private List<UniversitySubject> universitySubjects;
        private static University _instance;

        private University()
        {
            uniPeople = new List<Person>();
            universitySubjects = new List<UniversitySubject>();
        }

        public static University GetInstance()
        {
            if (_instance == null)
            {
                _instance = new University();
            }
            return _instance;
        }

        public void AddUniPeople(Person person) 
        { 
            uniPeople.Add(person);
        }

        public List<Person> GetUniPeople()
        { 
            return uniPeople;
        }

        public void AddUniversitySubject(UniversitySubject schoolSubject) 
        { 
            universitySubjects.Add(schoolSubject);
        }

        public List<UniversitySubject> GetUniversitySubjects()
        { 
            return universitySubjects; 
        }
    }
}
