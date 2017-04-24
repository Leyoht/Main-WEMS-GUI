using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Client
    {
        public double clientID;
        public string companyName;
        public string phoNum;
        public string pointOfContact;

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