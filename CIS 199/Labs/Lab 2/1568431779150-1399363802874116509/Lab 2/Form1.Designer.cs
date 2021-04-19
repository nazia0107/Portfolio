namespace Lab_2
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
            this.mealPriceLbl = new System.Windows.Forms.Label();
            this.mealPriceTxt = new System.Windows.Forms.TextBox();
            this.smlTipLbl = new System.Windows.Forms.Label();
            this.outputLbl1 = new System.Windows.Forms.Label();
            this.medTipLbl = new System.Windows.Forms.Label();
            this.outputLbl2 = new System.Windows.Forms.Label();
            this.largeTipLbl = new System.Windows.Forms.Label();
            this.outputLbl3 = new System.Windows.Forms.Label();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPriceLbl
            // 
            this.mealPriceLbl.AutoSize = true;
            this.mealPriceLbl.Location = new System.Drawing.Point(30, 24);
            this.mealPriceLbl.Name = "mealPriceLbl";
            this.mealPriceLbl.Size = new System.Drawing.Size(98, 13);
            this.mealPriceLbl.TabIndex = 0;
            this.mealPriceLbl.Text = "Enter price for meal";
            // 
            // mealPriceTxt
            // 
            this.mealPriceTxt.Location = new System.Drawing.Point(182, 24);
            this.mealPriceTxt.Name = "mealPriceTxt";
            this.mealPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.mealPriceTxt.TabIndex = 1;
            // 
            // smlTipLbl
            // 
            this.smlTipLbl.AutoSize = true;
            this.smlTipLbl.Location = new System.Drawing.Point(41, 81);
            this.smlTipLbl.Name = "smlTipLbl";
            this.smlTipLbl.Size = new System.Drawing.Size(27, 13);
            this.smlTipLbl.TabIndex = 2;
            this.smlTipLbl.Text = "15%";
            // 
            // outputLbl1
            // 
            this.outputLbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl1.Location = new System.Drawing.Point(182, 71);
            this.outputLbl1.Name = "outputLbl1";
            this.outputLbl1.Size = new System.Drawing.Size(100, 23);
            this.outputLbl1.TabIndex = 3;
            // 
            // medTipLbl
            // 
            this.medTipLbl.AutoSize = true;
            this.medTipLbl.Location = new System.Drawing.Point(44, 123);
            this.medTipLbl.Name = "medTipLbl";
            this.medTipLbl.Size = new System.Drawing.Size(27, 13);
            this.medTipLbl.TabIndex = 4;
            this.medTipLbl.Text = "18%";
            // 
            // outputLbl2
            // 
            this.outputLbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl2.Location = new System.Drawing.Point(182, 123);
            this.outputLbl2.Name = "outputLbl2";
            this.outputLbl2.Size = new System.Drawing.Size(100, 23);
            this.outputLbl2.TabIndex = 5;
            // 
            // largeTipLbl
            // 
            this.largeTipLbl.AutoSize = true;
            this.largeTipLbl.Location = new System.Drawing.Point(44, 167);
            this.largeTipLbl.Name = "largeTipLbl";
            this.largeTipLbl.Size = new System.Drawing.Size(27, 13);
            this.largeTipLbl.TabIndex = 6;
            this.largeTipLbl.Text = "20%";
            // 
            // outputLbl3
            // 
            this.outputLbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl3.Location = new System.Drawing.Point(182, 167);
            this.outputLbl3.Name = "outputLbl3";
            this.outputLbl3.Size = new System.Drawing.Size(100, 23);
            this.outputLbl3.TabIndex = 7;
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.Location = new System.Drawing.Point(92, 257);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(107, 31);
            this.calcTipBtn.TabIndex = 8;
            this.calcTipBtn.Text = "Calculate Tip";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            this.calcTipBtn.Click += new System.EventHandler(this.CalcTipBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 325);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.outputLbl3);
            this.Controls.Add(this.largeTipLbl);
            this.Controls.Add(this.outputLbl2);
            this.Controls.Add(this.medTipLbl);
            this.Controls.Add(this.outputLbl1);
            this.Controls.Add(this.smlTipLbl);
            this.Controls.Add(this.mealPriceTxt);
            this.Controls.Add(this.mealPriceLbl);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLbl;
        private System.Windows.Forms.TextBox mealPriceTxt;
        private System.Windows.Forms.Label smlTipLbl;
        private System.Windows.Forms.Label outputLbl1;
        private System.Windows.Forms.Label medTipLbl;
        private System.Windows.Forms.Label outputLbl2;
        private System.Windows.Forms.Label largeTipLbl;
        private System.Windows.Forms.Label outputLbl3;
        private System.Windows.Forms.Button calcTipBtn;
    }
}

