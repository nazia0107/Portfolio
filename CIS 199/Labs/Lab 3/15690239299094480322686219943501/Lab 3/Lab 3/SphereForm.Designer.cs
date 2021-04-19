namespace Lab_3
{
    partial class sphereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sphereForm));
            this.sphereBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusTxt = new System.Windows.Forms.TextBox();
            this.calcSphereBtn = new System.Windows.Forms.Button();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.outputLbl1 = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.outputLbl2 = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.outputLbl3 = new System.Windows.Forms.Label();
            this.sphereBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sphereBox1
            // 
            this.sphereBox1.Image = ((System.Drawing.Image)(resources.GetObject("sphereBox1.Image")));
            this.sphereBox1.Location = new System.Drawing.Point(6, 2);
            this.sphereBox1.Name = "sphereBox1";
            this.sphereBox1.Size = new System.Drawing.Size(150, 150);
            this.sphereBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereBox1.TabIndex = 0;
            this.sphereBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius of sphere:";
            // 
            // radiusTxt
            // 
            this.radiusTxt.Location = new System.Drawing.Point(258, 28);
            this.radiusTxt.Name = "radiusTxt";
            this.radiusTxt.Size = new System.Drawing.Size(100, 20);
            this.radiusTxt.TabIndex = 2;
            // 
            // calcSphereBtn
            // 
            this.calcSphereBtn.Location = new System.Drawing.Point(258, 69);
            this.calcSphereBtn.Name = "calcSphereBtn";
            this.calcSphereBtn.Size = new System.Drawing.Size(75, 23);
            this.calcSphereBtn.TabIndex = 3;
            this.calcSphereBtn.Text = "Calculate";
            this.calcSphereBtn.UseVisualStyleBackColor = true;
            this.calcSphereBtn.Click += new System.EventHandler(this.CalcSphereBtn_Click);
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(16, 203);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 4;
            this.diameterLbl.Text = "Diameter";
            // 
            // outputLbl1
            // 
            this.outputLbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl1.Location = new System.Drawing.Point(97, 203);
            this.outputLbl1.Name = "outputLbl1";
            this.outputLbl1.Size = new System.Drawing.Size(100, 23);
            this.outputLbl1.TabIndex = 5;
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Location = new System.Drawing.Point(12, 252);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(68, 13);
            this.surfaceAreaLbl.TabIndex = 6;
            this.surfaceAreaLbl.Text = "Surface area";
            // 
            // outputLbl2
            // 
            this.outputLbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl2.Location = new System.Drawing.Point(97, 242);
            this.outputLbl2.Name = "outputLbl2";
            this.outputLbl2.Size = new System.Drawing.Size(100, 23);
            this.outputLbl2.TabIndex = 7;
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(16, 301);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 8;
            this.volumeLbl.Text = "Volume";
            // 
            // outputLbl3
            // 
            this.outputLbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl3.Location = new System.Drawing.Point(97, 291);
            this.outputLbl3.Name = "outputLbl3";
            this.outputLbl3.Size = new System.Drawing.Size(100, 23);
            this.outputLbl3.TabIndex = 9;
            // 
            // sphereBox2
            // 
            this.sphereBox2.Image = ((System.Drawing.Image)(resources.GetObject("sphereBox2.Image")));
            this.sphereBox2.Location = new System.Drawing.Point(222, 189);
            this.sphereBox2.Name = "sphereBox2";
            this.sphereBox2.Size = new System.Drawing.Size(150, 150);
            this.sphereBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereBox2.TabIndex = 10;
            this.sphereBox2.TabStop = false;
            // 
            // sphereForm
            // 
            this.AcceptButton = this.calcSphereBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.sphereBox2);
            this.Controls.Add(this.outputLbl3);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.outputLbl2);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.outputLbl1);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.calcSphereBtn);
            this.Controls.Add(this.radiusTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sphereBox1);
            this.Name = "sphereForm";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sphereBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radiusTxt;
        private System.Windows.Forms.Button calcSphereBtn;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label outputLbl1;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label outputLbl2;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label outputLbl3;
        private System.Windows.Forms.PictureBox sphereBox2;
    }
}

