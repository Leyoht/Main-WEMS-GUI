using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Management : Employee
    {
        /// <summary>
        /// Office location
        /// </summary>
        private string offLocation;
        /// <summary>
        /// Office phone number
        /// </summary>
        private string offPhone;

        public void add_site_supervisor()
        {
            throw new System.NotImplementedException();
        }

        public void create_contract_bid()
        {
            throw new System.NotImplementedException();
        }

        public void create_supplier_purchase_request()
        {
            throw new System.NotImplementedException();
        }


        public string getOffLocation() { return offLocation; }
        public void setOffLocation(string newOffLocation) { offLocation = newOffLocation; }

        public string getOffPhone() { return offPhone; }
        public void setOffPhone(string newOffPhone) { offPhone = newOffPhone; }
    }
}