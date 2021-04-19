//Grading ID: T6278
//CIS 200-01
//Program 2
//Due Date: 3/8/2020
//This GUI allows user to select a new
//         patron and adds  to the library.
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
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
        }


        internal string NameValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in nameTxtBox is returned
            get { return nameTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { nameTextBox.Text = value; }
        }

        internal string IDValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in idTxtBox is returned
            get { return idTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in idTxtBox is set to specified value
            set
            { idTextBox.Text = value; }
        }

        // Precondition:  Attempting to change focus from nameTextBox
        // Postcondition: If entered value is valid name, focus will change,
        //                else focus will remain and error provider message set
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                e.Cancel = true; //stop focus changing process
                
                nameError.SetError(nameTextBox, "Please enter a valid patron name");
                
                nameTextBox.SelectAll();
            }

        }

        // Precondition:  NametextBox Validating succeeded
        // Postcondition: Any error message set for nameTextBox is cleared
        //                Focus is allowed to change

        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            nameError.SetError(nameTextBox, "Please enter Name!");
        }


        // Precondition:  Attempting to change focus from idTextBox
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void idTextBox_Validating(object sender, CancelEventArgs e)
        {
            int ID; // holds value entered in the idTextBox
            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(idTextBox.Text, out ID))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                nameError.SetError(idTextBox, "Enter an integer!"); // Set error message

                idTextBox.SelectAll(); // Select all text in idTextBox to ease correction
            }
            else
            {
                if (ID < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    nameError.SetError(idTextBox, "Enter a non-negative integer!"); // Set error message

                    idTextBox.SelectAll(); // Select all text in idTextBox to ease correction
                }
            }
        }

        // Precondition:  inputTxt_Validating succeeded
        // Postcondition: Any error message set for idTextBox is cleared
        //                Focus is allowed to change

        private void idTextBox_Validated(object sender, EventArgs e)
        {
            idError.SetError(idTextBox, ""); // Clears error message

        }


        // Precondition:  The okButton has been clicked
        // Postcondition: A dialog box has been displayed prompting for
        //                a number. If user submits, MainForm is updated
        //                to display value
        private void okBtn_Click(object sender, EventArgs e)
        {
            // Raise validating event for all enabled controls on form
            // If all pass, ValidateChildren() will be true

            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;

            }
        }


        // Precondition:  The cancelButton has been clicked
        //Postcondition:  canceled the form
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
