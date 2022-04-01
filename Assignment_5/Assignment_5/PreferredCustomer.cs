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
    class PreferredCustomer : Customer 
    {
        private double cumulativePurchase = 0.0; 

        public PreferredCustomer(string name, string address, string telephoneNum, string customerNum, bool isOnMailList, double cumulativePurchase)
            : base (name, address, telephoneNum, customerNum, isOnMailList)
        {
            this.cumulativePurchase = cumulativePurchase; 
        }
        
        public double get_cumulativePurchase()
        {
            return cumulativePurchase; 
        }
        public void set_cumulativePurchase(double cumulativePurchase)
        {
            this.cumulativePurchase = cumulativePurchase; 
        }     
        
        public double discountLevel()
        {
            double discountLevel = 0.0; 
            if(cumulativePurchase >= 2000)
            {
                discountLevel = 0.1; 
            } else if (cumulativePurchase >= 1500)
            {
                discountLevel = 0.07; 
            } else if (cumulativePurchase >= 1000)
            {
                discountLevel = 0.06;
            } else if (cumulativePurchase >= 500)
            {
                discountLevel = 0.05; 
            } else
            {
                discountLevel = 0.0; 
            }

            return discountLevel; 
        }

    }
}
