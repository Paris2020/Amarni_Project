using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important imports
using System.Data.OleDb;
using AppointmentsNamespace;

namespace Admin_Form
{
    public partial class ViewAppointments : Form
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        //important variables
        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private DataSet dbSet;

        private string sConn;
        private string sql;

        Appointments viewA;
        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            viewA = new Appointments();
        }


        //View todays appointments
        private void btnViewTodaysApp_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //store the value
                sql = "SELECT * FROM Appointments WHERE (AppointmentDate = '" + viewA.AppDate + "');";


                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Appointments");

                dataGrid1.SetDataBinding(dbSet,"Appointments");
                dbConn.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
        //Exits the application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        
    }
}
