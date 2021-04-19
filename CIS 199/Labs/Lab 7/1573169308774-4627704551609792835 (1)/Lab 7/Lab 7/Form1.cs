// Grading ID: J2089
// CIS 199-01
// Lab 7
//Due Date: Nov 10, 2019
// This GUI prompts users for future value, interest rate, no.of year and present value and displays present value.   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         // Precondition: futrValue>=0, rate>=0, year>=0
         //Postcondition: calls calculates the present value and dispalys 
         // This click event calls the  CalcPresentValue method and displays present value 
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double futrValue; // holds user input for future value
            double rate;      // holds user input for interest rate
            int year;         // holds user input dor no. of year
            double presentVal = 0; // present value for calculation
            if (double.TryParse(futrTxt.Text, out futrValue) && (futrValue >= 0)) // converting user input to double and validing that user only enters valid input
            {
                if (double.TryParse(interestTxt.Text, out rate) && (rate >= 0))  // converting user input to double and validing that user only enters valid input /
                {
                    if (int.TryParse(yearTxt.Text, out year) && (year >= 0))  //converting user input to int and validing that user only enters valid input //
                    {

                        presentVal = CalcPresentValue(futrValue, rate, year); // called method with argument future value, interest, and no. of year
                        outputLbl.Text = ($"{presentVal:C}");                // displays the calculated present value 

                    }
                    else
                        MessageBox.Show("Enter a valid year!");  // alerts user for invalid input

                }
                else
                    MessageBox.Show("Enter a valid interest rate!"); // alerts user for invalid input

            }
            else
                MessageBox.Show("Enter a valid future value!");     // alerts user for invalid input
        }
        // Precondition: future>=0, interstrate>=0, year>=0
        // Postcondition: calcultes present value and returns it
        public static double CalcPresentValue(double futurVal, double interestRate, int year) // value returning method
        {
            double presentVal = futurVal / Math.Pow((1 + interestRate), year); // calculates the present value 
            return presentVal; // returns present value
        }
    }
}
