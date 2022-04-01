// Moein Sharifi Moghaddam
// Assignment 5
// Computing 2211
// T00665076

/* For clarity I made the following assumption: 
 * A person can have multiple accounts. Only first name and customer number is used to diferentiate between customer accounts. 
 * Telephone number should be 10 degits only. Assumed it is a local business in lower mainland. 
 * Name represents first name and cannot contain space in between else it will give error
 * For simplicity, didn't put restriction on how address is entered but it should match what is recorded already. 
 * A customer number may belong to more than one account. each account are differenciated by their name
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        List<PreferredCustomer> customerList = new List<PreferredCustomer>();
        PreferredCustomer customer; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // accidental click that created event
        private void label5_Click(object sender, EventArgs e)
        {

        }

        // accidental click that created event
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // accidental click that created event
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // accidenta click
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdressTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelephonNumTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SummaryTbx.Text = "";
                string name = "";
                // checks if a name is entered correctly
                if (NameTbx.Text == "")
                {
                    NameErrorLbl.Text = "Please Enter a Name";
                }
                else if (!isAllLetter(NameTbx.Text))
                {
                    NameErrorLbl.Text = "Enter Alphabets Only";
                }
                else
                {
                    NameErrorLbl.Text = "";
                    name = NameTbx.Text;
                }

                // checks if address is correct
                // Since this is a simple application, I didn't check specificly for postal code, house number, street, country and exetera. 
                string address = "";
                if (AddressTbx.Text == "")
                {
                    AddressErrorLbl.Text = "Enter an Address";
                }
                else
                {
                    AddressErrorLbl.Text = "";
                    address = AddressTbx.Text;
                }


                int checkIfInt;
                String telephonNum = "";
                // checks if telephone number is correct
                // all should be degits of size 10 only
                // assumes it is a local business in vancouver
                if (TelephonNumTbx.Text == "")
                {
                    TelephoneErrorLbl.Text = "Enter a Telephone Number";
                }
                else if (!isAllDegit(TelephonNumTbx.Text))
                {
                    TelephoneErrorLbl.Text = "Enter Valid Number";
                }
                else if (TelephonNumTbx.Text.Length != 10)
                {
                    TelephoneErrorLbl.Text = "Number Should Have 10 Degits";
                }
                else
                {
                    TelephoneErrorLbl.Text = "";
                    telephonNum = TelephonNumTbx.Text;
                }

                string customerNum = "";
                //checks if Customer number is correct. All should be degits
                if (!isAllDegit(CustomerNumTbx.Text) || CustomerNumTbx.Text == "")
                {
                    CustomerNumErrorLbl.Text = "Enter a Valid Customer Number";
                }
                else
                {
                    CustomerNumErrorLbl.Text = "";
                    customerNum = CustomerNumTbx.Text;
                }

                // checks if Cumulative purchase ammount is valid
                double CumulativePurchase;
                if (!double.TryParse(CumulativePurchaseTbx.Text, out CumulativePurchase))
                {
                    CumulativePurchaseErrorLbl.Text = "Should Contain Degits Only";
                }
                else
                {
                    CumulativePurchaseErrorLbl.Text = "";
                    CumulativePurchase = double.Parse(CumulativePurchaseTbx.Text);
                }

                // cheks value if customer wants to be on mailing list. 
                bool onMailList;
                if (OnMailListCbx.Checked == true)
                {
                    onMailList = true;
                }
                else
                {
                    onMailList = false;
                }

                // checks if conditions are valid, creates a PreferredCustomer object
                // update customer info if already exist else it would create a new customer
                if (NameErrorLbl.Text == "" && AddressErrorLbl.Text == "" && TelephoneErrorLbl.Text == "" &&
                    CustomerNumErrorLbl.Text == "" && CumulativePurchaseErrorLbl.Text == "" && NameTbx.Text.Length > 0
                    && AddressTbx.Text.Length > 0 && TelephonNumTbx.Text.Length > 0 && CustomerNumTbx.Text.Length > 0
                    && CumulativePurchaseTbx.Text.Length > 0)
                {
                    customer = new PreferredCustomer(name, address, telephonNum, customerNum, onMailList, CumulativePurchase);

                    if (customerExist(customer))
                    {
                        updateAccount(customer);
                        MessageBox.Show("Customer Info Successfully was Updated");
                        customerSummary();
                    }
                    else
                    {
                        customerList.Add(customer);
                        MessageBox.Show("Customer Successfully was Added");
                        customerSummary();
                    }
                }
                else
                {
                    MessageBox.Show("There is an Error in Customer Information Entered");
                }

                SummaryTbx.Text += "Number of Customers in database is: " + customerList.Count.ToString() + Environment.NewLine;

            } catch
            {
                MessageBox.Show("EXCEPTION: An Error Occured"); 
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CustomerNumLbl_Click(object sender, EventArgs e)
        {

        }

        // checks if variable of data type string only contains letters
        // https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp/1181426
        private bool isAllLetter(string data)
        {
            bool result = true; 
            foreach (char a in data)
            {
                if(Char.IsLetter(a) == false)
                {
                    result = false; 
                    return result; 
                }
            }
            return result; 
        }

        // check if data string is all degits
        private bool isAllDegit(string data)
        {
            bool result = true; 
            foreach(char a in data)
            {
                if(Char.IsDigit(a) == false)
                {
                    result = false;
                    return result; 
                }
            }
            return result; 
        }

        // check if customer prfile already exist
        private bool customerExist(PreferredCustomer customer)
        {
            foreach(PreferredCustomer a in customerList)
            {
                if(a.get_name() == customer.get_name() && a.get_customerNum() == customer.get_customerNum())
                {
                    return true; 
                }

            }
            return false; 
        }

        // updates customer acount info
        private void updateAccount (PreferredCustomer customer)
        {
            int count = 0; 
            foreach (PreferredCustomer a in customerList)
            {
                if (a.get_name() == customer.get_name() && a.get_customerNum() == customer.get_customerNum())
                {
                    customerList[count] = customer; 
                    break; 
                }
                count++;
            }  
        }

        // prints a comprehensive summary of customer's account info onto the summary text box. 
        private void customerSummary()
        {
            SummaryTbx.Text += "Customer's name is: " + customer.get_name() + Environment.NewLine;
            SummaryTbx.Text += "Customer's Address is: " + customer.get_address() + Environment.NewLine;
            SummaryTbx.Text += "Customer's Telephone Number is: " + customer.get_telephoneNum() + Environment.NewLine;
            SummaryTbx.Text += "Customer's Number is: " + customer.get_customerNum() + Environment.NewLine;
            SummaryTbx.Text += "Customer's Cumulative Purchase is: " + customer.get_cumulativePurchase().ToString() + Environment.NewLine;
            SummaryTbx.Text += "Customer is on Mail List: " + customer.get_isOnMailList() + Environment.NewLine;
            SummaryTbx.Text += "Customer's Discount rate is: " + customer.discountLevel().ToString() + Environment.NewLine;
        }
    }
}
 