using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EmployeeApp.Model;

namespace EmployeeApp.DataAccess
{
    class GradeGateway
    {
        private string connectionString = null;
        //Grade aGrade = new Grade();

        public GradeGateway()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Grade aGrade)
        {
            string query = "INSERT INTO Grade(GradeLevel, Basic, Medical, HouseRent)" +
                           " VALUES ('" + aGrade.GradeLevel + "'," + aGrade.BasicAmt + "," +
                           aGrade.Medical + "," + aGrade.HouseRent + ")";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Grade saved";
        }

        public Grade Get(string GradeLevel)
        {
            string query = "SELECT * FROM grade WHERE GradeLevel = '" + GradeLevel + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                Grade aGrade = new Grade();
                aGrade.GradeLevel = sqlDataReader[1].ToString();
                aGrade.BasicAmt =Convert.ToDecimal(sqlDataReader[2]);
                aGrade.Medical = Convert.ToDecimal(sqlDataReader[3]);
                aGrade.HouseRent = Convert.ToDecimal(sqlDataReader[4]);
                sqlConnection.Close();
                return aGrade;
            }

            sqlConnection.Close();
            return null;
        }

        public List<Grade> GetAll()
        {
            string query = "SELECT * FROM grade";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Grade> grades = new List<Grade>();
            while (sqlDataReader.Read())
            {
                Grade aGrade = new Grade();
                aGrade.Id = Convert.ToInt32(sqlDataReader[0]);
                aGrade.GradeLevel = sqlDataReader[1].ToString();
                aGrade.BasicAmt = Convert.ToDecimal(sqlDataReader[2]);
                aGrade.Medical = Convert.ToDecimal(sqlDataReader[3]);
                aGrade.HouseRent = Convert.ToDecimal(sqlDataReader[4]);
                grades.Add(aGrade);
            }

            sqlConnection.Close();
            return grades;
        }

    }
}
