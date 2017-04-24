using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC1_Form
{
    public class Program
    {
        public List<Employee> employee = new List<Employee>();
        public List<Jobsite> jobsite = new List<Jobsite>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Arrays
    {

        public List<Employee> employee = new List<Employee>();
        public List<Jobsite> jobsite = new List<Jobsite>();




        public void addEmployee(string EmployeeID, string address, DateTime dob, string firstName, bool fromOutside, string gender, DateTime hireDate, bool isSupervisor, int lastName, bool minStatus, string phoNum)
        {

            Employee employee = new Employee();
            this.employee.Add(employee);
        }
        public List<Employee> getEmployee()
        {
            return this.employee;
        }


        public void addJobSite(string supervisorID, string jobsiteID, string clientSupervisor)
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
