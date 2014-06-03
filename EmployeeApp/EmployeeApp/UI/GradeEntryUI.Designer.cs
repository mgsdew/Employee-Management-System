namespace EmployeeApp.UI
{
    partial class GradeEntryUI
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
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.basicAmtTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medicalAmtTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Level";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(147, 20);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(148, 20);
            this.levelTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Amount";
            // 
            // basicAmtTextBox
            // 
            this.basicAmtTextBox.Location = new System.Drawing.Point(147, 46);
            this.basicAmtTextBox.Name = "basicAmtTextBox";
            this.basicAmtTextBox.Size = new System.Drawing.Size(148, 20);
            this.basicAmtTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medical Allowence (%)";
            // 
            // medicalAmtTextBox
            // 
            this.medicalAmtTextBox.Location = new System.Drawing.Point(147, 72);
            this.medicalAmtTextBox.Name = "medicalAmtTextBox";
            this.medicalAmtTextBox.Size = new System.Drawing.Size(148, 20);
            this.medicalAmtTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "House Rent (%)";
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(147, 98);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(148, 20);
            this.houseRentTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(220, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 33);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // GradeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 189);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicalAmtTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.basicAmtTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GradeEntryUI";
            this.Text = "Grade Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox basicAmtTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medicalAmtTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}