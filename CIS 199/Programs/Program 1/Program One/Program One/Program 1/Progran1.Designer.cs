namespace Program_1
{
    partial class Progran1
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.heightLbl = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.doorLbl = new System.Windows.Forms.Label();
            this.doorTxt = new System.Windows.Forms.TextBox();
            this.windowLbl = new System.Windows.Forms.Label();
            this.windowTxt = new System.Windows.Forms.TextBox();
            this.coatsLbl = new System.Windows.Forms.Label();
            this.coatTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(162, 43);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(344, 20);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to Handy-Dandy Paint Estimator";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLbl.Location = new System.Drawing.Point(85, 110);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(271, 18);
            this.lengthLbl.TabIndex = 1;
            this.lengthLbl.Text = "Enter the total length of all walls (in feet):";
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(472, 110);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(100, 20);
            this.lengthText.TabIndex = 2;
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLbl.Location = new System.Drawing.Point(85, 146);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(249, 18);
            this.heightLbl.TabIndex = 3;
            this.heightLbl.Text = "Enter the height of the walls (in feet) :";
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(472, 144);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(100, 20);
            this.heightTxt.TabIndex = 4;
            // 
            // doorLbl
            // 
            this.doorLbl.AutoSize = true;
            this.doorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorLbl.Location = new System.Drawing.Point(85, 176);
            this.doorLbl.Name = "doorLbl";
            this.doorLbl.Size = new System.Drawing.Size(276, 18);
            this.doorLbl.TabIndex = 5;
            this.doorLbl.Text = "Enter the number of doors (non-neg int) :";
            // 
            // doorTxt
            // 
            this.doorTxt.Location = new System.Drawing.Point(472, 176);
            this.doorTxt.Name = "doorTxt";
            this.doorTxt.Size = new System.Drawing.Size(100, 20);
            this.doorTxt.TabIndex = 6;
            // 
            // windowLbl
            // 
            this.windowLbl.AutoSize = true;
            this.windowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLbl.Location = new System.Drawing.Point(85, 219);
            this.windowLbl.Name = "windowLbl";
            this.windowLbl.Size = new System.Drawing.Size(271, 18);
            this.windowLbl.TabIndex = 7;
            this.windowLbl.Text = "Enter number of windows (non-neg int) :";
            // 
            // windowTxt
            // 
            this.windowTxt.Location = new System.Drawing.Point(472, 219);
            this.windowTxt.Name = "windowTxt";
            this.windowTxt.Size = new System.Drawing.Size(100, 20);
            this.windowTxt.TabIndex = 8;
            // 
            // coatsLbl
            // 
            this.coatsLbl.AutoSize = true;
            this.coatsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coatsLbl.Location = new System.Drawing.Point(85, 254);
            this.coatsLbl.Name = "coatsLbl";
            this.coatsLbl.Size = new System.Drawing.Size(326, 18);
            this.coatsLbl.TabIndex = 9;
            this.coatsLbl.Text = "Enter the number of coats of paint (non-neg int) :";
            // 
            // coatTxt
            // 
            this.coatTxt.Location = new System.Drawing.Point(472, 255);
            this.coatTxt.Name = "coatTxt";
            this.coatTxt.Size = new System.Drawing.Size(100, 20);
            this.coatTxt.TabIndex = 10;
            // 
            // calcBtn
            // 
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(261, 363);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(150, 34);
            this.calcBtn.TabIndex = 11;
            this.calcBtn.Text = "Estimate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(112, 297);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(460, 53);
            this.outputLbl.TabIndex = 12;
            // 
            // Progran1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(652, 409);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.coatTxt);
            this.Controls.Add(this.coatsLbl);
            this.Controls.Add(this.windowTxt);
            this.Controls.Add(this.windowLbl);
            this.Controls.Add(this.doorTxt);
            this.Controls.Add(this.doorLbl);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Progran1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.Label doorLbl;
        private System.Windows.Forms.TextBox doorTxt;
        private System.Windows.Forms.Label windowLbl;
        private System.Windows.Forms.TextBox windowTxt;
        private System.Windows.Forms.Label coatsLbl;
        private System.Windows.Forms.TextBox coatTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

