using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceptionNamespace
{
    public class Receptionists
    {
        private int recepID;
        private string username, password;
        private string newPass, confirmPass;
       
        //constructor
        public Receptionists()
        {
            recepID = 0;
            username = "";
            password = string.Empty;
            newPass = string.Empty;
            confirmPass = "";
        }

        //properties
        public int RecepID
        {
            get { return recepID; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
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

       
    }
}
