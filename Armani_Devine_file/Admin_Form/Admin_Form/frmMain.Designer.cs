namespace Admin_Form
{
    partial class frmMain
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
            this.lstBxMenu = new System.Windows.Forms.ListBox();
            this.btnPriceLookup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxMenu
            // 
            this.lstBxMenu.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxMenu.FormattingEnabled = true;
            this.lstBxMenu.ItemHeight = 57;
            this.lstBxMenu.Location = new System.Drawing.Point(12, 69);
            this.lstBxMenu.Name = "lstBxMenu";
            this.lstBxMenu.Size = new System.Drawing.Size(425, 403);
            this.lstBxMenu.TabIndex = 0;
            this.lstBxMenu.SelectedIndexChanged += new System.EventHandler(this.lstBxMenu_SelectedIndexChanged);
            // 
            // btnPriceLookup
            // 
            this.btnPriceLookup.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceLookup.Location = new System.Drawing.Point(443, 366);
            this.btnPriceLookup.Name = "btnPriceLookup";
            this.btnPriceLookup.Size = new System.Drawing.Size(156, 52);
            this.btnPriceLookup.TabIndex = 1;
            this.btnPriceLookup.Text = "Price Lookup";
            this.btnPriceLookup.UseVisualStyleBackColor = true;
            this.btnPriceLookup.Click += new System.EventHandler(this.btnPriceLookup_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(443, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.Location = new System.Drawing.Point(173, 9);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(249, 38);
            this.lblPOS.TabIndex = 3;
            this.lblPOS.Text = "POINT OF SALE";
         
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 484);
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPriceLookup);
            this.Controls.Add(this.lstBxMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxMenu;
        private System.Windows.Forms.Button btnPriceLookup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPOS;
    }
}