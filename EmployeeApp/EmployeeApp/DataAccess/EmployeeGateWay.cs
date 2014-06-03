using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EmployeeApp.Model;
using System.Configuration;

namespace EmployeeApp.DataAccess
{
    internal class EmployeeGateWay
    {
        private string connectionString = null;

        public EmployeeGateWay()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Employee anEmployee)
        {
            string query = "INSERT INTO employee(name, email, contact, department_id, joining_date)" +
                           " VALUES ('" + anEmployee.Name + "','" + anEmployee.Email + "','" +
                           anEmployee.Contact + "'," + anEmployee.Department.Id + ",'" + anEmployee.JoiningDate + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Employee saved";
        }

        public string UpdateGradeId(int employee_id, int grade_id)
        {
            string query = "update employee set grade_id = " + grade_id + " where id = " + employee_id + "";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Grade assigned for Employee.";
        }

        public List<Employee> GetAll(int deptId)
        {
            string query = "select e.*,g.* from employee e left join Grade g on e.grade_id = g.id where department_id= " + deptId;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Employee> employees = new List<Employee>();
            while (sqlDataReader.Read())
            {
                Employee anEmployee = new Employee();
                Grade aGrade = new Grade();

                anEmployee.Id = Convert.ToInt32(sqlDataReader[0]);
                anEmployee.Name = sqlDataReader[1].ToString();
                anEmployee.Email = sqlDataReader[2].ToString();
                anEmployee.Contact = sqlDataReader[3].ToString();
                //anEmployee.Department.Id = Convert.ToInt32(sqlDataReader[4]);
                anEmployee.JoiningDate = Convert.ToDateTime(sqlDataReader[5]);

                aGrade.Id = Convert.ToInt32(sqlDataReader[7]);
                aGrade.GradeLevel = sqlDataReader[8].ToString();
                aGrade.BasicAmt = Convert.ToDecimal(sqlDataReader[9]);
                aGrade.Medical = Convert.ToDecimal(sqlDataReader[10]);
                aGrade.HouseRent = Convert.ToDecimal(sqlDataReader[11]);

                anEmployee.Grade = aGrade;

                employees.Add(anEmployee);
            }

            sqlConnection.Close();
            return employees;
        }
    }
}