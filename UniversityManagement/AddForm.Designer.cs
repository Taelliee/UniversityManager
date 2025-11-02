namespace UniversityManagement
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            teacherRadioButton = new RadioButton();
            studentRadioButton = new RadioButton();
            EGNTextBox = new TextBox();
            FIVTextBox = new TextBox();
            EGNLabel = new Label();
            FIVLabel = new Label();
            addFormButton = new Button();
            groupBox1 = new GroupBox();
            backButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            nameLabel.ForeColor = Color.Maroon;
            nameLabel.Location = new Point(49, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 18);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            emailLabel.ForeColor = Color.Maroon;
            emailLabel.Location = new Point(49, 110);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 18);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.Maroon;
            phoneLabel.Location = new Point(49, 163);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 18);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Phone";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(141, 47);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(169, 27);
            nameTextBox.TabIndex = 3;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            nameTextBox.Validating += nameTextBox_Validating;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(141, 103);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 27);
            emailTextBox.TabIndex = 4;
            emailTextBox.KeyPress += emailTextBox_KeyPress;
            emailTextBox.Validating += emailTextBox_Validating;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(141, 156);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(125, 27);
            phoneTextBox.TabIndex = 5;
            phoneTextBox.KeyPress += phoneTextBox_KeyPress;
            phoneTextBox.Validating += phoneTextBox_Validating;
            // 
            // teacherRadioButton
            // 
            teacherRadioButton.AutoSize = true;
            teacherRadioButton.Checked = true;
            teacherRadioButton.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            teacherRadioButton.ForeColor = Color.Maroon;
            teacherRadioButton.Location = new Point(28, 25);
            teacherRadioButton.Name = "teacherRadioButton";
            teacherRadioButton.Size = new Size(99, 22);
            teacherRadioButton.TabIndex = 6;
            teacherRadioButton.TabStop = true;
            teacherRadioButton.Text = "Teacher";
            teacherRadioButton.UseVisualStyleBackColor = true;
            teacherRadioButton.CheckedChanged += teacherRadioButton_CheckedChanged;
            // 
            // studentRadioButton
            // 
            studentRadioButton.AutoSize = true;
            studentRadioButton.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            studentRadioButton.ForeColor = Color.Maroon;
            studentRadioButton.Location = new Point(152, 25);
            studentRadioButton.Name = "studentRadioButton";
            studentRadioButton.Size = new Size(99, 22);
            studentRadioButton.TabIndex = 7;
            studentRadioButton.Text = "Student";
            studentRadioButton.UseVisualStyleBackColor = true;
            studentRadioButton.CheckedChanged += studentRadioButton_CheckedChanged;
            // 
            // EGNTextBox
            // 
            EGNTextBox.Location = new Point(141, 349);
            EGNTextBox.Name = "EGNTextBox";
            EGNTextBox.Size = new Size(125, 27);
            EGNTextBox.TabIndex = 11;
            EGNTextBox.KeyPress += EGNTextBox_KeyPress;
            EGNTextBox.Validating += EGNTextBox_Validating;
            // 
            // FIVTextBox
            // 
            FIVTextBox.Enabled = false;
            FIVTextBox.Location = new Point(141, 296);
            FIVTextBox.Name = "FIVTextBox";
            FIVTextBox.Size = new Size(125, 27);
            FIVTextBox.TabIndex = 10;
            FIVTextBox.KeyPress += FIVTextBox_KeyPress;
            FIVTextBox.Validating += FIVTextBox_Validating;
            // 
            // EGNLabel
            // 
            EGNLabel.AutoSize = true;
            EGNLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            EGNLabel.ForeColor = Color.Maroon;
            EGNLabel.Location = new Point(49, 356);
            EGNLabel.Name = "EGNLabel";
            EGNLabel.Size = new Size(38, 18);
            EGNLabel.TabIndex = 9;
            EGNLabel.Text = "EGN";
            // 
            // FIVLabel
            // 
            FIVLabel.AutoSize = true;
            FIVLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            FIVLabel.ForeColor = Color.Maroon;
            FIVLabel.Location = new Point(49, 303);
            FIVLabel.Name = "FIVLabel";
            FIVLabel.Size = new Size(38, 18);
            FIVLabel.TabIndex = 8;
            FIVLabel.Text = "FIV";
            // 
            // addFormButton
            // 
            addFormButton.BackColor = Color.AntiqueWhite;
            addFormButton.Font = new Font("Stencil", 13.8F);
            addFormButton.ForeColor = Color.Maroon;
            addFormButton.Location = new Point(59, 406);
            addFormButton.Name = "addFormButton";
            addFormButton.Size = new Size(113, 44);
            addFormButton.TabIndex = 12;
            addFormButton.Text = "Add";
            addFormButton.UseVisualStyleBackColor = false;
            addFormButton.Click += addFormButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.Controls.Add(studentRadioButton);
            groupBox1.Controls.Add(teacherRadioButton);
            groupBox1.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(44, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 72);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Role:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.AntiqueWhite;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.Maroon;
            backButton.Location = new Point(183, 406);
            backButton.Name = "backButton";
            backButton.Size = new Size(113, 44);
            backButton.TabIndex = 14;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(347, 475);
            Controls.Add(backButton);
            Controls.Add(groupBox1);
            Controls.Add(addFormButton);
            Controls.Add(EGNTextBox);
            Controls.Add(FIVTextBox);
            Controls.Add(EGNLabel);
            Controls.Add(FIVLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Name = "AddForm";
            Text = "AddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private RadioButton teacherRadioButton;
        private RadioButton studentRadioButton;
        private TextBox EGNTextBox;
        private TextBox FIVTextBox;
        private Label EGNLabel;
        private Label FIVLabel;
        private Button addFormButton;
        private GroupBox groupBox1;
        private Button backButton;
    }
}