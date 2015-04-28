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
using MainMenuNamespace;
using ReceptionNamespace;


namespace Admin_Form
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        //Classes
        MainMenuClass main;
        CashSale cash;
        CustomerEnquiry cust;
        Reports re;
        frmAppointments app;

        private void frmMain_Load(object sender, EventArgs e)
        {
             main = new MainMenuClass();

             //hide the recep form
             frmReceptionist recep = new frmReceptionist();
             recep.Hide();

            //load menu into list box
            for (int x = 0; x < main.Menu.Length;x++ )
            {
                lstBxMenu.Items.Add(main.Menu[x]);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnPriceLookup_Click(object sender, EventArgs e)
        {
            frmPriceLookup priceL = new frmPriceLookup();
            priceL.Show();
        }


        private void lstBxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBxMenu.SelectedItem.Equals("Cash Sale")){
                cash = new CashSale();
                cash.Show();
            }
            else if(lstBxMenu.SelectedItem.Equals("Customer Enquiry")){
                cust = new CustomerEnquiry();
                cust.Show();
            }
            else if (lstBxMenu.SelectedItem.Equals("Appointments"))
            {
                app = new frmAppointments();
                app.Show();
            }
            else{
                re = new Reports();
                re.Show();
            }
        }

        
        
    }
}
