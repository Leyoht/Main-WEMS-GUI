using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Contract
    {
        private double contractID;
        private bool isState;
        private bool isAccepted;

        public double getContractID() { return contractID; }
        public void setContractID(double newContractID) { contractID = newContractID; }

        public bool getIsState() { return isState; }
        public void setIsState(bool newIsState) { isState = newIsState; }

        public bool getIsAccepted() { return isAccepted; }
        public void setIsAccepted(bool newIsAccepted) { isAccepted = newIsAccepted; }
    }
}