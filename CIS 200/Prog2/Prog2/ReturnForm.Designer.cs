namespace LibraryItems
{
    partial class ReturnForm
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
            this.returnComboBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.returnErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItemLbl
            // 
            this.selectItemLbl.AutoSize = true;
            this.selectItemLbl.Location = new System.Drawing.Point(41, 29);
            this.selectItemLbl.Name = "selectItemLbl";
            this.selectItemLbl.Size = new System.Drawing.Size(60, 13);
            this.selectItemLbl.TabIndex = 0;
            this.selectItemLbl.Text = "Select Item";
            // 
            // returnComboBox
            // 
            this.returnComboBox.FormattingEnabled = true;
            this.returnComboBox.Location = new System.Drawing.Point(44, 73);
            this.returnComboBox.Name = "returnComboBox";
            this.returnComboBox.Size = new System.Drawing.Size(204, 21);
            this.returnComboBox.TabIndex = 1;
            this.returnComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.returnComboBox_Validating);
            this.returnComboBox.Validated += new System.EventHandler(this.returnComboBox_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(44, 149);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(173, 149);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // returnErrorProvider
            // 
            this.returnErrorProvider.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 271);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.returnComboBox);
            this.Controls.Add(this.selectItemLbl);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.returnErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLbl;
        private System.Windows.Forms.ComboBox returnComboBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider returnErrorProvider;
    }
}