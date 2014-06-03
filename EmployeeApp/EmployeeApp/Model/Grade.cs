using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp.Model
{
    class Grade
    {
        public int Id { set; get; }
        public string GradeLevel { set; get; }
        public decimal BasicAmt { set; get; }
        public decimal Medical { set; get; }
        public decimal HouseRent { set; get; }
    }
}
