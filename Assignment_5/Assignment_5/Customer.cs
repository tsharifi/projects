// Moein Sharifi Moghaddam
// Assignment 5
// Computing 2211
// T00665076

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Customer : Person
    {
        private string customerNum = "";
        private bool isOnMailList = false;

        public Customer(string name, string address, string telephoneNum, string customerNum, bool isOnMailList)
            : base(name, address, telephoneNum)
        {
            this.customerNum = customerNum; 
            this.isOnMailList = isOnMailList; 
        }

        public string get_customerNum()
        {
            return customerNum; 
        }
        public void set_customerNum(string customerNum)
        {
            this.customerNum = customerNum; 
        }

        public bool get_isOnMailList()
        {
            return isOnMailList; 
        }
        public void set_isOnMailList(bool isOnMailList)
        {
            this.isOnMailList = isOnMailList; 
        }

    }
}
