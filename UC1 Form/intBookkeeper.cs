using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Form
{
    interface intBookkeeper
    {
        //the "add" functions need to be stated here before being put in the Bookkeeper class
        void addEmployee(string EmployeeID, string address, DateTime dob, string firstName, bool fromOutside, string gender, DateTime hireDate, bool isSupervisor, int lastName, bool minStatus, string phoNum);
        void addJobsite(string jobsiteID, string clientSupervisor, string supervisorID);
    }
}
