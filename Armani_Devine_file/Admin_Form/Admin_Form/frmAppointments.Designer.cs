namespace Admin_Form
{
    partial class frmAppointments
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
            this.lblAppHeading = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppTime = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblTreat = new System.Windows.Forms.Label();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.txtAppCustID = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtTreat = new System.Windows.Forms.TextBox();
            this.btnMakeApp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewApp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppHeading
            // 
            this.lblAppHeading.AutoSize = true;
            this.lblAppHeading.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppHeading.Location = new System.Drawing.Point(87, 9);
            this.lblAppHeading.Name = "lblAppHeading";
            this.lblAppHeading.Size = new System.Drawing.Size(260, 38);
            this.lblAppHeading.TabIndex = 0;
            this.lblAppHeading.Text = "APPOINTMENTS";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(12, 74);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(165, 22);
            this.lblAppDate.TabIndex = 1;
            this.lblAppDate.Text = "Appointment Date:";
            // 
            // lblAppTime
            // 
            this.lblAppTime.AutoSize = true;
            this.lblAppTime.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTime.Location = new System.Drawing.Point(12, 115);
            this.lblAppTime.Name = "lblAppTime";
            this.lblAppTime.Size = new System.Drawing.Size(167, 22);
            this.lblAppTime.TabIndex = 2;
            this.lblAppTime.Text = "Appointment Time:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(12, 166);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(113, 22);
            this.lblCustID.TabIndex = 3;
            this.lblCustID.Text = "CustomerID:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(12, 219);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(118, 22);
            this.lblEmpID.TabIndex = 4;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblTreat
            // 
            this.lblTreat.AutoSize = true;
            this.lblTreat.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreat.Location = new System.Drawing.Point(12, 268);
            this.lblTreat.Name = "lblTreat";
            this.lblTreat.Size = new System.Drawing.Size(102, 22);
            this.lblTreat.TabIndex = 5;
            this.lblTreat.Text = "Treatment:";
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(198, 74);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.Size = new System.Drawing.Size(203, 20);
            this.txtAppDate.TabIndex = 6;
            // 
            // txtAppTime
            // 
            this.txtAppTime.Location = new System.Drawing.Point(198, 115);
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(203, 20);
            this.txtAppTime.TabIndex = 7;
            // 
            // txtAppCustID
            // 
            this.txtAppCustID.Location = new System.Drawing.Point(198, 169);
            this.txtAppCustID.Name = "txtAppCustID";
            this.txtAppCustID.Size = new System.Drawing.Size(203, 20);
            this.txtAppCustID.TabIndex = 8;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(198, 219);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(203, 20);
            this.txtEmpID.TabIndex = 9;
            // 
            // txtTreat
            // 
            this.txtTreat.Location = new System.Drawing.Point(198, 268);
            this.txtTreat.Name = "txtTreat";
            this.txtTreat.Size = new System.Drawing.Size(203, 20);
            this.txtTreat.TabIndex = 10;
            // 
            // btnMakeApp
            // 
            this.btnMakeApp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeApp.Location = new System.Drawing.Point(26, 331);
            this.btnMakeApp.Name = "btnMakeApp";
            this.btnMakeApp.Size = new System.Drawing.Size(125, 36);
            this.btnMakeApp.TabIndex = 11;
            this.btnMakeApp.Text = "Save";
            this.btnMakeApp.UseVisualStyleBackColor = true;
            this.btnMakeApp.Click += new System.EventHandler(this.btnMakeApp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(157, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Change";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(287, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewApp
            // 
            this.btnViewApp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewApp.Location = new System.Drawing.Point(26, 373);
            this.btnViewApp.Name = "btnViewApp";
            this.btnViewApp.Size = new System.Drawing.Size(190, 36);
            this.btnViewApp.TabIndex = 14;
            this.btnViewApp.Text = "View Appointments";
            this.btnViewApp.UseVisualStyleBackColor = true;
            this.btnViewApp.Click += new System.EventHandler(this.btnViewApp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(220, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 419);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnViewApp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMakeApp);
            this.Controls.Add(this.txtTreat);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtAppCustID);
            this.Controls.Add(this.txtAppTime);
            this.Controls.Add(this.txtAppDate);
            this.Controls.Add(this.lblTreat);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblAppTime);
            this.Controls.Add(this.lblAppDate);
            this.Controls.Add(this.lblAppHeading);
            this.Name = "frmAppointments";
            this.Text = "Make Appointments";
            this.Load += new System.EventHandler(this.frmAppointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppHeading;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblAppTime;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblTreat;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.TextBox txtAppCustID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtTreat;
        private System.Windows.Forms.Button btnMakeApp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewApp;
        private System.Windows.Forms.Button btnClear;
    }
}