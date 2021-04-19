//Grading ID: J2089
//CIS 199:01
//Lab 2
// This GUI calculates tip for meal price
//Due: September 15, 2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This click event is to calculate the tip
        private void CalcTipBtn_Click(object sender, EventArgs e)
        {
            const double TIP_RATE1 = 0.15; // This named constant is for 15% tip
            const double TIP_RATE2 = 0.18; // This named constant is for 18% tip
            const double TIP_RATE3 = 0.20; // This named constant is for 20% tip

            double mealPrice; //This variable stores meal price
            mealPrice = double.Parse(mealPriceTxt.Text);

            double tipOne; //it is to store small tip
            double tipTwo; // it is to store medium tip
            double tipThree; // it is to store large tip

            tipOne = mealPrice * TIP_RATE1;
            tipTwo = mealPrice * TIP_RATE2;
            tipThree = mealPrice * TIP_RATE3;

            outputLbl1.Text = $"{tipOne:C2}";
            outputLbl2.Text = $"{tipTwo:C2}";
            outputLbl3.Text = $"{tipThree:C2}";



        }
    }
}
