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
    public partial class EmployeeView : Form
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        EmployeeManager aEmployeeManager = new EmployeeManager();
        GradeManager aGradeManager = new GradeManager();
        public EmployeeView()
        {
            InitializeComponent(); 
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();
            totalSalaryextBox.Text = string.Empty;
            decimal totalSalary = 0;
            int srl = 0;
            List<Employee> employees = aEmployeeManager.GetAll(Convert.ToInt32(deptComboBox.SelectedValue));

            foreach (Employee employee in employees)
            {
                employeeGridView.Rows.Add();

                employeeGridView.Rows[srl].Cells[0].Value = employee.Name;
                employeeGridView.Rows[srl].Cells[1].Value = employee.Email;
                employeeGridView.Rows[srl].Cells[2].Value = employee.Contact;
                employeeGridView.Rows[srl].Cells[3].Value = employee.Grade.GradeLevel;
                employeeGridView.Rows[srl].Cells[4].Value = employee.Grade.BasicAmt;
                employeeGridView.Rows[srl].Cells[5].Value = aGradeManager.GetMedicalAmount(employee.Grade);
                employeeGridView.Rows[srl].Cells[6].Value = aGradeManager.GetHouseRent(employee.Grade);
                employeeGridView.Rows[srl].Cells[7].Value = aGradeManager.CalculateTotalSalary(employee.Grade);

                totalSalary += aGradeManager.CalculateTotalSalary(employee.Grade);

                srl++;
            }

            totalSalaryextBox.Text = totalSalary.ToString();
        }

        private void deptComboBox_Click(object sender, EventArgs e)
        {
            if (deptComboBox.DataSource ==null)
                deptComboBox.DataSource = aDepartmentManager.GetAll();
        }
    }
}
