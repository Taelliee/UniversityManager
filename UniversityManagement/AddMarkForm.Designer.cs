namespace UniversityManagement
{
    partial class AddMarkForm
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
            studentLabel = new Label();
            studentComboBox = new ComboBox();
            subjectComboBox = new ComboBox();
            subjectLabel = new Label();
            markComboBox = new ComboBox();
            markLabel = new Label();
            addMarkButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLabel.ForeColor = Color.Maroon;
            studentLabel.Location = new Point(65, 50);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(78, 18);
            studentLabel.TabIndex = 11;
            studentLabel.Text = "Student";
            studentLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // studentComboBox
            // 
            studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(159, 46);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(228, 28);
            studentComboBox.TabIndex = 16;
            // 
            // subjectComboBox
            // 
            subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Location = new Point(159, 123);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(228, 28);
            subjectComboBox.TabIndex = 18;
            subjectComboBox.SelectedIndexChanged += subjectComboBox_SelectedIndexChanged;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectLabel.ForeColor = Color.Maroon;
            subjectLabel.Location = new Point(65, 127);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(78, 18);
            subjectLabel.TabIndex = 17;
            subjectLabel.Text = "Subject";
            // 
            // markComboBox
            // 
            markComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            markComboBox.Enabled = false;
            markComboBox.FormattingEnabled = true;
            markComboBox.Location = new Point(159, 206);
            markComboBox.Name = "markComboBox";
            markComboBox.Size = new Size(190, 28);
            markComboBox.TabIndex = 20;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            markLabel.ForeColor = Color.Maroon;
            markLabel.Location = new Point(95, 210);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(48, 18);
            markLabel.TabIndex = 19;
            markLabel.Text = "Mark";
            // 
            // addMarkButton
            // 
            addMarkButton.BackColor = Color.RosyBrown;
            addMarkButton.Font = new Font("Stencil", 13.8F);
            addMarkButton.ForeColor = Color.MistyRose;
            addMarkButton.Location = new Point(82, 303);
            addMarkButton.Name = "addMarkButton";
            addMarkButton.Size = new Size(167, 41);
            addMarkButton.TabIndex = 21;
            addMarkButton.Text = "Add Mark";
            addMarkButton.UseVisualStyleBackColor = false;
            addMarkButton.Click += addMarkButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.RosyBrown;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.MistyRose;
            backButton.Location = new Point(272, 303);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 41);
            backButton.TabIndex = 23;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // AddMarkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(452, 376);
            Controls.Add(backButton);
            Controls.Add(addMarkButton);
            Controls.Add(markComboBox);
            Controls.Add(markLabel);
            Controls.Add(subjectComboBox);
            Controls.Add(subjectLabel);
            Controls.Add(studentComboBox);
            Controls.Add(studentLabel);
            Name = "AddMarkForm";
            Text = "AddMarkForm";
            FormClosing += AddMarkForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentLabel;
        private ComboBox studentComboBox;
        private ComboBox subjectComboBox;
        private Label subjectLabel;
        private ComboBox markComboBox;
        private Label markLabel;
        private Button addMarkButton;
        private Button backButton;
    }
}