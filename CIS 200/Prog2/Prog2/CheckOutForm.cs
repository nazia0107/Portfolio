//Grading ID: T6278
//CIS 200-01
//Program 2
//Due Date: 3/8/2020
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
    public partial class CheckOutForm : Form
    {
        const int MIN_VAL = 0;// Named constant for minimum value 
        internal List<LibraryItem> _items;     // List of items stored in Library
        internal List<LibraryPatron> _patrons; // List of patrons of Library
        public CheckOutForm(List<LibraryItem> items, List<LibraryPatron> patrons)
        {
            InitializeComponent();

            _items = items;
            _patrons = patrons;

            string NL = Environment.NewLine; // NewLine shortcut

            foreach (var item in items)
            {

                itemComboBox.Items.Add($"{item.Title},{item.CallNumber}{NL}");
            }
            ///Displays every patron that has been been registered with the library in the patronBoxCbo comboBox
            foreach (var patron in patrons)
            {
                patronComboBox.Items.Add($"{patron.PatronName},{patron.PatronID}{NL}");
            }

        }

        internal int ItemIndex
        {
            // Precondition: None
            // Postcondition: returns itemindex to the combo box 
            get
            {
                return itemComboBox.SelectedIndex;
            }
        }

        internal int PatronIndex
        {
            // Precondition: None
            // Postcondition: returns patronindex to the combo box
            get
            {
                return patronComboBox.SelectedIndex;
            }
        }


        // Precondition:  Attempting to change focus from itemComboBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set

        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (itemComboBox.SelectedIndex < MIN_VAL)
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            itemErrorProvider.SetError(itemComboBox, "Must select an item!"); // Set error message

            itemComboBox.SelectAll();
        }

        // Precondition:  itemComboBox Validating Succeeded
        // Postcondition: ErrorMessage has been cleared, and focus can be shifted
        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            itemErrorProvider.SetError(itemComboBox, "");
        }


        // Precondition:  Attempting to change focus from patronComboBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set

        private void patronComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (patronComboBox.SelectedIndex < MIN_VAL)
                e.Cancel = true;                          // Stops focus changing process
                                                          // Will NOT proceed to Validated event
            patronErrorProvider.SetError(patronComboBox, "Must select an patron!"); 

            patronComboBox.SelectAll();
        }
        
        
        // Precondition:  itemComboBox Validating Succeeded
        // Postcondition: ErrorMessage has been cleared, and focus can be shifted
        private void patronComboBox_Validated(object sender, EventArgs e)
        {
            patronErrorProvider.SetError(patronComboBox, "");
        }


        // Precondition: Ok button is clicked
        // Postcondition: Validates the Checkout form and updates the main form
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        
        
        
        // Precondition: The cancel button is clicked
        // Postcondition: closes the form
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }
    }
}
