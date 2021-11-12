using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMStep3
{
    internal class BusinessApproach
    {
        public static List<Project> projects = new List<Project>();

        public static List<Employees> employee = new List<Employees>();


        public void AddProjects() //Add projects
        {
            Project p1 = new Project();
            p1.AddProject();
            projects.Add(p1);
        }
        public void AddProjects(Project p)
        {
            projects.Add(p);
        }


        public void ViewProjects() //view projects
        {

            for (int i = 0; i < projects.Count; i++)
            {
                projects[i].ViewProjects();
            }
        }
        public bool ProjectName(string projectName)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projectName == projects[i].projectName)
                    return true;
            }

            return false;
        }

        public void AddEmployees() //Add employees
        {
            Employees emp = new Employees();
            emp.AddEmployee();
            employee.Add(emp);
        }
        public void AddEmployees(Employees emp)
        {
            employee.Add(emp);
        }

        public void ViewEmployees() //view employees
        {
            for (int j = 0; j < employee.Count; j++)
            {
                employee[j].ViewEmployees();
            }
        }


        public bool EmployeeId(int empId)
        {
            for (int j = 0; j < employee.Count; j++)
            {
                if (empId == employee[j].empId)
                    return true;
            }

            return false;
        }
        public void AddEmployeeToProject(string pname, int eid) //Add employees details to project
        {

            for (int j = 0; j < projects.Count; j++)
            {
                if (projects[j].projectName == pname)
                {
                    for (int k = 0; k < employee.Count; k++)
                    {
                        if (employee[k].empId == eid)
                        {
                            projects[j].employeeToProject.Add(employee[k]);
                            projects[j].ViewProjectDetails();
                        }
                    }
                }


            }
        }
        public bool EmployeeToProject(string pname, int employeeID) //view employee details in project
        {
            for (int j = 0; j < projects.Count; j++)
            {
                if (pname == projects[j].projectName)
                {
                    for (int k = 0; k < projects[j].employeeToProject.Count; k++)
                    {
                        if (projects[j].employeeToProject[k].empId == employeeID)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void DeleteEmployeeFromProject(String projectName, int employeeId) //delete operation
        {
            for (int j = 0; j < projects.Count; j++)
            {
                if (projects[j].projectName == projectName)
                {
                    projects[j].DeleteEmployee(employeeId); //remove employee details from project by using employee Id.
                    projects[j].ViewProjectDetails();//After removing employee details, we can see remaining employees details.
                }
            }
        }

    }
}
