namespace UniversityManagement
{
    partial class ViewForm
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
            uniPeopleTable = new TableLayoutPanel();
            EGNLabel = new Label();
            FIVLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            nameLabel = new Label();
            numberLabel = new Label();
            backButton = new Button();
            viewMenuStrip = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            marksToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            averageGradePerSubjectToolStripMenuItem = new ToolStripMenuItem();
            numberOfMarksToolStripMenuItem = new ToolStripMenuItem();
            averageGradeForStudentToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            marksTable = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            uniPeopleTable.SuspendLayout();
            viewMenuStrip.SuspendLayout();
            marksTable.SuspendLayout();
            SuspendLayout();
            // 
            // uniPeopleTable
            // 
            uniPeopleTable.AutoScroll = true;
            uniPeopleTable.AutoSize = true;
            uniPeopleTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uniPeopleTable.ColumnCount = 6;
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.064079F));
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1702671F));
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.20432F));
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.081728F));
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2802191F));
            uniPeopleTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1993847F));
            uniPeopleTable.Controls.Add(EGNLabel, 5, 0);
            uniPeopleTable.Controls.Add(FIVLabel, 4, 0);
            uniPeopleTable.Controls.Add(phoneLabel, 3, 0);
            uniPeopleTable.Controls.Add(emailLabel, 2, 0);
            uniPeopleTable.Controls.Add(nameLabel, 1, 0);
            uniPeopleTable.Controls.Add(numberLabel, 0, 0);
            uniPeopleTable.Dock = DockStyle.Top;
            uniPeopleTable.Location = new Point(0, 28);
            uniPeopleTable.Name = "uniPeopleTable";
            uniPeopleTable.RowCount = 1;
            uniPeopleTable.RowStyles.Add(new RowStyle());
            uniPeopleTable.Size = new Size(940, 18);
            uniPeopleTable.TabIndex = 0;
            uniPeopleTable.Tag = "";
            // 
            // EGNLabel
            // 
            EGNLabel.AutoSize = true;
            EGNLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            EGNLabel.ForeColor = Color.Maroon;
            EGNLabel.Location = new Point(825, 0);
            EGNLabel.Name = "EGNLabel";
            EGNLabel.Size = new Size(38, 18);
            EGNLabel.TabIndex = 4;
            EGNLabel.Text = "EGN";
            // 
            // FIVLabel
            // 
            FIVLabel.AutoSize = true;
            FIVLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            FIVLabel.ForeColor = Color.Maroon;
            FIVLabel.Location = new Point(701, 0);
            FIVLabel.Name = "FIVLabel";
            FIVLabel.Size = new Size(38, 18);
            FIVLabel.TabIndex = 3;
            FIVLabel.Text = "FIV";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.Maroon;
            phoneLabel.Location = new Point(588, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 18);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            emailLabel.ForeColor = Color.Maroon;
            emailLabel.Location = new Point(305, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 18);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            nameLabel.ForeColor = Color.Maroon;
            nameLabel.Location = new Point(69, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 18);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            numberLabel.ForeColor = Color.Maroon;
            numberLabel.Location = new Point(3, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(38, 18);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "No:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.AntiqueWhite;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.Maroon;
            backButton.Location = new Point(815, 539);
            backButton.Name = "backButton";
            backButton.Size = new Size(113, 44);
            backButton.TabIndex = 15;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // viewMenuStrip
            // 
            viewMenuStrip.BackColor = Color.DarkSalmon;
            viewMenuStrip.ImageScalingSize = new Size(20, 20);
            viewMenuStrip.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, selectToolStripMenuItem, toolStripMenuItem1 });
            viewMenuStrip.Location = new Point(0, 0);
            viewMenuStrip.Name = "viewMenuStrip";
            viewMenuStrip.Size = new Size(940, 28);
            viewMenuStrip.TabIndex = 16;
            viewMenuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.BackColor = Color.WhiteSmoke;
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, marksToolStripMenuItem });
            viewToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            viewToolStripMenuItem.ForeColor = Color.Maroon;
            viewToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.BackColor = Color.MistyRose;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(131, 26);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // marksToolStripMenuItem
            // 
            marksToolStripMenuItem.BackColor = Color.MistyRose;
            marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            marksToolStripMenuItem.Size = new Size(131, 26);
            marksToolStripMenuItem.Text = "Marks";
            marksToolStripMenuItem.Click += marksToolStripMenuItem_Click;
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.BackColor = Color.WhiteSmoke;
            selectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { averageGradePerSubjectToolStripMenuItem, numberOfMarksToolStripMenuItem, averageGradeForStudentToolStripMenuItem, searchStudentToolStripMenuItem });
            selectToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selectToolStripMenuItem.ForeColor = Color.Maroon;
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(63, 24);
            selectToolStripMenuItem.Text = "Select";
            // 
            // averageGradePerSubjectToolStripMenuItem
            // 
            averageGradePerSubjectToolStripMenuItem.BackColor = Color.PowderBlue;
            averageGradePerSubjectToolStripMenuItem.Name = "averageGradePerSubjectToolStripMenuItem";
            averageGradePerSubjectToolStripMenuItem.Size = new Size(269, 26);
            averageGradePerSubjectToolStripMenuItem.Text = "Average grade per Subject";
            averageGradePerSubjectToolStripMenuItem.Click += averageGradePerSubjectToolStripMenuItem_Click;
            // 
            // numberOfMarksToolStripMenuItem
            // 
            numberOfMarksToolStripMenuItem.BackColor = Color.PowderBlue;
            numberOfMarksToolStripMenuItem.Name = "numberOfMarksToolStripMenuItem";
            numberOfMarksToolStripMenuItem.Size = new Size(269, 26);
            numberOfMarksToolStripMenuItem.Text = "Number of Marks";
            numberOfMarksToolStripMenuItem.Click += numberOfMarksToolStripMenuItem_Click;
            // 
            // averageGradeForStudentToolStripMenuItem
            // 
            averageGradeForStudentToolStripMenuItem.BackColor = Color.PowderBlue;
            averageGradeForStudentToolStripMenuItem.Name = "averageGradeForStudentToolStripMenuItem";
            averageGradeForStudentToolStripMenuItem.Size = new Size(269, 26);
            averageGradeForStudentToolStripMenuItem.Text = "Average grade for Student";
            averageGradeForStudentToolStripMenuItem.Click += averageGradeForStudentToolStripMenuItem_Click;
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.BackColor = Color.PowderBlue;
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(269, 26);
            searchStudentToolStripMenuItem.Text = "Search Student";
            searchStudentToolStripMenuItem.Click += searchStudentToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // marksTable
            // 
            marksTable.AutoScroll = true;
            marksTable.AutoSize = true;
            marksTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            marksTable.ColumnCount = 4;
            marksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.026532F));
            marksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4401932F));
            marksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1282234F));
            marksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4050541F));
            marksTable.Controls.Add(label3, 3, 0);
            marksTable.Controls.Add(label4, 2, 0);
            marksTable.Controls.Add(label5, 1, 0);
            marksTable.Controls.Add(label6, 0, 0);
            marksTable.Dock = DockStyle.Top;
            marksTable.Location = new Point(0, 46);
            marksTable.Name = "marksTable";
            marksTable.RowCount = 1;
            marksTable.RowStyles.Add(new RowStyle());
            marksTable.Size = new Size(940, 18);
            marksTable.TabIndex = 17;
            marksTable.Tag = "";
            marksTable.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(760, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 2;
            label3.Text = "Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(383, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(69, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 1;
            label5.Text = "Student";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 18);
            label6.TabIndex = 0;
            label6.Text = "No:";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(940, 595);
            Controls.Add(marksTable);
            Controls.Add(backButton);
            Controls.Add(uniPeopleTable);
            Controls.Add(viewMenuStrip);
            MainMenuStrip = viewMenuStrip;
            Name = "ViewForm";
            Text = "ViewForm";
            uniPeopleTable.ResumeLayout(false);
            uniPeopleTable.PerformLayout();
            viewMenuStrip.ResumeLayout(false);
            viewMenuStrip.PerformLayout();
            marksTable.ResumeLayout(false);
            marksTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel uniPeopleTable;
        private Label numberLabel;
        private Label FIVLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label nameLabel;
        private Label EGNLabel;
        private Button backButton;
        private MenuStrip viewMenuStrip;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem marksToolStripMenuItem;
        private TableLayoutPanel marksTable;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem averageGradePerSubjectToolStripMenuItem;
        private ToolStripMenuItem numberOfMarksToolStripMenuItem;
        private ToolStripMenuItem averageGradeForStudentToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}