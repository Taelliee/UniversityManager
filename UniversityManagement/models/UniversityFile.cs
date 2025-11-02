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
        private static string gradesFilePath = "university_grades.txt";

        private static StreamWriter writer;
        private static StreamReader reader;
        public static void SaveUniPeopleToFile()
        {
            using (writer = new StreamWriter(peopleFilePath))
            {
                foreach (Person person in University.GetInstance().GetUniPeople())
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

            using (reader = new StreamReader(peopleFilePath))
            {
                string? line;
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
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    University.GetInstance().AddUniversitySubject(new UniversitySubject(line));
                }
            }
        }

        public static void SaveGradesToFile() {
            using (writer = new StreamWriter(gradesFilePath))
            {
                List<Student> students = University.GetInstance().GetUniPeople().OfType<Student>().ToList();
                foreach (Student student in students) {
                    foreach (Mark mark in student.GetMarks())
                    {
                        writer.WriteLine($"{student.FIV}|{mark.UniversitySubject.SubjectName}|{mark.MarkType}");
                    }
                }
            }
        }

        public static void LoadGradesFromFile()
        {
            if (!File.Exists(gradesFilePath))
                return;

            using (reader = new StreamReader(gradesFilePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] attributes = line.Split('|');
                    if (attributes.Length < 3)
                        continue;

                    string FIV = attributes[0];
                    string subjectName = attributes[1];

                    UniversitySubject? subject = University.GetInstance()
                        .GetUniversitySubjects()
                        .FirstOrDefault(s => s.SubjectName == subjectName);

                    if (subject == null)
                    {
                        subject = new UniversitySubject(subjectName);
                        University.GetInstance().AddUniversitySubject(subject);
                    }

                    if (!Enum.TryParse(attributes[2], out MarkType markType))
                        continue;

                    Mark mark = new Mark(subject, markType);

                    Student? student = University.GetInstance().GetUniPeople()
                        .OfType<Student>()
                        .FirstOrDefault(s => s.FIV.ToString() == FIV);

                    if (student != null)
                    {
                        student.AddMark(mark);
                    }
                }
            }
        }

    }
}