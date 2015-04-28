using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important imports
using DeleteCustomerNamesapce;
using System.Data.OleDb;

namespace Admin_Form
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        //important variables
        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        Delete delete;

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            delete = new Delete();
        }

        //delete a customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try to connect to the database
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                delete.CustID = txtCustID.Text;
                sql = "DELETE FROM Customers WHERE (CustomerID = '" + delete.CustID + "')";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.DeleteCommand = dbCmd;
                MessageBox.Show("A CUSTOMER HAS BEEN SUCCESSFULLY DELETED","Delete Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }



    }
}
