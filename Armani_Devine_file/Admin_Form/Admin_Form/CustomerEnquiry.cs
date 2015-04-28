using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important imports
using CustomerEnquiryNamespace;
using System.Data.OleDb;

namespace Admin_Form
{
    public partial class CustomerEnquiry : Form
    {
        public CustomerEnquiry()
        {
            InitializeComponent();
        }

        //important variables
        private OleDbDataReader dbReader;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        CustomerEnquiries cust;
        NewCustomer newCust;
        UpdateCustomer update;
        DeleteCustomer delete;

        private void CustomerEnquiry_Load(object sender, EventArgs e)
        {
            cust = new CustomerEnquiries();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try connecting to the database
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                cust.CustID = txtCustID.Text;
                sql = "SELECT c.Firstname,c.Surname,c.Age,c.Gender,c.CellphoneNumber,c.Address,cd.CardNumber,cd.AccountType FROM Customers c " +
                       " INNER JOIN CardDetails cd ON c.CustomerID = cd.CustomerID WHERE (c.CustomerID = '" + cust.CustID + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbReader = dbCmd.ExecuteReader();
                if (dbReader.HasRows)
                {
                    dbReader.Read();

                    //get the values from the db
                    lblFirstname2.Text = dbReader["Firstname"].ToString();
                    lblSurname2.Text = dbReader["Surname"].ToString();
                    lblGender2.Text = dbReader["Gender"].ToString();
                    lblAge2.Text = dbReader["Age"].ToString();
                    lblCell2.Text= dbReader["CellphoneNumber"].ToString();
                    lblAddress2.Text = dbReader["Address"].ToString();
                    lblCardNumber2.Text = dbReader["CardNumber"].ToString();
                    lblAccType2.Text = dbReader["AccountType"].ToString();
                }
                dbReader.Close();
                dbConn.Close();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        //Display window for neww customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            newCust = new NewCustomer();
            newCust.Show();
        }

        //Display window to update customer details
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            update = new UpdateCustomer();
            update.Show();
        }

        //Display window to delete customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete = new DeleteCustomer();
            delete.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        

        
    }
}
