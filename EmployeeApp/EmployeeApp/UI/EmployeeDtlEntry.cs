using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeApp.Manager;
using EmployeeApp.Model;

namespace EmployeeApp.UI
{
    public partial class EmployeeDtlEntry : Form
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        EmployeeManager aEmployeeManager = new EmployeeManager();
        GradeManager aGradeManager = new GradeManager();

        public EmployeeDtlEntry()
        {
            InitializeComponent();
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";
            PopulateDepartmentComboBox();
            gradeComboBox.DisplayMember = "GradeLevel";
            gradeComboBox.ValueMember = "id";
            PopulateGradeComboBox();
        }

        private void PopulateGradeComboBox()
        {
            gradeComboBox.DataSource = aGradeManager.GetAll();
        }

        private void PopulateDepartmentComboBox()
        {
            deptComboBox.DataSource = aDepartmentManager.GetAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int emp_id = Convert.ToInt32(empComboBox.SelectedValue);
            int grade_id = Convert.ToInt32(gradeComboBox.SelectedValue);
            string msg = aEmployeeManager.UpdateGradeId(emp_id, grade_id);
            MessageBox.Show(msg);
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            empComboBox.DataSource= null;
            emailTextBox.Text = string.Empty;
            contactTextBox.Text = string.Empty;
            empComboBox.DisplayMember = "Name";
            empComboBox.ValueMember = "Id";
            PopulateEmployeeComboBox(Convert.ToInt32(deptComboBox.SelectedValue));
        }

        private void PopulateEmployeeComboBox(int deptId)
        {
            empComboBox.DataSource = aEmployeeManager.GetAll(deptId);
        }

        private void empComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empComboBox.DataSource == null)
                return;

            Employee aEmployee = (Employee)empComboBox.SelectedItem;
            emailTextBox.Text = aEmployee.Email;
            contactTextBox.Text = aEmployee.Contact;
        }

        private void gradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grade aGrade = (Grade)gradeComboBox.SelectedItem;
            salaryTextBox.Text= aGradeManager.CalculateTotalSalary(aGrade).ToString();
        }
    }
}
