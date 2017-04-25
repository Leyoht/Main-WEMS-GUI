using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Client
    {
        private double clientID;
        private string companyName;
        private string phoNum;
        private string pointOfContact;

        public Contract Contract
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Jobsite Jobsite
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double getClientID() { return clientID; }
        public void setClientID(double newClientID) { clientID = newClientID; }

        public string getCompanyName() { return companyName; }
        public void setCompanyName(string newCompanyName) { companyName = newCompanyName; }

        public string getPhoNum() { return phoNum; }
        public void setPhoNum(string newPhoNum) { phoNum = newPhoNum; }

        public string getPointOfContact() { return pointOfContact; }
        public void setPointOfContact(string newPointOfContact) { pointOfContact = newPointOfContact; }

        public void submits_bidded_contract()
        {
            throw new System.NotImplementedException();
        }
    }
}