using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityManagement.models
{
    public class UniversityFile
    {
        private static string peopleFilePath = "university_people.txt";
        private static string subjectsFilePath = "university_subjects.txt";
        public static void SaveUniPeopleToFile()
        {
            using (StreamWriter writer = new StreamWriter(peopleFilePath))
            {
                foreach (var person in University.GetInstance().GetUniPeople())
                {
                    if (person is Student student)
                    {
                        writer.WriteLine($"Student|{student.Name}|{student.Email}|{student.Phone}|{student.FIV}");
                    }
                    else if (person is Teacher teacher)
                    {
                        writer.WriteLine($"Teacher|{teacher.Name}|{teacher.Email}|{teacher.Phone}|{teacher.EGN}");
                    }
                }
            }
        }

        public static void LoadUniPeopleFromFile()
        {
            if (!File.Exists(peopleFilePath))
                return;

            using (StreamReader reader = new StreamReader(peopleFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] attributes = line.Split('|');
                    if (attributes.Length < 5) 
                        continue;

                    string type = attributes[0];
                    string name = attributes[1];
                    string email = attributes[2];
                    string phone = attributes[3];

                    if (type == "Student")
                    {
                        int fiv = int.Parse(attributes[4]);
                        University.GetInstance().AddUniPeople(new Student(name, email, phone, fiv));
                    }
                    else if (type == "Teacher")
                    {
                        string egn = attributes[4];
                        University.GetInstance().AddUniPeople(new Teacher(name, email, phone, egn));
                    }
                }
            }
        }

        public static void LoadUniversitySubjectsFromFile()
        {
            if (!File.Exists(subjectsFilePath))
                return;

            using (StreamReader reader = new StreamReader(subjectsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    University.GetInstance().AddUniversitySubjects(new UniversitySubject(line));
                }
            }
        }
    }
}