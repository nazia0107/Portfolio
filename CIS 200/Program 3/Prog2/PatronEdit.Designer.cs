namespace LibraryItems
{
    partial class PatronEdit
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
            this.patronEditLbl = new System.Windows.Forms.Label();
            this.patronEditcomBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patronEditLbl
            // 
            this.patronEditLbl.AutoSize = true;
            this.patronEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronEditLbl.Location = new System.Drawing.Point(78, 28);
            this.patronEditLbl.Name = "patronEditLbl";
            this.patronEditLbl.Size = new System.Drawing.Size(86, 15);
            this.patronEditLbl.TabIndex = 0;
            this.patronEditLbl.Text = "Select Patron: ";
            // 
            // patronEditcomBox
            // 
            this.patronEditcomBox.FormattingEnabled = true;
            this.patronEditcomBox.Location = new System.Drawing.Point(81, 62);
            this.patronEditcomBox.Name = "patronEditcomBox";
            this.patronEditcomBox.Size = new System.Drawing.Size(121, 21);
            this.patronEditcomBox.TabIndex = 1;
            this.patronEditcomBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronEditcomBox_Validating);
            this.patronEditcomBox.Validated += new System.EventHandler(this.patronEditcomBox_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(58, 111);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(53, 33);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(174, 110);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 34);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatronEdit
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 173);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronEditcomBox);
            this.Controls.Add(this.patronEditLbl);
            this.Name = "PatronEdit";
            this.Text = "PatronEdit";
            this.Load += new System.EventHandler(this.PatronEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronEditLbl;
        private System.Windows.Forms.ComboBox patronEditcomBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}