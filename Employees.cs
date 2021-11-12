using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMStep3
{
    class Employees
    {
        public int empId, phone;
        string firstName, lastName, dept, email;
        public Employees(int empId, int Phone, string FirstName, string LastName, string Dept, string Email) //constructor with arguments.
        {
            this.empId = empId;
            this.phone = Phone;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dept = Dept;
            this.email = Email;
        }
        public Employees() //default constructor
        {
        }
        public bool AddEmployees() //add employee details to list by taking input from user.
        {
            empId = Convert.ToInt32(Console.ReadLine());
            phone = Convert.ToInt32(Console.ReadLine());
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            dept = Console.ReadLine();
            email = Console.ReadLine();

            if (empId != 0 && phone != 0 && firstName != "" && lastName != "" && dept != "" && email != "")
            {
                return true;
            }
            return false;
        }

        public bool ViewEmployees() //view employee details present in list.
        {
            return true;
        }

        public List<Employees> AddEmployee() // created list, added inputs.
        {
            List<Employees> emp = new List<Employees>();

            emp.Add(new Employees { empId = 4738, firstName = "Rushi", lastName = "kumar", dept = "se", phone = 779916321, email = "rushikumar02@gmail.com" });

            return emp;
        }


    }

}

