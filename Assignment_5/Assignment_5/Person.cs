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
    public class Person
    {
        private string name = "";
        private string address = "";
        private string telephoneNum = "";

        public Person(string name, string address, string telephoneNum)
        {
            this.name = name;
            this.address = address;
            this.telephoneNum = telephoneNum; 
        }

        public string get_name()
        {
            return name;
        }
        public void set_name(string name)
        {
            this.name = name; 
        }

        public string get_address()
        {
            return address; 
        }
        public void set_address(string address)
        {
            this.address = address; 
        }

        public string get_telephoneNum()
        {
            return telephoneNum; 
        }
        public void set_telephonNum(string telephoneNum)
        {
            this.telephoneNum = telephoneNum; 
        }

    }
}
