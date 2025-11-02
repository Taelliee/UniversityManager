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
    public partial class UpdateForm : Form
    {
        private List<Person> uniPeople = University.GetInstance().GetUniPeople().ToList();
        public UpdateForm()
        {
            InitializeComponent();

            studentsCheckBox.Checked = true;
            teachersCheckBox.Checked = true;
            LoadComboBox(uniPeople);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.ShowDialog();
        }

        private void updateFormButton_Click(object sender, EventArgs e)
        {
            Person? person = (Person)personComboBox.SelectedItem;

            if (person == null) return;

            person.Name = nameTextBox.Text;
            person.Email = emailTextBox.Text;
            person.Phone = phoneTextBox.Text;

            if (person is Student student)
            {
                //safe parsing
                if (int.TryParse(FIVTextBox.Text, out int fiv))
                    student.FIV = fiv;
            }
            else if (person is Teacher teacher)
            {
                teacher.EGN = EGNTextBox.Text;
            }

            MessageBox.Show($"{person.Name}'s info has been updated!", "Update Successful");
        }

        private void namesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personComboBox.SelectedItem is Person selectedPerson)
            {
                nameTextBox.Text = selectedPerson.Name;
                emailTextBox.Text = selectedPerson.Email;
                phoneTextBox.Text = selectedPerson.Phone;
                emailTextBox.Enabled = true;
                phoneTextBox.Enabled = true;

                FIVTextBox.Text = "";
                EGNTextBox.Text = "";

                if (selectedPerson is Student student)
                {
                    FIVTextBox.Enabled = true;
                    EGNTextBox.Enabled = false;
                    FIVTextBox.Text = student.FIV.ToString();
                }
                else if (selectedPerson is Teacher teacher)
                {
                    FIVTextBox.Enabled = false;
                    EGNTextBox.Enabled = true;
                    EGNTextBox.Text = teacher.EGN;
                }
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateEmailInput(e);
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumberInput(e);
        }

        private void FIVTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumberInput(e);
        }

        private void EGNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumberInput(e);
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateLength(e, emailTextBox, 5, 30);
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateLength(e, phoneTextBox, 10, 10);
        }

        private void FIVTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateLength(e, FIVTextBox, 8, 8);
        }

        private void EGNTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateLength(e, EGNTextBox, 10, 10);
        }

        private void LoadComboBox(IEnumerable<Person> people)
        {
            personComboBox.DataSource = people.ToList();
            personComboBox.DisplayMember = "DisplayInfo";
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            uniPeople = University.GetInstance().GetUniPeople();
            LoadComboBox(uniPeople);
        }

        private void FilterPeople()
        {
            var filtered = uniPeople.AsEnumerable();

            if (studentsCheckBox.Checked && !teachersCheckBox.Checked)
                filtered = filtered.OfType<Student>();
            else if (!studentsCheckBox.Checked && teachersCheckBox.Checked)
                filtered = filtered.OfType<Teacher>();

            LoadComboBox(filtered);
        }

        private void studentsCheckBox_CheckedChanged(object sender, EventArgs e) => FilterPeople();

        private void teachersCheckBox_CheckedChanged(object sender, EventArgs e) => FilterPeople();
    }
}
