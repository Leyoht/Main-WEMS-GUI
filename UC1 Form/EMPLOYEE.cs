﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UC1_Form
{
    public class Employee
    {
        private string address;
        private DateTime dob;
        private string firstName;
        private bool fromOutside;
        private string gender;
        private DateTime hireDate;
        private bool isSupervisor;
        private string lastName;
        private bool minStatus;
        private string phoNum;
        private string EmployeeID;
        private string MI;


        public string getAddress() { return address; }
        public void setAddress(string newAddress) { address = newAddress; }

        public DateTime getDOB() { return dob; }
        public void setDOB(DateTime newDOB) { dob = newDOB; }

        public string getEmployeeID() { return EmployeeID; }
        public void setEmployeeID(string newEmployeeID) { EmployeeID = newEmployeeID; }

        public string getFirstName() { return firstName; }
        public void setFirstName(string newFirstName) { firstName = newFirstName; }

        public string getLastName() { return lastName; }
        public void setLastName(string newLastName) { lastName = newLastName; }

        public string getMI() { return MI; }
        public void setMI(string newMI) { MI = newMI; }

        public bool getOutside() { return fromOutside; }
        public void setOutside(bool newOutside) { fromOutside = newOutside; }

        public string getGender() { return gender; }
        public void setGender(string newGender) { gender = newGender; }

        public DateTime getHireDate() { return hireDate; }
        public void setHireDate(DateTime newHireDate) { hireDate = newHireDate; }

        public bool getSupervisor() { return isSupervisor; }
        public void setSupervisor(bool newSupervisor) { isSupervisor = newSupervisor; }

        public bool getStatus() { return minStatus; }
        public void setStatus(bool newStatus) { minStatus = newStatus; }

        public string getPhoNum() { return phoNum; }
        public void setPhoNum(string newPhoNum) { phoNum = newPhoNum; }

        public void access_personal_info()
        {
            throw new System.NotImplementedException();
        }

        public void access_job_info()
        {
            throw new System.NotImplementedException();
        }

        public void access_job_assign()
        {
            throw new System.NotImplementedException();
        }

        public void clockIn()
        {
            throw new System.NotImplementedException();
        }

        public void clockOut()
        {
            throw new System.NotImplementedException();
        }

        public void create_time_report()
        {
            throw new System.NotImplementedException();
        }

        public void authenticate()
        {
            throw new System.NotImplementedException();
        }
    }
}