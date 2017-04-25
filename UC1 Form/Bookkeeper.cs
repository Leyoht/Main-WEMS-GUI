using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Bookkeeper : Management, intBookkeeper
    {
        public List<Employee> employee = new List<Employee>();
        public List<Jobsite> jobsite = new List<Jobsite>();
        public Management management;

        public void modify_employee_info()
        {
            throw new System.NotImplementedException();
        }

        public void generate_eeoc_form()
        {
            throw new System.NotImplementedException();
        }

        public void calc_employee_payment()
        {
            throw new System.NotImplementedException();
        }

        public void confirm_payment()
        {
            throw new System.NotImplementedException();
        }

        public void addEmployee(string EmployeeID, string address, DateTime dob, string firstName, bool fromOutside, string gender, DateTime hireDate, bool isSupervisor, int lastName, bool minStatus, string phoNum)
        {
            Employee employee = new Employee();
            this.employee.Add(employee);
        }
        public List<Employee> getEmployee()
        {
            return this.employee;
        }

        public void addJobsite(string jobsiteID, string clientSupervisor, string supervisorID)
        {
            Jobsite jobsite = new Jobsite();
            this.jobsite.Add(jobsite);
        }
        public List<Jobsite> getJobsite()
        {
            return this.jobsite;
        }
    }
}