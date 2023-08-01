namespace Harrison_CourseProject_Part2
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.PrintPaycheckButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(32, 33);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(195, 69);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(300, 33);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(195, 69);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(571, 33);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(195, 69);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // PrintPaycheckButton
            // 
            this.PrintPaycheckButton.Location = new System.Drawing.Point(858, 33);
            this.PrintPaycheckButton.Name = "PrintPaycheckButton";
            this.PrintPaycheckButton.Size = new System.Drawing.Size(195, 69);
            this.PrintPaycheckButton.TabIndex = 3;
            this.PrintPaycheckButton.Text = "Print Paychecks";
            this.PrintPaycheckButton.UseVisualStyleBackColor = true;
            this.PrintPaycheckButton.Click += new System.EventHandler(this.PrintPaycheckButton_Click);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.HideSelection = false;
            this.EmployeesListBox.Location = new System.Drawing.Point(32, 123);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(1021, 619);
            this.EmployeesListBox.TabIndex = 4;
            this.EmployeesListBox.UseCompatibleStateImageBehavior = false;
            this.EmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 834);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.PrintPaycheckButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button PrintPaycheckButton;
        private System.Windows.Forms.ListView EmployeesListBox;
    }
}

