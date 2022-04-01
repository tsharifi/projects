/*
 * Student Name: Moein Sharifi Moghaddam
 * Student Number: T00665076
 * Assignment 4
 * COMP 2211
 * This programs allows user to select a number of randomly generated numbers a file can 
 * save or open. 
 * 
 * source I used to learn about environment.newline property 
 * https://stackoverflow.com/questions/1015766/difference-between-n-and-environment-newline
 * 
 * Learned about .lines property and how to search through multiline textbox line by line in link below
 * https://stackoverflow.com/questions/16155831/read-each-line-of-2-multiline-text-box
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
using System.IO; 

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showTotal();
        }

        private void numRandBTN_Click(object sender, EventArgs e)
        {
            try { 
                // throw exception if number entered by user is not integer
                int numOfRand = 0; 
                if (int.TryParse(numRandTBX.Text, out numOfRand))
                {
                    numOfRand = int.Parse(numRandTBX.Text);
                } else
                {
                    MessageBox.Show("You Did not Enter a Valid Number");
                }

                // check number if is in range entered by user
                bool inRange = numOfRand <= 250 && numOfRand >= 1;
                if (!inRange)
                {
                    MessageBox.Show("Number Entered is Not in Range 1-250");
                    return; 
                }
                dataTBX.Text = "";
                Random rand = new Random();
                int temp = 0;
                // generate random number and output it to the data textbox
                for (int i = 0; i < numOfRand; i++)
                {
                    temp = rand.Next(100) + 1;
                    dataTBX.Text += temp.ToString() + Environment.NewLine;
                }
                // updates and print total number of generated random number and their sum
                showTotal();
            } catch
            {
                MessageBox.Show("Error Has Occured"); 
            }
        }

        // save the data of randon number 
        private void writeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter fileWriter;
                    fileWriter = File.CreateText(saveFileDialog.FileName);
                    foreach (char charecter in dataTBX.Text)
                    {
                        fileWriter.Write(charecter);
                    }
                    fileWriter.Close();
                }
                showTotal();
            } catch
            {
                MessageBox.Show("An Error in Writing Occured"); 
            }
        }

        // reads selected text file and output in into data textbox
        private void ReadBTN_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader fileReader;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataTBX.Text = "";
                    fileReader = File.OpenText(openFileDialog.FileName);
                    dataTBX.Text = fileReader.ReadToEnd();
                    fileReader.Close();
                }
                showTotal();
            } catch
            {
                MessageBox.Show("An Error in Opening Occured"); 
            }
        }

        //calculate and print total number of randomly generated numbers and their sum
        private void showTotal()
        {
            int count = 0;
            int sum = 0;
            int temp; 
            foreach (string str in dataTBX.Lines)
            {
                if(int.TryParse(str, out temp))
                {
                    count++; 
                    sum += temp; 
                }
                
            }
            SumLBL.Text = "Sum of All Random Numbers is:     " + sum.ToString();
            totalRandNumLBL.Text = "Total Counted Number of Random NUmbers is:     " + count.ToString();
        }

        // Accidentally double clicked on even handler. the function is unused
        private void totalRandNumLBL_Click(object sender, EventArgs e)
        {

        }
        // Accidentally double clicked on even handler.the function is unused
        private void numRandTBX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
