using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important

using System.Data.OleDb;

namespace Admin_Form
{
    public partial class frmPriceLookup : Form
    {
        //important variables
        private OleDbDataAdapter dbAdapter;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private DataSet dbSet;

        private string sConn;
        private string sql;

        public frmPriceLookup()
        {
            InitializeComponent();
        }

        private void btnLoadProductPrices_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                sql = "SELECT * FROM Products;";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Products");

                dataGrid1.SetDataBinding(dbSet, "Products");
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHairstyles_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                sql = "SELECT HairstyleID, Description,Price FROM Hairstyles;";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCmd;
                dbSet = new DataSet();
                dbAdapter.Fill(dbSet, "Hairstyles");

                dataGrid1.SetDataBinding(dbSet, "Hairstyles");
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPriceLookup_Load(object sender, EventArgs e)
        {

        }

       

        

        





    }
}
