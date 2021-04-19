namespace Program_2
{
    partial class RegistrationForm
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
            this.creditHrLbl = new System.Windows.Forms.Label();
            this.creditHourTxt = new System.Windows.Forms.TextBox();
            this.firstLtrLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.regLbl = new System.Windows.Forms.Label();
            this.registOutputLbl = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditHrLbl
            // 
            this.creditHrLbl.AutoSize = true;
            this.creditHrLbl.Location = new System.Drawing.Point(128, 34);
            this.creditHrLbl.Name = "creditHrLbl";
            this.creditHrLbl.Size = new System.Drawing.Size(145, 13);
            this.creditHrLbl.TabIndex = 0;
            this.creditHrLbl.Text = "Enter credit hours completed ";
            // 
            // creditHourTxt
            // 
            this.creditHourTxt.Location = new System.Drawing.Point(339, 34);
            this.creditHourTxt.Name = "creditHourTxt";
            this.creditHourTxt.Size = new System.Drawing.Size(100, 20);
            this.creditHourTxt.TabIndex = 1;
            // 
            // firstLtrLbl
            // 
            this.firstLtrLbl.AutoSize = true;
            this.firstLtrLbl.Location = new System.Drawing.Point(131, 91);
            this.firstLtrLbl.Name = "firstLtrLbl";
            this.firstLtrLbl.Size = new System.Drawing.Size(137, 13);
            this.firstLtrLbl.TabIndex = 2;
            this.firstLtrLbl.Text = "Enter first letter of last name";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(339, 83);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 3;
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Location = new System.Drawing.Point(134, 148);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(160, 13);
            this.regLbl.TabIndex = 4;
            this.regLbl.Text = "Earliest date and time to register ";
            // 
            // registOutputLbl
            // 
            this.registOutputLbl.AutoSize = true;
            this.registOutputLbl.Location = new System.Drawing.Point(339, 148);
            this.registOutputLbl.Name = "registOutputLbl";
            this.registOutputLbl.Size = new System.Drawing.Size(0, 13);
            this.registOutputLbl.TabIndex = 5;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(230, 206);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(111, 31);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Click to Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.checkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 344);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.registOutputLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstLtrLbl);
            this.Controls.Add(this.creditHourTxt);
            this.Controls.Add(this.creditHrLbl);
            this.Name = "RegistrationForm";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditHrLbl;
        private System.Windows.Forms.TextBox creditHourTxt;
        private System.Windows.Forms.Label firstLtrLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Label registOutputLbl;
        private System.Windows.Forms.Button checkBtn;
    }
}

