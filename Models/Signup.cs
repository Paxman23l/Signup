using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OnCallSignup.Models
{
    public class Signup
    {
        public Signup() { }
        public Signup(DateTime date, string employeeId, string fName, string lName)
        {
            Date = date;
            EmployeeId = employeeId;
            FirstName = fName;
            LastName = lName;
        }
        
        
        public int Id { get; set; }
        [DisplayName(displayName:"Date")]
        public DateTime Date { get; set; }
        [DisplayName(displayName: "Employee Id")]
        public string EmployeeId { get; set; }
        [DisplayName(displayName: "First Name")]
        public string FirstName { get; set; }
        [DisplayName(displayName: "Last Name")]
        public string LastName { get; set; }

    }
}
