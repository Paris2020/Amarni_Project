using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important import
using System.Data.OleDb;
using UpdateCustomerNamespace;

namespace Admin_Form
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        //important variables
        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        Update update;

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            update = new Update();
        }

        //Update customer details
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //take values from textboxes
                update.CustID = txtID.Text;
                //update.Name = txtFName.Text;
                //update.Surname = txtSName.Text;
                //update.Gender = char.Parse(txtGender.Text);
                //update.Age = int.Parse(txtAge.Text);
                update.Cell = txtCell.Text;
                //update.Address = txtAddr.Text;

                sql = "UPDATE Customers SET CellphoneNumber = '" + update.Cell + "'" + "WHERE (CustomerID = '" + update.CustID + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.UpdateCommand = dbCmd;

                MessageBox.Show("CONTACT DETAILS HAVE BEEN SUCCESSFULLY CHANGED...", "Success Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dbConn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear fields
            txtID.Clear();
            txtFName.Clear();
            txtSName.Clear();
            txtGender.Clear();
            txtAge.Clear();
            txtCell.Clear();
            txtAddr.Clear();
        }


    }
}
