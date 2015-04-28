namespace Admin_Form
{
    partial class ViewAppointments
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
            this.lblSearchApp = new System.Windows.Forms.Label();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.btnViewTodaysApp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchApp
            // 
            this.lblSearchApp.AutoSize = true;
            this.lblSearchApp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchApp.Location = new System.Drawing.Point(25, 25);
            this.lblSearchApp.Name = "lblSearchApp";
            this.lblSearchApp.Size = new System.Drawing.Size(194, 22);
            this.lblSearchApp.TabIndex = 0;
            this.lblSearchApp.Text = "Todays Appointments:";
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(225, 28);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(107, 20);
            this.txtSearchDate.TabIndex = 1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(28, 70);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(508, 265);
            this.dataGrid1.TabIndex = 2;
            // 
            // btnViewTodaysApp
            // 
            this.btnViewTodaysApp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTodaysApp.Location = new System.Drawing.Point(28, 361);
            this.btnViewTodaysApp.Name = "btnViewTodaysApp";
            this.btnViewTodaysApp.Size = new System.Drawing.Size(286, 40);
            this.btnViewTodaysApp.TabIndex = 3;
            this.btnViewTodaysApp.Text = "View Appointments";
            this.btnViewTodaysApp.UseVisualStyleBackColor = true;
            this.btnViewTodaysApp.Click += new System.EventHandler(this.btnViewTodaysApp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(320, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(348, 28);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(57, 13);
            this.lblFormat.TabIndex = 5;
            this.lblFormat.Text = "(dd-mm-yy)";
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 429);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewTodaysApp);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.txtSearchDate);
            this.Controls.Add(this.lblSearchApp);
            this.Name = "ViewAppointments";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchApp;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnViewTodaysApp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFormat;
    }
}