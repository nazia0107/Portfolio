// Grading ID: T6278
// Due Date : 03/08/20
// Program 4
// CIS200-01 
//This form's purpose is to allow the user to select a new book to add to the library, and validations of the GUI 
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
    public partial class BookForm : Form
    {
        const int MIN_VALUE = 0;// named constant to hold minimum value
        public BookForm()
        {
            InitializeComponent();
        }

        internal string TitleValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in titleTxtBox is returned
            get { return titleTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in titleTxtBox is set to specified value
            set { titleTextBox.Text = value; }
        }

        internal string PublisherValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in publisherTxtBox is returned
            get { return publisherTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in publisherTxtBox is set to specified value
            set { publisherTextBox.Text = value; }
        }

        internal string CopyrightValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in copyrightTxtBox is returned
            get { return copyrightTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in copyrightTxtBox is set to specified value
            set { copyrightTextBox.Text = value; }
        }

        internal string LoanPeriodValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in loanPeriodTxtBox is returned
            get { return loanTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in loanPeriodTxtBox is set to specified value
            set { loanTextBox.Text = value; }
        }

        internal string CallNumberValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in callNumberTxtBox is returned
            get { return callTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in callNumberTxtBox is set to specified value
            set { callTextBox.Text = value; }
        }

        internal string AuthorValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in authorTxtBox is returned
            get { return authorTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in authorTxtBox is set to specified value
            set { authorTextBox.Text = value; }
        }



        // Precondition:  Attempting to change focus from titleTxtBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message se
        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(titleTextBox, "Must Enter a Title!");

                titleTextBox.SelectAll();
            }
        }


        // Precondition:  titleTxtBox_Validating succeeded
        // Postcondition: Any error message set for titleTxtBox is cleared
        //                Focus is allowed to change

        private void titleTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTextBox, "");
        }


        // Precondition:  Attempting to change focus from copyrightTxtBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message se
        private void copyrightTextBox_Validating(object sender, CancelEventArgs e)
        {
            int copyrightYear;// holds copyright year

            if (!int.TryParse(copyrightTextBox.Text, out copyrightYear) ||
                int.Parse(copyrightTextBox.Text) < MIN_VALUE)
            {
                e.Cancel = true;

                errorProvider2.SetError(copyrightTextBox, "Enter a Copyright Year!");

                copyrightTextBox.SelectAll();
            }

        }



        // Precondition:  copyrightTxtBox_Validating succeeded
        // Postcondition: Any error message set for copyrightTxtBox is cleared
        //                Focus is allowed to change

        private void copyrightTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(copyrightTextBox, "");
        }

        
        
        // Precondition:  Attempting to change focus from loanPeriodTxtBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message se

        private void loanTextBox_Validating(object sender, CancelEventArgs e)
        {
            int loanPeriod; // hold loan period

            if (!int.TryParse(loanTextBox.Text, out loanPeriod) ||
                int.Parse(loanTextBox.Text) < MIN_VALUE)
            {
                e.Cancel = true;

                errorProvider3.SetError(loanTextBox, "Must Enter Loan Period!");

                loanTextBox.SelectAll();
            }
        }

        // Precondition:  loanPeriodTxtBox_Validating succeeded
        // Postcondition: Any error message set for loanPeriodTxtBox is cleared
        //                Focus is allowed to change

        private void loanTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(loanTextBox, "");
        }

        // Precondition:  Attempting to change focus from callNumberTxtBox
        // Postcondition: If entered value is valid , focus will change,
        //                else focus will remain and error provider message se

        private void callTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callTextBox.Text))
            {
                e.Cancel = true;

                errorProvider4.SetError(callTextBox, " Must Enter a Call Number!");

                callTextBox.SelectAll();
            }
        }


        // Precondition:  callNumberTxtBox validating succeeded
        // Postcondition: Any error message set for callNumberTxtBox is cleared
        //                Focus is allowed to change

        private void callTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(callTextBox, "");
        }


        // Precondition:  Enter buttton is clicked 
        // Postcondition: If all controls on form validate, sends dialogresult.OK
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        
        
        // Precondition: Cancel button is clicked 
        // Postcondition: If left-click, InputBox is dismissed with Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
