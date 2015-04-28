using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//important imports
using AppointmentsNamespace;
using System.Data.OleDb;

namespace Admin_Form
{
    public partial class frmAppointments : Form
    {
        public frmAppointments()
        {
            InitializeComponent();
        }

        //important variables

        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        Appointments app;
        ViewAppointments viewApp;
        private void frmAppointments_Load(object sender, EventArgs e)
        {
            app = new Appointments();
        }

        //Make an appointment button
        private void btnMakeApp_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //store the values 
                app.AppDate = txtAppDate.Text;
                app.AppTime = txtAppTime.Text;
                app.CustID = txtAppCustID.Text;
                app.EmpID = txtEmpID.Text;
                app.Treatment = txtTreat.Text;

                sql = "INSERT INTO Appointments (AppointmentDate,AppointmentTime,CustomerID,EmployeeID,Treatment) VALUES ('" + app.AppDate + "', '" +
                        app.AppTime + "', '" + app.CustID+ "', '" + app.EmpID + "', '" + app.Treatment + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.InsertCommand = dbCmd;
                MessageBox.Show("Successfully Saved New Appointment", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        //Change appointment Details
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //Store the values
                //app.AppDate = txtAppDate.Text;
                //app.AppTime = txtAppTime.Text;
                app.CustID = txtAppCustID.Text;
                //app.EmpID = txtEmpID.Text;
                app.Treatment = txtTreat.Text;

                sql = "UPDATE Appointments SET Treatment = '" + app.Treatment + "'" + "WHERE(CustomerID = '" + app.CustID + "');";
                //sql = "UPDATE Appointments SET AppointmentDate = '" + app.AppDate + "'" + "WHERE(CustomerID = '" + app.CustID + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.UpdateCommand = dbCmd;

                MessageBox.Show("APPOINTMENT DETAILS HAVE BEEN SUCCESSFULLY CHANGED...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Exit Application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Directs the receptionist to the webpage where they can view all appoinments made
        private void btnViewApp_Click(object sender, EventArgs e)
        {
            viewApp = new ViewAppointments();
            viewApp.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtAppDate.Clear();
            txtAppTime.Clear();
            txtAppCustID.Clear();
            txtEmpID.Clear();
            txtTreat.Clear();
        }

        


    }
}
