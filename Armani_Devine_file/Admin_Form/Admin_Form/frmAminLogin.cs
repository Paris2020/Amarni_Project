using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//important imports
using AdminNamespace;
using System.Data.OleDb;


namespace Admin_Form
{
    public partial class frmAminLogin : Form
    {
         public frmAminLogin()
        {
            InitializeComponent();
        }

        //important variables

        private OleDbDataAdapter dbAdapter;
        private OleDbDataReader dbReader;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql,sql2;
        private string username, password;

        //declare class object
        Administrators admin;

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanstiate the class object
            admin = new Administrators();

            //splash screen
            frmWelcomeScreen welcome = new frmWelcomeScreen();
            welcome.Show();
            Thread.Sleep(10000);
            welcome.Hide();

            //set password fields to *
            txtUsername.Focus();
            txtPassword.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtConfirmPass.PasswordChar = '*';

            //set password and username fields to size
            txtPassword.MaxLength = 9;
            txtUsername.MaxLength = 30;
            txtNewPass.MaxLength = 9;
            txtConfirmPass.MaxLength = 9;

            //set labels and textboxes to invisible
            lblnewPass.Visible = false;
            lblConfirmPass.Visible = false;
            txtNewPass.Visible = false;
            txtConfirmPass.Visible = false;
            btnChangePassword.Hide();

        }

        //Login admin
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //try Connecting to database
            try
            {

                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" + 
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //assign the values to the properties
                username = txtUsername.Text;
                password = txtPassword.Text;

                sql = "SELECT Username,Password FROM Administrators WHERE Username='"
                        + username + "'" + "AND Password='" + password + "';";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbReader = dbCmd.ExecuteReader();
                if (dbReader.HasRows)
                {
                    dbReader.Read();

                    //get the values from the db
                    admin.Username = dbReader["Username"].ToString();
                    admin.Password = dbReader["Password"].ToString();

                }
                dbReader.Close();
                ValidateUsernameAndPassword(admin);
                dbConn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        


        //boolean method to validate username
        public void ValidateUsernameAndPassword(Administrators admin)
        {
            //validate username and password
            if (username.Length == 0)
            {
                txtUsername.BackColor = Color.White;
                lblErrorMsg.Text = "";
                lblErrorMsg.Text = "*";
            }
            else if(password.Length == 0)
            {
                lblErrorMsg2.Text = "";
                lblErrorMsg2.Text = "*";
                txtPassword.BackColor = Color.White;  
            }
            else if(admin.Username.Equals(username) && admin.Password.Equals(password))
            {
                lblErrorMsg.Text = "";
                lblErrorMsg2.Text = "";

                frmReceptionist recep = new frmReceptionist();
                recep.Show();
                
                frmAminLogin adminfrm = new frmAminLogin();
                adminfrm.Hide();
            }
            else if (admin.Username != username)
            {
                txtUsername.ForeColor = Color.Red;
                lblErrorMsg.Text = "INVALID USERNAME!!";
            }
            else if (admin.Password != password)
            {
                txtPassword.ForeColor = Color.Red;
                lblErrorMsg2.Text = "INVALID PASSWORD!!";
            }
        }


        // method to compare new password
        public void ComparePasswords(Administrators admin)
        {
            if(txtNewPass.Text.Equals(txtConfirmPass.Text)){

                try
                {
                    sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                    dbConn = new OleDbConnection(sConn);
                    dbConn.Open();

                    //assign the values to the properties
                    admin.NewPass = txtNewPass.Text;
                    admin.Username = txtUsername.Text;
                    admin.Password = txtPassword.Text;

                    sql2 = "UPDATE Administrators" + "SET Password='" + admin.NewPass + "'" + "WHERE (Username='" + admin.Username + "'" + "AND Password='" + admin.Password + "')";

                    dbCmd = new OleDbCommand();
                    dbCmd.CommandText = sql2;
                    dbCmd.Connection = dbConn;
                    dbCmd.ExecuteNonQuery();

                    dbAdapter = new OleDbDataAdapter();
                    dbAdapter.UpdateCommand = dbCmd;

                    MessageBox.Show("YOUR PASSWORD HAS BEEN SUCCESSFULLY CHANGED...", "Success Message");
                    dbConn.Close();
                 

                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }  
            }
            else{
                MessageBox.Show("YOUR PASSWORDS DO NOT MATCH!!!...", "Error Message");
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //display textboxes and labels
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            
            lblnewPass.Visible = true;
            lblConfirmPass.Visible = true;
            txtNewPass.Visible = true;
            txtConfirmPass.Visible = true;

            btnResetPassword.Hide();
            btnChangePassword.Show();
        }

        //change password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            txtNewPass.Focus();
            ComparePasswords(admin);
        }

        


        

    }
}