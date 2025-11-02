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
    public partial class AddMarkForm : Form
    {
        public AddMarkForm()
        {
            InitializeComponent();

            studentComboBox.DataSource = University.GetInstance().GetUniPeople().OfType<Student>().ToList();
            studentComboBox.DisplayMember = "DisplayInfo";

            subjectComboBox.DataSource = University.GetInstance().GetUniversitySubjects().ToList();
            subjectComboBox.DisplayMember = "SubjectName";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.ShowDialog();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            markComboBox.Enabled = true;
            markComboBox.DataSource = Enum.GetValues(typeof(MarkType))
                .Cast<MarkType>()
                .OrderByDescending(mt => (int)mt)
                .ToList();
        }

        private void addMarkButton_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark((UniversitySubject)subjectComboBox.SelectedItem, (MarkType)markComboBox.SelectedItem);
            Student selectedStudent = (Student)studentComboBox.SelectedItem;
            selectedStudent.AddMark(mark);
        }

        private void AddMarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UniversityFile.SaveGradesToFile();
        }
    }
}
