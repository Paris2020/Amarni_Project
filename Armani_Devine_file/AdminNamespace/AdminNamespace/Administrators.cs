using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminNamespace
{
    public class Administrators
    {
        private int adminID;
        private string username, password;
        private string newPass, confirmPass;

        public Administrators(){
            adminID = 0;
            username = "";
            password = "";
            newPass = "";
            confirmPass ="";
        }

        //Read only properties
        public int AdminID{
            get{ return adminID; }
        }

        public string Username
        {
            get
            {return username;}
            set
            {username = value;}
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string NewPass
        {
            get { return newPass; }
            set { newPass = value; }
        }

        public string ConfirmPass
        {
            get { return confirmPass; }
            set { confirmPass = value; }
        }

        //Override ToString() method
        public override string ToString()
        {
            return username + "WELCOME BACK";
        }

    }
}
