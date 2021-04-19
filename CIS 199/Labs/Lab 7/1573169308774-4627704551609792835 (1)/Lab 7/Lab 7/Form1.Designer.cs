namespace Lab_7
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
            this.futrValueLbl = new System.Windows.Forms.Label();
            this.futrTxt = new System.Windows.Forms.TextBox();
            this.interestLbl = new System.Windows.Forms.Label();
            this.interestTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.presetLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futrValueLbl
            // 
            this.futrValueLbl.AutoSize = true;
            this.futrValueLbl.Location = new System.Drawing.Point(96, 54);
            this.futrValueLbl.Name = "futrValueLbl";
            this.futrValueLbl.Size = new System.Drawing.Size(70, 13);
            this.futrValueLbl.TabIndex = 0;
            this.futrValueLbl.Text = "Future Value:";
            // 
            // futrTxt
            // 
            this.futrTxt.Location = new System.Drawing.Point(210, 54);
            this.futrTxt.Name = "futrTxt";
            this.futrTxt.Size = new System.Drawing.Size(100, 20);
            this.futrTxt.TabIndex = 1;
            // 
            // interestLbl
            // 
            this.interestLbl.AutoSize = true;
            this.interestLbl.Location = new System.Drawing.Point(62, 97);
            this.interestLbl.Name = "interestLbl";
            this.interestLbl.Size = new System.Drawing.Size(104, 13);
            this.interestLbl.TabIndex = 2;
            this.interestLbl.Text = "Anual Interest Rate: ";
            // 
            // interestTxt
            // 
            this.interestTxt.Location = new System.Drawing.Point(210, 94);
            this.interestTxt.Name = "interestTxt";
            this.interestTxt.Size = new System.Drawing.Size(100, 20);
            this.interestTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. of Year: ";
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(210, 128);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 5;
            // 
            // presetLbl
            // 
            this.presetLbl.AutoSize = true;
            this.presetLbl.Location = new System.Drawing.Point(87, 186);
            this.presetLbl.Name = "presetLbl";
            this.presetLbl.Size = new System.Drawing.Size(79, 13);
            this.presetLbl.TabIndex = 6;
            this.presetLbl.Text = "Present Value: ";
            // 
            // outputLbl
            // 
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(207, 186);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(100, 23);
            this.outputLbl.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(164, 234);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 287);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.presetLbl);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestTxt);
            this.Controls.Add(this.interestLbl);
            this.Controls.Add(this.futrTxt);
            this.Controls.Add(this.futrValueLbl);
            this.Name = "Form1";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futrValueLbl;
        private System.Windows.Forms.TextBox futrTxt;
        private System.Windows.Forms.Label interestLbl;
        private System.Windows.Forms.TextBox interestTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Label presetLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button calcBtn;
    }
}

