using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5033522
{
    class Customer
    {
        static int nextCustomerID = 1;
        private int customerID;
        private string firstName;
        private string phNumber;
        private string address;
        private bool staff;
        private List<Account> userAccounts;

        // customer class (not yet intergrated into prototype).
        public Customer()
        {
            customerID = nextCustomerID;
            nextCustomerID++;
            staff = false;
        }

        public Customer(string newFirstName, string newPhNumber, string newAddress, bool newStaff) : this()
        {
            firstName = newFirstName;
            phNumber = newPhNumber;
            address = newAddress;
            staff = newStaff;
        }

        public int CustomerID
        {
            get { return customerID; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string PhNumber
        {
            get { return phNumber; }
            set { phNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public bool Staff
        {
            get { return staff; }
            set
            {
                if (value == true || value == false) { staff = value; }
            }
        }

        public List<Account> Accounts
        {
            get { return userAccounts; }
            set { userAccounts = value; }
        }
    }
}
