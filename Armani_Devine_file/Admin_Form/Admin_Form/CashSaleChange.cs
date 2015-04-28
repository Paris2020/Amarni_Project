using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashSaleNamespace;
using CashSaleChangeNamespace;

namespace Admin_Form
{
    public partial class CashSaleChange : Form
    {
        public CashSaleChange()
        {
            InitializeComponent();
        }

        //classes
        CashSaleClass csc;
        CashSale cash;
        CashChange changeC;

        Double discount_total = 0,change = 0;


        private void CashSaleTotal_Load(object sender, EventArgs e)
        {
            //Hide the text box of the first radio button
            txtCash.Hide();
            txtTotal.Show();
            txtTotal.Select();  //To enter the total of the customer


            csc = new CashSaleClass();
            cash = new CashSale();
            changeC = new CashChange();
            
        }

        //
        private void rbtnCashOrCard_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rbtnCash.Checked){

                discount_total = double.Parse(txtTotal.Text);

                txtTotal.Hide();
                txtCash.Show();
                txtCash.Select();   //to enter the cash the customer has
                rbtnCard.Enabled = false;
                txtCard.Enabled = false;
 
            }
            else{
                txtTotal.Enabled = false;
                txtCard.Select();   //to enter the cash the customer has
                rbtnCash.Enabled = false;
                txtCash.Enabled = false;
                
            }
        }

        //Display Change
        private void CalculateChange()
        {
            change = changeC.Cust_Money - discount_total;
            MessageBox.Show("Change: " + change.ToString("C"), "Calculating Change");
        }

        //Continue transaction
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnCash.Checked)
            {
                changeC.Cust_Money = double.Parse(txtCash.Text.ToString());
                CalculateChange();
            }
            else
            {
                CashCardDetails cashCard = new CashCardDetails();
                cashCard.Show();
            }
        }

        //Cancel transaction
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
