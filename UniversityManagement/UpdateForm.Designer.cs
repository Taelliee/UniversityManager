namespace UniversityManagement
{
    partial class UpdateForm
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
            EGNLabel = new Label();
            FIVLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            nameLabel = new Label();
            personComboBox = new ComboBox();
            updateFormButton = new Button();
            EGNTextBox = new TextBox();
            FIVTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            backButton = new Button();
            nameTextBox = new TextBox();
            studentsCheckBox = new CheckBox();
            teachersCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // EGNLabel
            // 
            EGNLabel.AutoSize = true;
            EGNLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            EGNLabel.ForeColor = Color.Maroon;
            EGNLabel.Location = new Point(387, 257);
            EGNLabel.Name = "EGNLabel";
            EGNLabel.Size = new Size(38, 18);
            EGNLabel.TabIndex = 14;
            EGNLabel.Text = "EGN";
            // 
            // FIVLabel
            // 
            FIVLabel.AutoSize = true;
            FIVLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            FIVLabel.ForeColor = Color.Maroon;
            FIVLabel.Location = new Point(387, 204);
            FIVLabel.Name = "FIVLabel";
            FIVLabel.Size = new Size(38, 18);
            FIVLabel.TabIndex = 13;
            FIVLabel.Text = "FIV";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.Maroon;
            phoneLabel.Location = new Point(387, 150);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 18);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            emailLabel.ForeColor = Color.Maroon;
            emailLabel.Location = new Point(387, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 18);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "E-mail";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Maroon;
            nameLabel.Location = new Point(387, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 18);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // personComboBox
            // 
            personComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            personComboBox.FormattingEnabled = true;
            personComboBox.Location = new Point(62, 150);
            personComboBox.Name = "personComboBox";
            personComboBox.Size = new Size(279, 28);
            personComboBox.TabIndex = 15;
            personComboBox.SelectedIndexChanged += namesComboBox_SelectedIndexChanged;
            // 
            // updateFormButton
            // 
            updateFormButton.BackColor = Color.RosyBrown;
            updateFormButton.Font = new Font("Stencil", 13.8F);
            updateFormButton.ForeColor = Color.MistyRose;
            updateFormButton.Location = new Point(419, 315);
            updateFormButton.Name = "updateFormButton";
            updateFormButton.Size = new Size(123, 41);
            updateFormButton.TabIndex = 16;
            updateFormButton.Text = "Update";
            updateFormButton.UseVisualStyleBackColor = false;
            updateFormButton.Click += updateFormButton_Click;
            // 
            // EGNTextBox
            // 
            EGNTextBox.Enabled = false;
            EGNTextBox.Location = new Point(462, 250);
            EGNTextBox.Name = "EGNTextBox";
            EGNTextBox.Size = new Size(125, 27);
            EGNTextBox.TabIndex = 21;
            EGNTextBox.KeyPress += EGNTextBox_KeyPress;
            EGNTextBox.Validating += EGNTextBox_Validating;
            // 
            // FIVTextBox
            // 
            FIVTextBox.Enabled = false;
            FIVTextBox.Location = new Point(462, 201);
            FIVTextBox.Name = "FIVTextBox";
            FIVTextBox.Size = new Size(125, 27);
            FIVTextBox.TabIndex = 20;
            FIVTextBox.KeyPress += FIVTextBox_KeyPress;
            FIVTextBox.Validating += FIVTextBox_Validating;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Enabled = false;
            phoneTextBox.Location = new Point(462, 147);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(125, 27);
            phoneTextBox.TabIndex = 19;
            phoneTextBox.KeyPress += phoneTextBox_KeyPress;
            phoneTextBox.Validating += phoneTextBox_Validating;
            // 
            // emailTextBox
            // 
            emailTextBox.Enabled = false;
            emailTextBox.Location = new Point(461, 93);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(235, 27);
            emailTextBox.TabIndex = 18;
            emailTextBox.KeyPress += emailTextBox_KeyPress;
            emailTextBox.Validating += emailTextBox_Validating;
            // 
            // backButton
            // 
            backButton.BackColor = Color.RosyBrown;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.MistyRose;
            backButton.Location = new Point(565, 315);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 41);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(462, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(169, 27);
            nameTextBox.TabIndex = 23;
            // 
            // studentsCheckBox
            // 
            studentsCheckBox.AutoSize = true;
            studentsCheckBox.BackColor = Color.MistyRose;
            studentsCheckBox.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            studentsCheckBox.ForeColor = Color.Maroon;
            studentsCheckBox.Location = new Point(62, 50);
            studentsCheckBox.Name = "studentsCheckBox";
            studentsCheckBox.Size = new Size(110, 22);
            studentsCheckBox.TabIndex = 24;
            studentsCheckBox.Text = "students";
            studentsCheckBox.UseVisualStyleBackColor = false;
            studentsCheckBox.CheckedChanged += studentsCheckBox_CheckedChanged;
            // 
            // teachersCheckBox
            // 
            teachersCheckBox.AutoSize = true;
            teachersCheckBox.BackColor = Color.MistyRose;
            teachersCheckBox.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Bold);
            teachersCheckBox.ForeColor = Color.Maroon;
            teachersCheckBox.Location = new Point(62, 96);
            teachersCheckBox.Name = "teachersCheckBox";
            teachersCheckBox.Size = new Size(110, 22);
            teachersCheckBox.TabIndex = 25;
            teachersCheckBox.Text = "teachers";
            teachersCheckBox.UseVisualStyleBackColor = false;
            teachersCheckBox.CheckedChanged += teachersCheckBox_CheckedChanged;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(736, 395);
            Controls.Add(teachersCheckBox);
            Controls.Add(studentsCheckBox);
            Controls.Add(nameTextBox);
            Controls.Add(backButton);
            Controls.Add(EGNTextBox);
            Controls.Add(FIVTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(updateFormButton);
            Controls.Add(personComboBox);
            Controls.Add(EGNLabel);
            Controls.Add(FIVLabel);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EGNLabel;
        private Label FIVLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label nameLabel;
        private ComboBox personComboBox;
        private Button updateFormButton;
        private TextBox EGNTextBox;
        private TextBox FIVTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private Button backButton;
        private TextBox nameTextBox;
        private CheckBox studentsCheckBox;
        private CheckBox teachersCheckBox;
    }
}