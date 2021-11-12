using NUnit.Framework;
using System.Collections.Generic;

namespace PPMStep3
{
    public class Tests
    { 
        List<Project> p2 = new List<Project>();
        List<Employees> employees = new List<Employees>();

        BusinessApproach program = new BusinessApproach();


        public string projectName { get; private set; }
        public string projectDescription { get; private set; }

        [SetUp]
        public void Setup()
        {


            Project p = new Project();
            p2 = p.AllProjects();

            Employees emp1 = new Employees();

            employees = emp1.AddEmployee();
        }

        //Sample test cases 
        [Test]
        public void Test1()
        {
            foreach (Project p in p2)
            {

                Assert.False(Equals("Prolific", p.projectName));
            }
        }
        [Test]
        public void Test2()
        {
            foreach (Project p3 in p2)
            {

                Assert.AreEqual("Prolifics", p3.projectName);

            }
        }
        [Test]
        public void Test3()
        {
            foreach (Project p3 in p2)
            {
                Assert.AreNotEqual("Prolific", p3.projectName);
            }

        }
        [Test]
        public void Test4()
        {
            foreach (Employees emp2 in employees)
            {

                Assert.AreEqual(4738, emp2.empId);
            }
        }
        [TestCase]
        public void Test5()
        {
            foreach (Employees emp in employees)
            {
                Assert.GreaterOrEqual(4738, emp.empId);
            }
        }
        [TestCase]
        public void Test6()
        {
            foreach (Project p in p2)
            {
                Assert.AreNotSame(p, p); //both objects are same so test case failed.
            }
        }
        [TestCase]
        public void Test7()
        {
            foreach (Employees emp1 in employees)
            {
                Assert.AreSame(emp1, emp1);
            }
        }
        [TestCase]
        public void Test8()
        {
            Assert.IsEmpty(employees); //employee list contains data so test case failed.
        }
        [TestCase]
        public void Test9()
        {
            Assert.IsNotEmpty(employees);
        }

        [Test]
        public void ProjectTest()
        {
            Project p = new Project(" Management", "manage");

            program.AddProjects(p);

            Assert.AreEqual(true, program.ProjectName(" Management"));
            Assert.AreEqual(" Management", p.projectName);
            Assert.AreEqual("manage", p.projectDescription);
        }

        [Test]
        public void EmployeeTest()
        {
            Employees emp = new Employees(0, 77991632, "rushi", "kumar", "se", "rushi@gmail.com");

            program.AddEmployees(emp);

            Assert.AreEqual(0, emp.empId);
            Assert.AreEqual(true, program.EmployeeId(4738)); //employee id is not exist in employee list
        }

        [TestCase]
        public void AddEmployeeToProjectTest()
        {
            Project p = new Project(" Management", "manage");
            Project p2 = new Project("rushi", "kumar");
            Employees emp = new Employees(4738, 77991632, "rushikumar", "margani", "se", "rushi02@gmail.com");
            Employees emp1 = new Employees(4777, 63018480, "mohankrishna", "margani", "se", "mohankrishna");

            program.AddProjects(p2);
            program.AddEmployees(emp1);

            program.AddEmployeeToProject(" Management", 4738);
            program.AddEmployeeToProject("rushi", 4777);

            Assert.AreEqual(true, program.EmployeeToProject("rushi", 4777));
        }


    }
}

