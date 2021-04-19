//Grading ID: J2089
//CIS 199-01
//Program 2
//Due Date: October 17, 2019
//This GUI caculates and displays earliest registration date & time based credit hrs completed and first letter of last name

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program_2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        //This event handler displays earliest date&time to register for classes based on hrs completed and last name 1st letter
        private void CheckBtn_Click(object sender, EventArgs e)

        {
            double creditHour;  //holds user input for credit hours 
            char firstLtrLastNa; // holds user input for 1st letter last name
            const double SENIOR_HOUR = 90; // named constant for 90 credit hours or more
            const double JUNIOR_HOUR = 60; // named constant for 60 credit hours or more
            const double SOPHOMORE_HOUR = 30; //named constant for 30 credit hours or more
            const double FRESHMAN_HOUR = 0;  //named constant for less than 30 credit hours
            const string TIME_SLOT1 = "8:30 A.M."; // holds time 8:30 A.M.
            const string TIME_SLOT2 = "10:00 A.M."; //holds time 10:00 A.M.
            const string TIME_SLOT3 = "11:30 A.M."; //holds time 11:30 A.M.
            const string TIME_SLOT4 = "2:00 P.M.";  //holds time 2:00 A.M.
            const string TIME_SLOT5 = "4:00 P.M.";   // holds time 4:00 A.M.
            const string REG_DAY1 = "MONDAY, NOV. 4";  //holds day1, Nov 4th.
            const string REG_DAY2 = "TUESDAY, NOV. 5";  //holds day2, Nov 5th
            const string REG_DAY3 = "WEDNESDAY, NOV. 6"; //holds day3, Nov 6th
            const string REG_DAY4 = "THURSDAY, NOV. 7";  //holds day4, Nov 7th
            const string REG_DAY5 = "FRIDAY, NOV. 8";   //holds day5, Nov 8th
            const string REG_DAY6 = "MONDAY, NOV. 11";  ///holds day6, Nov 11th
            string day = "Error"; // holds days
            string time = "Error"; // time

            //converts user input and validating from the text boxes
            if (double.TryParse(creditHourTxt.Text, out creditHour) && creditHour >= 0)
            {   // converts user input to char and validates 
                if (char.TryParse((lastNameTxt.Text), out firstLtrLastNa) && Char.IsLetter(firstLtrLastNa)) 

                {
                    firstLtrLastNa = char.ToUpper(firstLtrLastNa);
                    if (creditHour >= JUNIOR_HOUR)
                    {

                        if (creditHour >= SENIOR_HOUR)
                        {
                            day = REG_DAY1;
                        }
                        else
                        {
                            day = REG_DAY2;
                        }
                        if (firstLtrLastNa <= 'D')
                        {
                            time = TIME_SLOT3;
                        }
                        else if (firstLtrLastNa <= 'I')
                        {
                            time = TIME_SLOT4;
                        }
                        else if (firstLtrLastNa <= 'O')
                        {
                            time = TIME_SLOT5;
                        }
                        else if (firstLtrLastNa <= 'S')
                        {
                            time = TIME_SLOT1;
                        }
                        else
                        {
                            time = TIME_SLOT2;
                        }
                    }
                    else // sophomore or freshman
                    {
                        if (creditHour >= SOPHOMORE_HOUR) // Sophomore Students }
                        {
                            if ((firstLtrLastNa >= 'P') || (firstLtrLastNa <= 'B'))
                            {
                                day = REG_DAY3;
                            }
                            else
                            {
                                day = REG_DAY4;
                            }
                        }
                        else // must be freshman
                        {
                            if ((firstLtrLastNa >= 'P') || (firstLtrLastNa <= 'B'))
                            {
                                day = REG_DAY5;
                            }
                            else
                            {
                                day = REG_DAY6;
                            }
                        }
                        if (firstLtrLastNa <= 'B')
                        {
                            time = TIME_SLOT5;
                        }
                        else if (firstLtrLastNa <= 'D')
                        {
                            time = TIME_SLOT1;
                        }
                        else if (firstLtrLastNa <= 'F')
                        {
                            time = TIME_SLOT2;
                        }
                        else if (firstLtrLastNa <= 'I')
                        {
                            time = TIME_SLOT3;
                        }
                        else if (firstLtrLastNa <= 'L')
                        {
                            time = TIME_SLOT4;
                        }
                        else if (firstLtrLastNa <= 'O')
                        {
                            time = TIME_SLOT5;
                        }
                        else if (firstLtrLastNa <= 'Q')
                        {
                            time = TIME_SLOT1;
                        }
                        else if (firstLtrLastNa <= 'S')
                        {
                            time = TIME_SLOT2;
                        }
                        else if (firstLtrLastNa <= 'V')
                        {
                            time = TIME_SLOT3;
                        }
                        else
                        {
                            time = TIME_SLOT4;
                        }
                    }
                    registOutputLbl.Text = ($"{day}, {time}");
                }
                else // displays alert for any invalid user input
                    MessageBox.Show("Enter a valid input. Accepts only letters!");
            }
            else //  displays alert for any invalid user input
                MessageBox.Show("Enter a valid credit hour!");
        }
    }
}

