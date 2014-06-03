namespace EmployeeApp.UI
{
    partial class EmployeeView
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
            this.label1 = new System.Windows.Forms.Label();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradelevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSalaryextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Depaertment";
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(144, 19);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(303, 21);
            this.deptComboBox.TabIndex = 1;
            this.deptComboBox.Text = "Select";
            this.deptComboBox.Click += new System.EventHandler(this.deptComboBox_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(530, 17);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.AllowUserToDeleteRows = false;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.email,
            this.Contact,
            this.gradelevel,
            this.basicAmt,
            this.medical,
            this.houseRent,
            this.Total});
            this.employeeGridView.Location = new System.Drawing.Point(12, 52);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.Size = new System.Drawing.Size(604, 188);
            this.employeeGridView.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Employee Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // gradelevel
            // 
            this.gradelevel.HeaderText = "Grade Level";
            this.gradelevel.Name = "gradelevel";
            this.gradelevel.ReadOnly = true;
            // 
            // basicAmt
            // 
            this.basicAmt.HeaderText = "Basic";
            this.basicAmt.Name = "basicAmt";
            this.basicAmt.ReadOnly = true;
            // 
            // medical
            // 
            this.medical.HeaderText = "Medical";
            this.medical.Name = "medical";
            this.medical.ReadOnly = true;
            // 
            // houseRent
            // 
            this.houseRent.HeaderText = "House Rent";
            this.houseRent.Name = "houseRent";
            this.houseRent.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Group Salary";
            // 
            // totalSalaryextBox
            // 
            this.totalSalaryextBox.Location = new System.Drawing.Point(486, 264);
            this.totalSalaryextBox.Name = "totalSalaryextBox";
            this.totalSalaryextBox.Size = new System.Drawing.Size(130, 20);
            this.totalSalaryextBox.TabIndex = 5;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 296);
            this.Controls.Add(this.totalSalaryextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradelevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn medical;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalSalaryextBox;
    }
}