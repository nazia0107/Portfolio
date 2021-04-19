namespace LibraryItems
{
    partial class BookForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyRightLbl = new System.Windows.Forms.Label();
            this.loanpPeriodLbl = new System.Windows.Forms.Label();
            this.callNumberLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.callTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(44, 28);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(30, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title:";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(41, 63);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(56, 13);
            this.publisherLbl.TabIndex = 1;
            this.publisherLbl.Text = "Publisher: ";
            // 
            // copyRightLbl
            // 
            this.copyRightLbl.AutoSize = true;
            this.copyRightLbl.Location = new System.Drawing.Point(41, 101);
            this.copyRightLbl.Name = "copyRightLbl";
            this.copyRightLbl.Size = new System.Drawing.Size(54, 13);
            this.copyRightLbl.TabIndex = 2;
            this.copyRightLbl.Text = "Copyright:";
            // 
            // loanpPeriodLbl
            // 
            this.loanpPeriodLbl.AutoSize = true;
            this.loanpPeriodLbl.Location = new System.Drawing.Point(44, 139);
            this.loanpPeriodLbl.Name = "loanpPeriodLbl";
            this.loanpPeriodLbl.Size = new System.Drawing.Size(67, 13);
            this.loanpPeriodLbl.TabIndex = 3;
            this.loanpPeriodLbl.Text = "Loan Period:";
            // 
            // callNumberLbl
            // 
            this.callNumberLbl.AutoSize = true;
            this.callNumberLbl.Location = new System.Drawing.Point(44, 179);
            this.callNumberLbl.Name = "callNumberLbl";
            this.callNumberLbl.Size = new System.Drawing.Size(67, 13);
            this.callNumberLbl.TabIndex = 4;
            this.callNumberLbl.Text = "Call Number:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(44, 219);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(41, 13);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(146, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextBox_Validating);
            this.titleTextBox.Validated += new System.EventHandler(this.titleTextBox_Validated);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(146, 63);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 7;
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.Location = new System.Drawing.Point(146, 101);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightTextBox.TabIndex = 8;
            this.copyrightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightTextBox_Validating);
            this.copyrightTextBox.Validated += new System.EventHandler(this.copyrightTextBox_Validated);
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(146, 139);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(100, 20);
            this.loanTextBox.TabIndex = 9;
            this.loanTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loanTextBox_Validating);
            this.loanTextBox.Validated += new System.EventHandler(this.loanTextBox_Validated);
            // 
            // callTextBox
            // 
            this.callTextBox.Location = new System.Drawing.Point(146, 179);
            this.callTextBox.Name = "callTextBox";
            this.callTextBox.Size = new System.Drawing.Size(100, 20);
            this.callTextBox.TabIndex = 10;
            this.callTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.callTextBox_Validating);
            this.callTextBox.Validated += new System.EventHandler(this.callTextBox_Validated);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(146, 219);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 11;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(44, 280);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "Enter";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(171, 280);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 338);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.callTextBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.copyrightTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callNumberLbl);
            this.Controls.Add(this.loanpPeriodLbl);
            this.Controls.Add(this.copyRightLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyRightLbl;
        private System.Windows.Forms.Label loanpPeriodLbl;
        private System.Windows.Forms.Label callNumberLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.TextBox callTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}