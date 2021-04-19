//Grading ID: T6278
//CIS 200-01
//Program 2
//Due Date: 3/8/2020
//This form allows the user to select an items to reutrn to the Library.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class ReturnForm : Form
    {
        internal List<LibraryItem> _items;
        const int MIN_VAL = 0; //Named constant for minimmum value


        // Preconditions:  Must be checked out
        // PostConditions:  returned items created
        public ReturnForm(List<LibraryItem> retrnList)
        {
            InitializeComponent();
            _items = retrnList;
            string NL = Environment.NewLine; // NewLine shortcut

            //Displays items that are ckecked out
            var checkedOutItems =
            from item in retrnList
            where item.IsCheckedOut()
            select item;

            //Displays every item that has been checked out in the returnItemCbo comboBox
            foreach (var item in checkedOutItems)
            {
                returnComboBox.Items.Add($"{item.Title},{ item.CallNumber}{NL}");
            }
        }

        public int ItemsValue
        {
            // Precondition:  None
            // Postcondition: Item in returnItemCbo is returned
            get { return returnComboBox.SelectedIndex; }

        }


        // Precondition:  Attempting to change focus from returnItemCbo_Validating
        // Postcondition: If returnItemCbo.selectedIndex >= 0, focus will change,
        //                 else error message will be set        
        private void returnComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (returnComboBox.SelectedIndex < MIN_VAL)
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            returnErrorProvider.SetError(returnComboBox, "Must select an item!"); // Set error message

            returnComboBox.SelectAll();

        }


        // Precondition: returnComboBox Validating succeeded
        // Postcondition: ErrorMessage has been cleared
        private void returnComboBox_Validated(object sender, EventArgs e)
        {
            returnErrorProvider.SetError(returnComboBox, ""); // Clears error message
        }


        // Precondition:  Clicked OK button
        // Postcondition: ReturnForm is ended

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }


        // Precondition:  ] clicked the cancelBtn
        // Postcondition: If left-click, ReturnForm is eneded with with Cancel result

        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
