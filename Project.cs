using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMStep3
{
    class Project
    {
        public string projectName;
        public string projectDescription;

        public List<Employees> employeeToProject = new List<Employees>();
        public Project()
        {

        }

        public Project(string projectName, string projectDescription)
        {
            this.projectName = projectName;
            this.projectDescription = projectDescription;
        }

        public bool AddProject() //Add project Logic
        {
            projectName = Console.ReadLine();
            projectDescription = Console.ReadLine();

            if (projectName != null && projectDescription != null)
            {
                return true;
            }
            return false;

        }
        public bool ViewProjects() //view Project Logic
        {
            return true;

        }
        public List<Project> AllProjects() //Sample code for NUnit Testing
        {
            List<Project> p1 = new List<Project>();

            p1.Add(new Project { projectName = "Prolifics", projectDescription = "ProjectManagement" });

            return p1;
        }

        public void ViewProjectDetails() //view project details
        {

            for (int i = 0; i < employeeToProject.Count; i++)
            {
                Employees e = employeeToProject[i];
            }
        }

        public void DeleteEmployee(int employeeid) //Delete Employee from Project
        {

            for (int i = 0; i < employeeToProject.Count; i++)
            {
                Employees emp = employeeToProject[i];
                if (emp.empId == employeeid)
                {
                    employeeToProject.RemoveAt(i);
                    break;

                }
            }

        }
    }
}
