using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CashCardDetailsNamespace;

namespace Admin_Form
{
    public partial class CashCardDetails : Form
    {
        public CashCardDetails()
        {
            InitializeComponent();
        }

        //important variables

        
        private OleDbDataReader dbReader;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;

        CardDetailsClass cashCard;
        int pin;

        private void CashCardDetails_Load(object sender, EventArgs e)
        {
            cashCard = new CardDetailsClass();
            txtPIN.PasswordChar = '*';
            txtPIN.MaxLength = 5;
        }

        private void btnEnterPIN_Click(object sender, EventArgs e)
        {
            try
            {
                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //Save the data
                cashCard.Pin = int.Parse(txtPIN.Text.ToString());

                sql = "SELECT Pin FROM CardDetails WHERE (Pin= " + cashCard.Pin + " AND AccountType='" + cashCard.AccType + "');";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbReader = dbCmd.ExecuteReader();
                if (dbReader.HasRows)
                {
                    dbReader.Read();
                    pin = int.Parse(dbReader["Pin"].ToString());
                    ValidatePIN(cashCard);
                }
                ValidatePIN(cashCard);
                dbReader.Close();
                dbConn.Close();
              
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        //Validate the PIN
        private void ValidatePIN(CardDetailsClass cashCard){

            if(pin.Equals(cashCard.Pin)){
                MessageBox.Show("Authorization Passed...", "Authorize Card PIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Authorization Failed...", "Authorize Card PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //Choose acc type
        private void rbtnAccType_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnCheque.Checked){
                cashCard.AccType = rbtnCheque.Text.ToString();
            }
            else{
                cashCard.AccType= rbtnSavings.Text.ToString();
            }
        }
    }
}
