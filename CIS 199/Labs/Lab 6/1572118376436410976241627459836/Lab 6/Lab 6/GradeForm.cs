// Grading ID: J2089
// CIS 199-01
// Lab 6
//Due Date: October 27, 2019
// This GUI prompts users for words typed and displays letter grade based on number of words typed
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This event handler displays the letter grade for words typed
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int numofWords; // holds user input for number of words typed
            int[] wordRangeLowLimits = { 0, 16, 31, 51, 76 }; // holds lower range limits for the word counts 
            char[] letterGrades = { 'F', 'D', 'C', 'B', 'A' }; // holds Letter gardes from F to A
            char grade = 'F'; // assume garde as F
            bool found = false; // assume not found

            if (int.TryParse(wordTxt.Text, out numofWords) && (numofWords >=0)) // validating user input and converting it from string to integer 
            {
                int x = wordRangeLowLimits.Length - 1; // setting x to end position of the array, which is length of the array-1
                while (x >= 0 && !found) // searches through first position and it is not found 
                {
                    if (numofWords >= wordRangeLowLimits[x]) // when the entered number of words are >= to the lower limits  
                    
                        found = true; // it is true 
                    else
                        x--; //keeps looking until >=0
                }
                if (found) // when it is found
                    grade = letterGrades[x];
                outputLbl.Text = ($" Your grade is {grade}"); // displays the grade using the 
            }
            else // if user enters anything less than 0, it will tell the user it's an invalid input
            MessageBox.Show("Enter a vallid input!");

            


        }
    }
}
