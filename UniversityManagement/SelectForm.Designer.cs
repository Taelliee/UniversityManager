namespace UniversityManagement
{
    partial class SelectForm
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
            selectComboBox = new ComboBox();
            selectLabel = new Label();
            backButton = new Button();
            selectFormLabel = new Label();
            selectFormLabel2 = new Label();
            selectComboBox2 = new ComboBox();
            findButton = new Button();
            SuspendLayout();
            // 
            // selectComboBox
            // 
            selectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectComboBox.FormattingEnabled = true;
            selectComboBox.Location = new Point(58, 71);
            selectComboBox.Name = "selectComboBox";
            selectComboBox.Size = new Size(251, 28);
            selectComboBox.TabIndex = 0;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Location = new Point(72, 55);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(0, 20);
            selectLabel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.RosyBrown;
            backButton.Font = new Font("Stencil", 13.8F);
            backButton.ForeColor = Color.MistyRose;
            backButton.Location = new Point(204, 343);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 41);
            backButton.TabIndex = 23;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // selectFormLabel
            // 
            selectFormLabel.AutoSize = true;
            selectFormLabel.Location = new Point(58, 33);
            selectFormLabel.Name = "selectFormLabel";
            selectFormLabel.Size = new Size(0, 20);
            selectFormLabel.TabIndex = 24;
            // 
            // selectFormLabel2
            // 
            selectFormLabel2.AutoSize = true;
            selectFormLabel2.Location = new Point(58, 180);
            selectFormLabel2.Name = "selectFormLabel2";
            selectFormLabel2.Size = new Size(0, 20);
            selectFormLabel2.TabIndex = 26;
            // 
            // selectComboBox2
            // 
            selectComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            selectComboBox2.FormattingEnabled = true;
            selectComboBox2.Location = new Point(58, 219);
            selectComboBox2.Name = "selectComboBox2";
            selectComboBox2.Size = new Size(251, 28);
            selectComboBox2.TabIndex = 25;
            selectComboBox2.Visible = false;
            // 
            // findButton
            // 
            findButton.BackColor = Color.RosyBrown;
            findButton.Font = new Font("Stencil", 13.8F);
            findButton.ForeColor = Color.MistyRose;
            findButton.Location = new Point(58, 343);
            findButton.Name = "findButton";
            findButton.Size = new Size(105, 41);
            findButton.TabIndex = 27;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += findButton_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(363, 419);
            Controls.Add(findButton);
            Controls.Add(selectFormLabel2);
            Controls.Add(selectComboBox2);
            Controls.Add(selectFormLabel);
            Controls.Add(backButton);
            Controls.Add(selectLabel);
            Controls.Add(selectComboBox);
            Name = "SelectForm";
            Text = "SelectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectComboBox;
        private Label selectLabel;
        private Button backButton;
        private Label selectFormLabel;
        private Label selectFormLabel2;
        private ComboBox selectComboBox2;
        private Button findButton;
    }
}