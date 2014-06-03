using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EmployeeApp.Model;
using System.Configuration;

namespace EmployeeApp.DataAccess
{
    class DepartmentGateway
    {
        private string connectionString = null;

        public DepartmentGateway()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Department aDepartment)
        {
            string query = "INSERT INTO department(name, code) VALUES ('" + aDepartment.Name + "','" + aDepartment.Code + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Department saved";
        }

        public Department Get(string code)
        {
            string query = "SELECT * FROM department WHERE code = '" + code + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                Department aDepartment = new Department();
                aDepartment.Name = sqlDataReader[1].ToString();
                aDepartment.Code = sqlDataReader[2].ToString();
                sqlConnection.Close();
                return aDepartment;
            }

            sqlConnection.Close();
            return null;
        }

        public List<Department> GetAll()
        {
            string query = "SELECT * FROM department";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Department> departments = new List<Department>();
            while(sqlDataReader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = Convert.ToInt32(sqlDataReader[0]); 
                aDepartment.Name = sqlDataReader[1].ToString();
                aDepartment.Code = sqlDataReader[2].ToString();
                departments.Add(aDepartment);
                
            }

            sqlConnection.Close();
            return departments;
        }
    }
}
