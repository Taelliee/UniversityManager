namespace UniversityManagement
{
    partial class EditMarkForm
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
            markComboBox = new ComboBox();
            markLabel = new Label();
            subjectComboBox = new ComboBox();
            subjectLabel = new Label();
            studentComboBox = new ComboBox();
            studentLabel = new Label();
            changedMarkComboBox = new ComboBox();
            changedMarkLabel = new Label();
            editMarkButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // markComboBox
            // 
            markComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            markComboBox.FormattingEnabled = true;
            markComboBox.Location = new Point(166, 203);
            markComboBox.Name = "markComboBox";
            markComboBox.Size = new Size(190, 28);
            markComboBox.TabIndex = 26;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            markLabel.ForeColor = Color.Maroon;
            markLabel.Location = new Point(109, 207);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(48, 18);
            markLabel.TabIndex = 25;
            markLabel.Text = "Mark";
            // 
            // subjectComboBox
            // 
            subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Location = new Point(166, 120);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(190, 28);
            subjectComboBox.TabIndex = 24;
            subjectComboBox.SelectedIndexChanged += subjectComboBox_SelectedIndexChanged;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectLabel.ForeColor = Color.Maroon;
            subjectLabel.Location = new Point(79, 124);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(78, 18);
            subjectLabel.TabIndex = 23;
            subjectLabel.Text = "Subject";
            // 
            // studentComboBox
            // 
            studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(166, 43);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(190, 28);
            studentComboBox.TabIndex = 22;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLabel.ForeColor = Color.Maroon;
            studentLabel.Location = new Point(79, 47);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(78, 18);
            studentLabel.TabIndex = 21;
            studentLabel.Text = "Student";
            studentLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // changedMarkComboBox
            // 
            changedMarkComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            changedMarkComboBox.FormattingEnabled = true;
            changedMarkComboBox.Location = new Point(166, 287);
            changedMarkComboBox.Name = "changedMarkComboBox";
            changedMarkComboBox.Size = new Size(190, 28);
            changedMarkComboBox.TabIndex = 28;
            // 
            // changedMarkLabel
            // 
            changedMarkLabel.AutoSize = true;
            changedMarkLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changedMarkLabel.ForeColor = Color.Maroon;
            changedMarkLabel.Location = new Point(59, 291);
            changedMarkLabel.Name = "changedMarkLabel";
            changedMarkLabel.Size = new Size(98, 18);
            changedMarkLabel.TabIndex = 27;
            changedMarkLabel.Text = "Change to";
            // 
            // editMarkButton
            // 
            editMarkButton.BackColor = Color.RosyBrown;
            editMarkButton.Font = new Font("Stencil", 13.8F);
            editMarkButton.ForeColor = Color.MistyRose;
            editMarkButton.Location = new Point(53, 376);
            editMarkButton.Name = "editMarkButton";
            editMarkButton.Size = new Size(167, 41);
            editMarkButton.TabIndex = 29;
            editMarkButton.Text = "Edit Mark";
            editMarkButton.UseVisualStyleBackColor = false;
            editMarkButton.Click += editMarkButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.RosyBrown;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.MistyRose;
            backButton.Location = new Point(239, 376);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 41);
            backButton.TabIndex = 30;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // EditMarkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(402, 450);
            Controls.Add(backButton);
            Controls.Add(editMarkButton);
            Controls.Add(changedMarkComboBox);
            Controls.Add(changedMarkLabel);
            Controls.Add(markComboBox);
            Controls.Add(markLabel);
            Controls.Add(subjectComboBox);
            Controls.Add(subjectLabel);
            Controls.Add(studentComboBox);
            Controls.Add(studentLabel);
            Name = "EditMarkForm";
            Text = "EditMarkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox markComboBox;
        private Label markLabel;
        private ComboBox subjectComboBox;
        private Label subjectLabel;
        private ComboBox studentComboBox;
        private Label studentLabel;
        private ComboBox changedMarkComboBox;
        private Label changedMarkLabel;
        private Button editMarkButton;
        private Button backButton;
    }
}