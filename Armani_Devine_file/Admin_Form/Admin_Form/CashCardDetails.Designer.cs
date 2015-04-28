namespace Admin_Form
{
    partial class CashCardDetails
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
            this.grpBoxBankDetails = new System.Windows.Forms.GroupBox();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.rbtnCheque = new System.Windows.Forms.RadioButton();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnEnterPIN = new System.Windows.Forms.Button();
            this.grpBoxBankDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxBankDetails
            // 
            this.grpBoxBankDetails.Controls.Add(this.rbtnSavings);
            this.grpBoxBankDetails.Controls.Add(this.rbtnCheque);
            this.grpBoxBankDetails.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxBankDetails.Location = new System.Drawing.Point(12, 12);
            this.grpBoxBankDetails.Name = "grpBoxBankDetails";
            this.grpBoxBankDetails.Size = new System.Drawing.Size(274, 101);
            this.grpBoxBankDetails.TabIndex = 0;
            this.grpBoxBankDetails.TabStop = false;
            this.grpBoxBankDetails.Text = "Bank Details";
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(20, 65);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(82, 22);
            this.rbtnSavings.TabIndex = 1;
            this.rbtnSavings.TabStop = true;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            this.rbtnSavings.CheckedChanged += new System.EventHandler(this.rbtnAccType_CheckedChanged);
            // 
            // rbtnCheque
            // 
            this.rbtnCheque.AutoSize = true;
            this.rbtnCheque.Location = new System.Drawing.Point(20, 25);
            this.rbtnCheque.Name = "rbtnCheque";
            this.rbtnCheque.Size = new System.Drawing.Size(81, 22);
            this.rbtnCheque.TabIndex = 0;
            this.rbtnCheque.TabStop = true;
            this.rbtnCheque.Text = "Cheque";
            this.rbtnCheque.UseVisualStyleBackColor = true;
            this.rbtnCheque.CheckedChanged += new System.EventHandler(this.rbtnAccType_CheckedChanged);
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Location = new System.Drawing.Point(19, 143);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(56, 13);
            this.lblEnterPin.TabIndex = 1;
            this.lblEnterPin.Text = "Enter PIN:";
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(108, 143);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(178, 20);
            this.txtPIN.TabIndex = 2;
            // 
            // btnEnterPIN
            // 
            this.btnEnterPIN.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPIN.Location = new System.Drawing.Point(77, 178);
            this.btnEnterPIN.Name = "btnEnterPIN";
            this.btnEnterPIN.Size = new System.Drawing.Size(161, 47);
            this.btnEnterPIN.TabIndex = 3;
            this.btnEnterPIN.Text = "Enter";
            this.btnEnterPIN.UseVisualStyleBackColor = true;
            this.btnEnterPIN.Click += new System.EventHandler(this.btnEnterPIN_Click);
            // 
            // CashCardDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 237);
            this.Controls.Add(this.btnEnterPIN);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.grpBoxBankDetails);
            this.Name = "CashCardDetails";
            this.Text = "Cash-Card Details";
            this.Load += new System.EventHandler(this.CashCardDetails_Load);
            this.grpBoxBankDetails.ResumeLayout(false);
            this.grpBoxBankDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxBankDetails;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnCheque;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnEnterPIN;
    }
}