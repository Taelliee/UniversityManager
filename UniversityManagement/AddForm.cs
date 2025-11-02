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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.ShowDialog();
        }

        private void teacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FIVTextBox.Enabled = false;
            EGNTextBox.Enabled = true;
        }

        private void studentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EGNTextBox.Enabled = false;
            FIVTextBox.Enabled = true;
        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            Person person = null;
            if (teacherRadioButton.Checked)
            {
                person = new Teacher(nameTextBox.Text, emailTextBox.Text,
                    phoneTextBox.Text, EGNTextBox.Text);
            }
            else
            {
                person = new Student(nameTextBox.Text, emailTextBox.Text,
                    phoneTextBox.Text, int.Parse(FIVTextBox.Text));
            }
            University.GetInstance().AddUniPeople(person);
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            FIVTextBox.Text = string.Empty;
            EGNTextBox.Text = string.Empty;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateLetterInput(e);
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

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateLength(e, nameTextBox, 0, 30);
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
    }
}
