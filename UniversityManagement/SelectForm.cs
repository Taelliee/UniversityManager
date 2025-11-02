using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagement.models;

namespace UniversityManagement
{
    public partial class SelectForm : Form
    {
        private SelectOption option;
        private List<Student> students = University.GetInstance().GetUniPeople().OfType<Student>().ToList();

        public SelectForm()
        {
            InitializeComponent();
        }

        public SelectForm(SelectOption selectOption)
        {
            option = selectOption;
            InitializeComponent();
            switch (selectOption)
            {
                case SelectOption.AvgSubjectGrade:
                    selectComboBox.DataSource = students;
                    selectComboBox.DisplayMember = "Name";
                    selectFormLabel.Text = "Student:";
                    selectComboBox2.Visible = true;
                    selectComboBox2.DataSource = University.GetInstance().GetUniversitySubjects();
                    selectComboBox2.DisplayMember = "SubjectName";
                    selectFormLabel2.Text = "Subject:";
                    break;
                case SelectOption.AvgStudentGrade:
                    selectComboBox.DataSource = students;
                    selectComboBox.DisplayMember = "Name";
                    selectFormLabel.Text = "Student:";
                    break;
                case SelectOption.CountMarksPerMarkType:
                    selectComboBox.DataSource = students;
                    selectComboBox.DisplayMember = "Name";
                    selectFormLabel.Text = "Student:";
                    selectComboBox2.Visible = true;
                    selectComboBox2.DataSource = Enum.GetValues(typeof(MarkType))
                        .Cast<MarkType>()
                        .OrderByDescending(mt => (int)mt)
                        .ToList();
                    selectFormLabel2.Text = "Grade:";
                    break;
                case SelectOption.SearchStudent:
                    selectComboBox.DataSource = students;
                    selectComboBox.DisplayMember = "DisplayInfo";
                    selectFormLabel.Text = "Student:";
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case SelectOption.AvgSubjectGrade:
                    findAvgGradeForStudentPerSubject();
                    break;
                case SelectOption.AvgStudentGrade:
                    findAvgGradeForStudent();
                    break;
                case SelectOption.CountMarksPerMarkType:
                    countMarksPerMarkType();
                    break;
                case SelectOption.SearchStudent:
                    searchStudent();
                    break;
            }
        }

        private void findAvgGradeForStudentPerSubject()
        {
            Student student = (Student)selectComboBox.SelectedItem;
            UniversitySubject subject = (UniversitySubject)selectComboBox2.SelectedItem;
            double avgGrade = student.GetAverageGradeForSubject(subject);
            MessageBox.Show($"Average grade for {student.Name} in {subject.SubjectName} is {avgGrade}");
        }

        private void findAvgGradeForStudent()
        {
            Student student = (Student)selectComboBox.SelectedItem;
            double avgGrade = student.GetAverageGrade();
            MessageBox.Show($"Average grade for {student.Name} is {avgGrade}");
        }

        private void countMarksPerMarkType()
        {
            Student student = (Student)selectComboBox.SelectedItem;
            MarkType mark = (MarkType)selectComboBox2.SelectedItem;
            int markCount = student.GetMarks().Where(m => m.MarkType == mark).Count();
            MessageBox.Show($"Count of {mark} grade for {student.Name} is {markCount}");
        }

        private void searchStudent()
        {
            Student student = (Student)selectComboBox.SelectedItem;
            MessageBox.Show($"Student {student.Name} has: \n FIV {student.FIV} \n Email {student.Email} \n Phone {student.Phone}");
        }
    }
}
