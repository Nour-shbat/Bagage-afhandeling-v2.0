using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Employee
    {
        public int Employee_ID { get; private set; }
        public string PassWord { get; private set; } //beveiliging issues?
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Role { get; private set; }

        public Employee(int employeeId,string passWord, string firstName, string lastName, string role)
        {
            Employee_ID = employeeId;
            PassWord = passWord;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public void ChechInBaggage(Baggage baggage) { }
        public void OverrideBaggageStatus() { }
    }
}
