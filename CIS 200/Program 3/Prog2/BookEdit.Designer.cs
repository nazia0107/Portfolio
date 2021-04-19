namespace LibraryItems
{
    partial class BookEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookeditLbl = new System.Windows.Forms.Label();
            this.bookEditComBox = new System.Windows.Forms.ComboBox();
            this.bookeditOkBtn = new System.Windows.Forms.Button();
            this.bookEditCancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookeditLbl
            // 
            this.bookeditLbl.AutoSize = true;
            this.bookeditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookeditLbl.Location = new System.Drawing.Point(58, 27);
            this.bookeditLbl.Name = "bookeditLbl";
            this.bookeditLbl.Size = new System.Drawing.Size(79, 15);
            this.bookeditLbl.TabIndex = 0;
            this.bookeditLbl.Text = "Select Item";
            // 
            // bookEditComBox
            // 
            this.bookEditComBox.FormattingEnabled = true;
            this.bookEditComBox.Location = new System.Drawing.Point(61, 87);
            this.bookEditComBox.Name = "bookEditComBox";
            this.bookEditComBox.Size = new System.Drawing.Size(343, 21);
            this.bookEditComBox.TabIndex = 1;
            this.bookEditComBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookEditComBox_Validating);
            this.bookEditComBox.Validated += new System.EventHandler(this.bookEditComBox_Validated);
            // 
            // bookeditOkBtn
            // 
            this.bookeditOkBtn.Location = new System.Drawing.Point(82, 156);
            this.bookeditOkBtn.Name = "bookeditOkBtn";
            this.bookeditOkBtn.Size = new System.Drawing.Size(75, 23);
            this.bookeditOkBtn.TabIndex = 2;
            this.bookeditOkBtn.Text = "OK";
            this.bookeditOkBtn.UseVisualStyleBackColor = true;
            this.bookeditOkBtn.Click += new System.EventHandler(this.bookeditOkBtn_Click);
            // 
            // bookEditCancelBtn
            // 
            this.bookEditCancelBtn.Location = new System.Drawing.Point(228, 156);
            this.bookEditCancelBtn.Name = "bookEditCancelBtn";
            this.bookEditCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.bookEditCancelBtn.TabIndex = 3;
            this.bookEditCancelBtn.Text = "Cancel";
            this.bookEditCancelBtn.UseVisualStyleBackColor = true;
            this.bookEditCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bookEditCancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookEdit
            // 
            this.AcceptButton = this.bookeditOkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 209);
            this.Controls.Add(this.bookEditCancelBtn);
            this.Controls.Add(this.bookeditOkBtn);
            this.Controls.Add(this.bookEditComBox);
            this.Controls.Add(this.bookeditLbl);
            this.Name = "BookEdit";
            this.Text = "BookEdit";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookeditLbl;
        private System.Windows.Forms.ComboBox bookEditComBox;
        private System.Windows.Forms.Button bookeditOkBtn;
        private System.Windows.Forms.Button bookEditCancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}