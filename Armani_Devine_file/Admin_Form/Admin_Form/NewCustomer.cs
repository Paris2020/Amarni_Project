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
using NewCustomer;

namespace Admin_Form
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        //important variables
        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        New newC;

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            newC = new New();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                newC.CustID = txtID.Text;
                newC.Name = txtFName.Text;
                newC.Surname = txtSName.Text;
                newC.Gender = char.Parse(txtGender.Text);
                newC.Age = int.Parse(txtAge.Text);
                newC.Cell = txtCell.Text;
                newC.Address = txtAddr.Text;

                sql = "INSERT INTO Customers (CustomerID,Firstname,Surname,Age,Gender,CellphoneNumber,Address) VALUES ('" + newC.CustID + "', '" + 
                        newC.Name + "', '" + newC.Surname + "', " + newC.Age + ", '" + newC.Gender + "', '" + newC.Cell + "', '" + newC.Address + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.InsertCommand = dbCmd;
                MessageBox.Show("Successfully Inserted New Customer","New Customer",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
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
