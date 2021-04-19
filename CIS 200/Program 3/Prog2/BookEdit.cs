// Program 3
// CIS 200-01
// Due Date: 4/2/2020
//Grading ID: T6278
// File: BookEdit.cs
// This class creates the Return BookEdit box form GUI. It performs validation
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
   
    public partial class BookEdit : Form
    {
        private List<LibraryItem> _items;  // List of library items
        private List<int> bookIndices; // List of book index values 


        // Precondition:  List itemList is populated with the available
        //                LibraryItems to choose from
        // Postcondition: The form's GUI is prepared for display.
        public BookEdit(List<LibraryItem> itemList)
        {
            InitializeComponent();
            _items = itemList;
        }


        // Precondition:  None
        // Postcondition: The lists of items is used to populate the
        //                book combo boxes(item that are library book)
        private void BookEdit_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _items.Count; ++i)
            {
                if (_items[i] is LibraryBook) // if libraryBook the OK to include
                {
                    bookEditComBox.Items.Add($"{_items[i].Title} {_items[i].CallNumber}");
                    bookIndices.Add(i);

                }
            }
        }

        internal int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                if (bookEditComBox.SelectedIndex != -1)
                    return bookIndices[bookEditComBox.SelectedIndex]; // Lookup correct index

                // Should never happen if validation works
                return -1;
            }
        }
        // Precondition:  User clicked on OkBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void bookeditOkBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void bookEditCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  Focus is shifting from bookEditComBox
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void bookEditComBox_Validating(object sender, CancelEventArgs e)
        {

            if (bookEditComBox.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider1.SetError(bookEditComBox, "Must select Item");
            }
        }


        // Precondition:  Validating of bookEditComBox not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void bookEditComBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(bookEditComBox, "");
        }
    }
}
