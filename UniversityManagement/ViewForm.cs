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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();

            uniPeopleTable.AutoScroll = true;
            uniPeopleTable.AutoSize = true;
            uniPeopleTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            LoadPeopleTable();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.ShowDialog();
        }

        private void LoadPeopleTable()
        {
            List<Person> people = University.GetInstance().GetUniPeople();

            int row = 1;

            foreach (Person person in people)
            {
                uniPeopleTable.RowCount++;

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = row.ToString(),
                    AutoSize = true
                }, 0, row);

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = person.Name,
                    AutoSize = true
                }, 1, row);

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = person.Email,
                    AutoSize = true
                }, 2, row);

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = person.Phone,
                    AutoSize = true
                }, 3, row);

                string fiv = "", egn = "";
                if (person is Student student)
                    fiv = student.FIV.ToString();
                else if (person is Teacher teacher)
                    egn = teacher.EGN;

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = fiv,
                    AutoSize = true
                }, 4, row);

                uniPeopleTable.Controls.Add(new Label()
                {
                    Text = egn,
                    AutoSize = true
                }, 5, row);

                row++;
            }
        }

        private void LoadMarksTable()
        {
            List<Student> students = University.GetInstance().GetUniPeople().OfType<Student>().ToList();

            int row = 1;

            foreach (Student student in students)
            {
                foreach (Mark mark in student.GetMarks().OrderBy(s => s.UniversitySubject.SubjectName))
                {
                    marksTable.RowCount++;

                    marksTable.Controls.Add(new Label()
                    {
                        Text = row.ToString(),
                        AutoSize = true
                    }, 0, row);

                    marksTable.Controls.Add(new Label()
                    {
                        Text = student.Name,
                        AutoSize = true
                    }, 1, row);

                    marksTable.Controls.Add(new Label()
                    {
                        Text = mark.UniversitySubject.SubjectName.ToString(),
                        AutoSize = true
                    }, 2, row);

                    marksTable.Controls.Add(new Label()
                    {
                        Text = $"{(int)mark.MarkType} - {mark.MarkType}",
                        AutoSize = true
                    }, 3, row);

                    row++;
                }
            }
        }

        private void ClearTableLayoutExceptHeader(TableLayoutPanel table)
        {
            List<Control> controlsToRemove = table.Controls
                .Cast<Control>()
                .Where(c => table.GetRow(c) != 0) // keep row 0 (the headers)
                .ToList();

            foreach (Control control in controlsToRemove)
                table.Controls.Remove(control);

            table.RowCount = 1;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTableLayoutExceptHeader(uniPeopleTable);
            uniPeopleTable.Visible = true;
            marksTable.Visible = false;
            LoadPeopleTable();
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTableLayoutExceptHeader(marksTable);
            uniPeopleTable.Visible = false;
            marksTable.Visible = true;
            LoadMarksTable();
        }

        private void averageGradePerSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm(SelectOption.AvgSubjectGrade);
            selectForm.Show();
        }

        private void numberOfMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm(SelectOption.CountMarksPerMarkType);
            selectForm.Show();
        }

        private void averageGradeForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm(SelectOption.AvgStudentGrade);
            selectForm.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm(SelectOption.SearchStudent);
            selectForm.Show();
        }
    }
}
