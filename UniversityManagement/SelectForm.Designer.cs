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
            SuspendLayout();
            // 
            // selectComboBox
            // 
            selectComboBox.FormattingEnabled = true;
            selectComboBox.Location = new Point(72, 101);
            selectComboBox.Name = "selectComboBox";
            selectComboBox.Size = new Size(206, 28);
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
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(347, 419);
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
    }
}