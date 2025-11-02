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
        public SelectForm()
        {
            InitializeComponent();
            selectComboBox.DataSource = University.GetInstance().GetUniversitySubjects();
            selectComboBox.DisplayMember = "SubjectName";
        }

        public SelectForm(SelectOption selectOption)
        {
            InitializeComponent();
            switch(selectOption)
            {
                case SelectOption.AvgSubjectGrade:

                    break;
                case SelectOption.AvgStudentGrade:
                    
                    break;

                case SelectOption.CountMarksPerMarkType:
                    
                    break;

                case SelectOption.SearchStudent:
                    
                    break;

                default:
                    
                    break;

            }
        }
    }
}
