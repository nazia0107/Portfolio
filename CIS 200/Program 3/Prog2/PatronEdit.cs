// Program 3
// CIS 200-01
// Due Date: 4/2/2020
//Grading ID: T6278
// File: PatronEdit.cs
// This class creates the Return PatronEdit box form GUI. It performs validation
// and provides an int get property associated with the index of the
// selected item for user to edit
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    
    public partial class PatronEdit : Form
    {
        private List<LibraryPatron> _patrons; // List of patrons



        // Precondition:  List patronlist is populated with the available patrons 
        //                to choose from
        // Postcondition: The form's GUI is prepared for display.
        public PatronEdit(List<LibraryPatron> patronList)
        {
            InitializeComponent();
            _patrons = patronList;
        }
        

        internal int PatronIndex //returns the selected patron index
        {
            // Precondition:  None
            // Postcondition: Selected patron index in the combo box is returned
            get
            {
                return patronEditcomBox.SelectedIndex;
            }
        }

        // Precondition:  Focus is shifting from patronIdTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void patronEditcomBox_Validating(object sender, CancelEventArgs e)
        {
            if (patronEditcomBox.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider1.SetError(patronEditcomBox, "Must select Item!");
            }
        }

        // Precondition:  Validating of patronEditcomBox not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change

        private void patronEditcomBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronEditcomBox, "");
        }


        // Precondition:  None
        // Postcondition: The patrons list is used to populate the
        //                 patron combo boxes
        private void PatronEdit_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patronEditcomBox.Items.Add($"{patron.PatronName} {patron.PatronID}");
        }


        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())  // If all controls validate
            {
                this.DialogResult = DialogResult.OK;  // Causes form to close and return OK result
            }
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {

            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
