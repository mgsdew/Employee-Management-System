using System;
using System.Windows.Forms;

namespace EmployeeApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI aDepartmentEntryUi = new DepartmentEntryUI();
            aDepartmentEntryUi.Show();
        }

        private void employeeEntryButton_Click(object sender, EventArgs e)
        {
            EmployeeEntryUI aEmployeeEntryUi = new EmployeeEntryUI();
            aEmployeeEntryUi.Show();
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            GradeEntryUI aGradeEntryUi = new GradeEntryUI();
            aGradeEntryUi.Show();
        }

        private void empDtlEntryButton_Click(object sender, EventArgs e)
        {
            EmployeeDtlEntry aEmployeeDtlEntry =new EmployeeDtlEntry();
            aEmployeeDtlEntry.Show();
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeView aEmployeeView = new EmployeeView();
            aEmployeeView.Show();
        }
    }
}
