// Grading ID: J2089
// Lab 3
// CIS 199-01
// Due Date: September 22, 2019
//This GUI app prompts the user for radius of a sphere and calculates
//the area, diameter and volume of the sphere then displays them
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class sphereForm : Form
    {
        public sphereForm()
        {
            InitializeComponent();
        }
        //  Calculates area diameter, and volume of a sphere
        private void CalcSphereBtn_Click(object sender, EventArgs e)
        {
            double radius; //This stores the radius that user enters
            radius = double.Parse(radiusTxt.Text); //It converts the entered value to double

            double diameter; //This stores the value of diameter 
            diameter = 2 * radius; // calculates diameter based on radius 

            double area; //this stoes the area of the sphere
            area = 4 * Math.PI * Math.Pow(radius, 2); // it calcules the area of the sphere

            double volume; // it stores the value of volume of the sphere
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3; //Calcules the volume of a sphere 

            outputLbl1.Text = $"{diameter:F2}"; //displays the diameter 
            outputLbl2.Text = $"{area:F2}"; // displays area
            outputLbl3.Text = $"{volume:F2}"; // displays volume




        }
    }
}
