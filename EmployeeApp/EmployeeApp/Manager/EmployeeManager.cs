using System.Collections.Generic;
using EmployeeApp.DataAccess;
using EmployeeApp.Model;

namespace EmployeeApp.Manager
{
    internal class EmployeeManager
    {
        EmployeeGateWay anEmployeeGateway = new EmployeeGateWay();
            
        public string Save(Employee anEmployee)
        {
            return anEmployeeGateway.Save(anEmployee);
        }

        public string UpdateGradeId(int employee_id, int grade_id)
        {
            return anEmployeeGateway.UpdateGradeId(employee_id, grade_id);
        }

        public List<Employee> GetAll(int deptId)
        {
            return anEmployeeGateway.GetAll(deptId);
        }
    }
}