namespace Lab_6
{
    partial class Form1
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
            this.wordsLbl = new System.Windows.Forms.Label();
            this.wordTxt = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordsLbl
            // 
            this.wordsLbl.AutoSize = true;
            this.wordsLbl.Location = new System.Drawing.Point(12, 39);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(172, 13);
            this.wordsLbl.TabIndex = 0;
            this.wordsLbl.Text = "Enter the Number of Words Typed ";
            // 
            // wordTxt
            // 
            this.wordTxt.Location = new System.Drawing.Point(202, 39);
            this.wordTxt.Name = "wordTxt";
            this.wordTxt.Size = new System.Drawing.Size(59, 20);
            this.wordTxt.TabIndex = 1;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(99, 141);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 16);
            this.outputLbl.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(119, 76);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 187);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.wordTxt);
            this.Controls.Add(this.wordsLbl);
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordsLbl;
        private System.Windows.Forms.TextBox wordTxt;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button submitBtn;
    }
}

