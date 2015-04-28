namespace Admin_Form
{
    partial class frmPriceLookup
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
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.lblHeading3 = new System.Windows.Forms.Label();
            this.btnLoadProductPrices = new System.Windows.Forms.Button();
            this.btnHairstyles = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Location = new System.Drawing.Point(178, 270);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrMsg.TabIndex = 0;
            // 
            // lblHeading3
            // 
            this.lblHeading3.AutoSize = true;
            this.lblHeading3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading3.Location = new System.Drawing.Point(174, 19);
            this.lblHeading3.Name = "lblHeading3";
            this.lblHeading3.Size = new System.Drawing.Size(357, 38);
            this.lblHeading3.TabIndex = 1;
            this.lblHeading3.Text = "STORE PRICE LOOKUP";
            // 
            // btnLoadProductPrices
            // 
            this.btnLoadProductPrices.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProductPrices.Location = new System.Drawing.Point(162, 436);
            this.btnLoadProductPrices.Name = "btnLoadProductPrices";
            this.btnLoadProductPrices.Size = new System.Drawing.Size(191, 45);
            this.btnLoadProductPrices.TabIndex = 2;
            this.btnLoadProductPrices.Text = "Products Prices";
            this.btnLoadProductPrices.UseVisualStyleBackColor = true;
            this.btnLoadProductPrices.Click += new System.EventHandler(this.btnLoadProductPrices_Click);
            // 
            // btnHairstyles
            // 
            this.btnHairstyles.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHairstyles.Location = new System.Drawing.Point(370, 436);
            this.btnHairstyles.Name = "btnHairstyles";
            this.btnHairstyles.Size = new System.Drawing.Size(191, 45);
            this.btnHairstyles.TabIndex = 3;
            this.btnHairstyles.Text = "Hairstlyes";
            this.btnHairstyles.UseVisualStyleBackColor = true;
            this.btnHairstyles.Click += new System.EventHandler(this.btnHairstyles_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(69, 71);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(580, 337);
            this.dataGrid1.TabIndex = 4;
            // 
            // frmPriceLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 484);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnHairstyles);
            this.Controls.Add(this.btnLoadProductPrices);
            this.Controls.Add(this.lblHeading3);
            this.Controls.Add(this.lblErrMsg);
            this.Name = "frmPriceLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Lookup";
            this.Load += new System.EventHandler(this.frmPriceLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Label lblHeading3;
        private System.Windows.Forms.Button btnLoadProductPrices;
        private System.Windows.Forms.Button btnHairstyles;
        private System.Windows.Forms.DataGrid dataGrid1;
    }
}