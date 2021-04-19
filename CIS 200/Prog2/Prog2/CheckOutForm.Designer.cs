namespace LibraryItems
{
    partial class CheckOutForm
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
            this.selectItemLbl = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.selectPatronLbl = new System.Windows.Forms.Label();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.itemErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.patronErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItemLbl
            // 
            this.selectItemLbl.AutoSize = true;
            this.selectItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemLbl.Location = new System.Drawing.Point(58, 38);
            this.selectItemLbl.Name = "selectItemLbl";
            this.selectItemLbl.Size = new System.Drawing.Size(79, 15);
            this.selectItemLbl.TabIndex = 0;
            this.selectItemLbl.Text = "Select Item";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(61, 72);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(192, 21);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBox_Validating);
            this.itemComboBox.Validated += new System.EventHandler(this.itemComboBox_Validated);
            // 
            // selectPatronLbl
            // 
            this.selectPatronLbl.AutoSize = true;
            this.selectPatronLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPatronLbl.Location = new System.Drawing.Point(61, 121);
            this.selectPatronLbl.Name = "selectPatronLbl";
            this.selectPatronLbl.Size = new System.Drawing.Size(97, 15);
            this.selectPatronLbl.TabIndex = 2;
            this.selectPatronLbl.Text = "Select Patron ";
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(60, 157);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(189, 21);
            this.patronComboBox.TabIndex = 3;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronComboBox_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.patronComboBox_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(60, 219);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(98, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "CheckOut";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(178, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // itemErrorProvider
            // 
            this.itemErrorProvider.ContainerControl = this;
            // 
            // patronErrorProvider
            // 
            this.patronErrorProvider.ContainerControl = this;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 331);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.selectPatronLbl);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.selectItemLbl);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLbl;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label selectPatronLbl;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider itemErrorProvider;
        private System.Windows.Forms.ErrorProvider patronErrorProvider;
    }
}