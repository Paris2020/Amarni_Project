using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashSaleNamespace;


namespace Admin_Form
{
    public partial class CashSale : Form
    {
        public CashSale()
        {
            InitializeComponent();
        }

        CashSaleClass csc;
        
        
        private void CashSale_Load(object sender, EventArgs e)
        {
            csc = new CashSaleClass();
        }

        //increment total
        private void ckBoxWeaves_CheckedChanged(object sender, EventArgs e)
        {

            if (ckBoxBrazillian.Checked)
            {
               csc.Total += csc.WeavePrices[0];
            }
            if (ckBoxIndian.Checked)
            {
                csc.Total += csc.WeavePrices[1];
            }
            if (ckBoxPremium.Checked)
            {
                csc.Total += csc.WeavePrices[2];
            }
            if (ckBoxJoeDear.Checked)
            {
                csc.Total += csc.WeavePrices[4];
            }
            if (ckBoxLaceWeave.Checked)
            {
                csc.Total += csc.WeavePrices[5];
            }
            if (ckBoxDiva.Checked)
            {
                csc.Total += csc.WeavePrices[6];
            }
        }

        //increment total
        private void ckBoxHairstyles_CheckedChanged(object sender, EventArgs e)
        {

            if(ckBoxRelax.Checked){
                csc.Total += csc.HairstylePrices[0];
            }
            if(ckBoxBrush.Checked){
                csc.Total += csc.HairstylePrices[1];
            }
            if(ckBoxWash.Checked){
                csc.Total += csc.HairstylePrices[2];
            }
            if(ckBoxDye.Checked){
                csc.Total += csc.HairstylePrices[3];
            }
            if(ckBoxCheesesKop.Checked){
                csc.Total += csc.HairstylePrices[4];
            }
            if(ckBoxTreatment.Checked){
                csc.Total += csc.HairstylePrices[5];
            }
            if(ckBoxTreatment2.Checked){
                csc.Total += csc.HairstylePrices[6];
            }
            if(ckBoxPerm.Checked){
                csc.Total += csc.HairstylePrices[7];
            }
            if(ckBoxScurl.Checked){
                csc.Total += csc.HairstylePrices[8];
            }
        }

        //increment total
        private void ckBoxProducts_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBoxSoftNfree.Checked){
                csc.Total += csc.ProductPrices[0];
            }
            if(ckBoxBlackLikeMe.Checked){
                csc.Total += csc.ProductPrices[1];
            }
            if(ckBoxEasyWave.Checked){
                csc.Total += csc.ProductPrices[2];
            }
            if(ckBoxDarkNlovely.Checked){
                csc.Total += csc.ProductPrices[3];
            }
            if(ckBoxRevlon.Checked){
                csc.Total += csc.ProductPrices[4];
            }
            if(ckBoxBlackChic.Checked){
                csc.Total += csc.ProductPrices[5];
            }
        }

        //Calculate total - F9
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            CashSaleChange cashTotal = new CashSaleChange();
            cashTotal.Show();

            MessageBox.Show("Total: " + csc.Total.ToString("C") + "\nDiscount: " + csc.Discount_Total,"Total Purchasement",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
    }
}
