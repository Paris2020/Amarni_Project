namespace Admin_Form
{
    partial class CashSaleChange
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
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.Location = new System.Drawing.Point(130, 9);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(212, 30);
            this.lblTotalDue.TabIndex = 0;
            this.lblTotalDue.Text = "Process Payment";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(118, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(248, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(204, 69);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(149, 20);
            this.txtCash.TabIndex = 5;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(204, 115);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(149, 20);
            this.txtCard.TabIndex = 6;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCash.Location = new System.Drawing.Point(92, 58);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(88, 34);
            this.rbtnCash.TabIndex = 7;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCashOrCard_CheckedChanged);
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCard.Location = new System.Drawing.Point(92, 101);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(84, 34);
            this.rbtnCard.TabIndex = 8;
            this.rbtnCard.TabStop = true;
            this.rbtnCard.Text = "Card";
            this.rbtnCard.UseVisualStyleBackColor = true;
            this.rbtnCard.CheckedChanged += new System.EventHandler(this.rbtnCashOrCard_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(204, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(204, 115);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(149, 20);
            this.txtTotal2.TabIndex = 10;
            // 
            // CashSaleChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 213);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.rbtnCard);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotalDue);
            this.Name = "CashSaleChange";
            this.Text = "Calculate Change";
            this.Load += new System.EventHandler(this.CashSaleTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotal2;
    }
}