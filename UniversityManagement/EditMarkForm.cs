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
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();

            studentComboBox.DataSource = University.GetInstance().GetUniPeople().OfType<Student>().ToList();
            studentComboBox.DisplayMember = "DisplayInfo";

            subjectComboBox.DataSource = University.GetInstance().GetUniversitySubjects().ToList();
            subjectComboBox.DisplayMember = "SubjectName";

            changedMarkComboBox.DataSource = Enum.GetValues(typeof(MarkType))
                .Cast<MarkType>()
                .OrderByDescending(mt => (int)mt)
                .ToList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.ShowDialog();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeMarkComboBox();
        }


        private void editMarkButton_Click(object sender, EventArgs e)
        {
            Mark oldMark = (Mark)markComboBox.SelectedItem;
            oldMark.MarkType = (MarkType)changedMarkComboBox.SelectedItem;

            InitializeMarkComboBox();
        }

        private void InitializeMarkComboBox()
        {
            Student student = (Student)studentComboBox.SelectedItem;
            UniversitySubject subject = (UniversitySubject)subjectComboBox.SelectedItem;

            List<Mark> marksForSubject = student.GetMarks()
                                         .Where(m => m.UniversitySubject == subject)
                                         .OrderByDescending(m => (int)m.MarkType)
                                         .ToList();

            markComboBox.DataSource = marksForSubject;
            markComboBox.DisplayMember = nameof(Mark.MarkType);
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeMarkComboBox();
        }
    }
}
