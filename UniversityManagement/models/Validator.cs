using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.models
{
    public static class Validator
    {
        //letters
        public static void ValidateLetterInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                WarnUser("Only letters and spaces are allowed!");
            }
        }

        //numbers
        public static void ValidateNumberInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                WarnUser("Only digits are allowed!");
            }
        }

        //email
        public static void ValidateEmailInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-')
            {
                e.Handled = true;
                WarnUser("Invalid character for an email address.");
            }
        }

        //length
        public static void ValidateLength(CancelEventArgs e, TextBox textBox, int minLength, int maxLength)
        {
            if (textBox.Text.Length < minLength)
            {
                MessageBox.Show(
                    $"Cannot be less than {minLength} characters.",
                    "Too short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                e.Cancel = true;
            }
            if (textBox.Text.Length > maxLength)
            {
                MessageBox.Show(
                    $"Cannot exceed {maxLength} characters.",
                    "Too long",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textBox.Text = textBox.Text.Substring(0, maxLength); // trim extra characters
                textBox.SelectionStart = textBox.Text.Length; // keep cursor at end
                e.Cancel = true;
            }
        }

        private static void WarnUser(string message)
        {
             MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}