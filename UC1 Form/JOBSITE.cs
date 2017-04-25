using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Jobsite
    {
        public string jobsiteID;
        public string clientSupervsior;
        private string supervisorID;

        public string getJobSiteID() { return jobsiteID; }
        public void setJobSiteID(string newJobSiteID) { jobsiteID = newJobSiteID; }

        public string getClientSupervisor() { return clientSupervsior; }
        public void setClientSupervisor(string newClientSupervisor) { clientSupervsior = newClientSupervisor; }

        public string getSupervisorID() { return supervisorID; }
        public void setSupervisorID(string newSupervisorID) { supervisorID = newSupervisorID; }
    }
}