using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important imports
using ReportsNamespace;
using System.Data.OleDb;

namespace Admin_Form
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        ReportsClass r;
        int search1;

         //important variables

        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private DataSet dbSet;
        private string sConn;
        private string sql;

        private void Reports_Load(object sender, EventArgs e)
        {
            r = new ReportsClass();
        }

        //View sales of the store
        private void btnSales_Click(object sender, EventArgs e)
        {
            try 
            { 
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" + 
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                r.Search = txtSearch.Text;
                search1 = int.Parse(r.Search);
                sql = "SELECT * FROM Sales WHERE (ReceptionistID = " +  search1 + ");";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Sales");

                dataGrid1.SetDataBinding(dbSet, "Sales");
                dbConn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //View the stores current stock

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                 r.Search2 = txtSearch.Text;
                sql = "SELECT * FROM Stock WHERE (ProductID = '" +  r.Search2 + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Stock");

                dataGrid1.SetDataBinding(dbSet, "Stock");
                dbConn.Close();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnViewApp_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                r.Search2 = txtSearch.Text;
                sql = "SELECT * FROM Appointments WHERE (AppointmentDate = '" + r.Search2 + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Appointments");

                dataGrid1.SetDataBinding(dbSet, "Appointments");
                dbConn.Close();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        

        
    }
}
