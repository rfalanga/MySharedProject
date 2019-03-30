using System;
using System.Collections.Generic;
using System.Text;

namespace MySharedProject
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        //Methods
        public string GetEmployeeDetail()
        {
            EmployeeID = 247;
            FirstName = "Ved";
            LastName = "Prakasj";
            Phone = "5055551234";
            Address = "Albuquerque, New Mexico";

            return string.Concat($"Name: {FirstName} {LastName}\nEmp ID: {EmployeeID}\nAddress: {Address}\nPhone: {Phone}");
        }
    }
}
