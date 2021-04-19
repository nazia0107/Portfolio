//Grading ID: J2089
//CIS 199-01
//Dr. Wright
//Program 1
//Due Date: September 24, 2019
//This GUI prompts user for lenghths,heights,doors,windows, and coats then estimates number of gallons to buy
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Progran1 : Form
    {
        public Progran1()
        {
            InitializeComponent();
        }
        //Calculates and displays number of gallons to buy
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double totalHeight; // total height
            double totalLength; // total length
            double paintArea; // calculated total paint area
            double grossArea; // calculated gross area
            double minGallons; // minimum gallons to buy
            uint door; // number of door
            uint window; // number window
            uint numOfCoat; // number of coats
            uint gallonsToBuy; // gallons to buy

            const uint DOOR_AREA = 21; // named constant for door area
            const uint WINDOW_AREA = 12; // named constant for window area
            const uint COAT_AREA = 400; // named constant for coat area
            
            //convert the user inputs to double
            totalHeight = double.Parse(heightTxt.Text);
            totalLength = double.Parse(lengthText.Text);
            
            //convert user inputs to non-neg integer
            door = uint.Parse(doorTxt.Text);
            window = uint.Parse(windowTxt.Text);
            numOfCoat = uint.Parse(coatTxt.Text);




            grossArea = totalLength * totalHeight; // calculates the gross area of the room
            paintArea = (grossArea - door * DOOR_AREA - window * WINDOW_AREA) * numOfCoat; // calculates the paint area 

            minGallons = paintArea / COAT_AREA; // calcultes the minimum gallons to buy

            gallonsToBuy = (uint)Math.Ceiling(minGallons); // calculates the gallons to buy

            //Display the calculted output
            outputLbl.Text = $"You will need a minimun of  {minGallons:F1} gallons of paint" +
               
                $"\nYou'll need to buy {gallonsToBuy} gallons, though!";



        
           

            
           


            



        }
    }
}
