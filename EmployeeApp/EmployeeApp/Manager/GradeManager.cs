using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.DataAccess;
using EmployeeApp.Model;

namespace EmployeeApp.Manager
{
    class GradeManager
    {
        GradeGateway aGradeGateway = new GradeGateway();

        public string Save(Grade aGrade)
        {
            if (aGradeGateway.Get(aGrade.GradeLevel) != null)
            {
                return "Grade Level of this grade already exists in your system";
            }
            return aGradeGateway.Save(aGrade);
        }

        public List<Grade> GetAll()
        {
            return aGradeGateway.GetAll();
        }

        public decimal GetMedicalAmount(Grade aGrade)
        {
            return (aGrade.BasicAmt * aGrade.Medical) / 100;
        }

        public decimal GetHouseRent(Grade aGrade)
        {
            return (aGrade.BasicAmt * aGrade.HouseRent) / 100;
        }

        public decimal CalculateTotalSalary(Grade aGrade)
        {
            return (aGrade.BasicAmt + GetMedicalAmount(aGrade) + GetHouseRent(aGrade));
        }
    }
}
