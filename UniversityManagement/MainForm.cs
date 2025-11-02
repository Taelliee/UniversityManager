using UniversityManagement.models;

namespace UniversityManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            this.Hide();
            addForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            this.Hide();
            updateForm.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            this.Hide();
            viewForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UniversityFile.SaveUniPeopleToFile();
        }

        private void addMarkButton_Click(object sender, EventArgs e)
        {
            AddMarkForm addMarkForm = new AddMarkForm();
            this.Hide();
            addMarkForm.Show();
        }

        private void editMarkButton_Click(object sender, EventArgs e)
        {
            EditMarkForm editMarkForm = new EditMarkForm();
            this.Hide();
            editMarkForm.Show();
        }
    }
}
