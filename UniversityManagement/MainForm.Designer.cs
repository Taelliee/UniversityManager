namespace UniversityManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            updateButton = new Button();
            viewButton = new Button();
            editMarkButton = new Button();
            addMarkButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.MistyRose;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Stencil", 16.2F);
            addButton.ForeColor = Color.Maroon;
            addButton.Location = new Point(53, 43);
            addButton.Name = "addButton";
            addButton.Size = new Size(236, 82);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MistyRose;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Stencil", 16.2F);
            updateButton.ForeColor = Color.Maroon;
            updateButton.Location = new Point(53, 260);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(236, 82);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // viewButton
            // 
            viewButton.BackColor = Color.MistyRose;
            viewButton.FlatStyle = FlatStyle.Popup;
            viewButton.Font = new Font("Stencil", 16.2F);
            viewButton.ForeColor = Color.Maroon;
            viewButton.Location = new Point(53, 478);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(236, 82);
            viewButton.TabIndex = 2;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click;
            // 
            // editMarkButton
            // 
            editMarkButton.BackColor = Color.MistyRose;
            editMarkButton.FlatStyle = FlatStyle.Popup;
            editMarkButton.Font = new Font("Stencil", 16.2F);
            editMarkButton.ForeColor = Color.Maroon;
            editMarkButton.Location = new Point(53, 370);
            editMarkButton.Name = "editMarkButton";
            editMarkButton.Size = new Size(236, 82);
            editMarkButton.TabIndex = 4;
            editMarkButton.Text = "Edit Mark";
            editMarkButton.UseVisualStyleBackColor = false;
            editMarkButton.Click += editMarkButton_Click;
            // 
            // addMarkButton
            // 
            addMarkButton.BackColor = Color.MistyRose;
            addMarkButton.FlatStyle = FlatStyle.Popup;
            addMarkButton.Font = new Font("Stencil", 16.2F);
            addMarkButton.ForeColor = Color.Maroon;
            addMarkButton.Location = new Point(53, 151);
            addMarkButton.Name = "addMarkButton";
            addMarkButton.Size = new Size(236, 82);
            addMarkButton.TabIndex = 3;
            addMarkButton.Text = "Add Mark";
            addMarkButton.UseVisualStyleBackColor = false;
            addMarkButton.Click += addMarkButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(351, 604);
            Controls.Add(editMarkButton);
            Controls.Add(addMarkButton);
            Controls.Add(viewButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Name = "MainForm";
            Text = "University Management";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button updateButton;
        private Button viewButton;
        private Button editMarkButton;
        private Button addMarkButton;
    }
}
