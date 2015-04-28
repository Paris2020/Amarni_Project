using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//important imports
using AdminNamespace;
using System.Data.OleDb;
using ReceptionNamespace;

namespace Admin_Form
{
    public partial class frmReceptionist : Form
    {
        
        public frmReceptionist()
        {
            InitializeComponent();
        }

        //important variables

        private OleDbDataAdapter dbAdapter;
        private OleDbDataReader dbReader;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConn;
        private string sql;
        private string username, password;
       

        Receptionists recep;

        private void Receptionist_Load(object sender, EventArgs e)
        {

            //instanstiate the class object
            recep = new Receptionists();

            

            txtUsername2.Focus();
            txtPassword2.PasswordChar = '*';
            txtNewPass2.PasswordChar = '*';
            txtConfirmPass2.PasswordChar = '*';
            txtPassword2.MaxLength = 9;
            txtUsername2.MaxLength = 30;
            txtNewPass2.MaxLength = 9;
            txtConfirmPass2.MaxLength = 9;

            lblNewPass2.Visible = false;
            lblConfirmPass2.Visible = false;
            txtNewPass2.Visible = false;
            txtConfirmPass2.Visible = false;
            btnChangePassword2.Hide();
            
        }

        
        private void btnLogin2_Click(object sender, EventArgs e)
        {
            //try Connecting to database
            try
            {

                sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source = ArmaniDevine.accdb";

                dbConn = new OleDbConnection(sConn);
                dbConn.Open();

                //assign the values to the properties
                username = txtUsername2.Text;
                password = txtPassword2.Text;

                sql = "SELECT Username,Password FROM Receptionists WHERE Username='"
                        + username + "'" + "AND Password='" + password + "';";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbReader = dbCmd.ExecuteReader();
                if (dbReader.HasRows)
                {
                    dbReader.Read();

                    //get the values from the db
                    recep.Username = dbReader["Username"].ToString();
                    recep.Password = dbReader["Password"].ToString();

                }
                dbReader.Close();
                ValidateUsernameAndPassword(recep);
                dbConn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        //boolean method to validate username
        public void ValidateUsernameAndPassword(Receptionists recep)
        {
            //validate username and password
            if (username.Length == 0)
            {
                txtUsername2.BackColor = Color.White;
                lblErrMsg3.Text = "";
                lblErrMsg3.Text = "*";
            }
            else if (password.Length == 0)
            {
                lblErrMsg4.Text = "";
                lblErrMsg4.Text = "*";
                txtPassword2.BackColor = Color.White;
            }
            else if (recep.Username.Equals(username) && recep.Password.Equals(password))
            {
                lblErrMsg3.Text = "";
                lblErrMsg3.Text = "";

                //show main menu form
                frmMain main = new frmMain();
                main.Show();

            }
            else if (recep.Username != username)
            {
                txtUsername2.ForeColor = Color.Red;
                lblErrMsg3.Text = "INVALID USERNAME!!";
            }
            else if (recep.Password != password)
            {
                txtPassword2.ForeColor = Color.Red;
                lblErrMsg4.Text = "INVALID PASSWORD!!";
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


       

        // method to compare new password
        public void ChangePasswords(Receptionists recep)
        {
            if (txtNewPass2.Text.Equals(txtConfirmPass2.Text))
            {

                try
                {
                    sConn = "Provider = Microsoft.ACE.OLEDB.12.0;" +
                       "Data Source = ArmaniDevine.accdb";

                    dbConn = new OleDbConnection(sConn);
                    dbConn.Open();

                    //assign the values to the properties
                    recep.NewPass = txtNewPass2.Text;
                    recep.Username = txtUsername2.Text;
                    recep.Password = txtPassword2.Text;

                    sql = "UPDATE Receptionists SET Password='" + recep.NewPass + "' WHERE (Username='" + recep.Username + "' AND Password='" + recep.Password + "')";

                    dbCmd = new OleDbCommand();
                    dbCmd.CommandText = sql;
                    dbCmd.Connection = dbConn;
                    dbCmd.ExecuteNonQuery();

                    dbAdapter = new OleDbDataAdapter();
                    dbAdapter.UpdateCommand = dbCmd;

                    MessageBox.Show("YOUR PASSWORD HAS BEEN SUCCESSFULLY CHANGED...", "Success Message");
                    dbConn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("YOUR PASSWORDS DO NOT MATCH!!!...", "Error Message");
                txtNewPass2.Text = "";
                txtConfirmPass2.Text = "";
            }
        }

        

        private void btnResetPassword2_Click(object sender, EventArgs e)
        {
            lblNewPass2.Visible = true;
            lblConfirmPass2.Visible = true;
            txtNewPass2.Visible = true;
            txtConfirmPass2.Visible = true;

            btnResetPassword2.Hide();
            btnChangePassword2.Show();
        }

        private void btnChangePassword2_Click(object sender, EventArgs e)
        {
            txtNewPass2.Focus();
            ChangePasswords(recep);
        }



    }
}
