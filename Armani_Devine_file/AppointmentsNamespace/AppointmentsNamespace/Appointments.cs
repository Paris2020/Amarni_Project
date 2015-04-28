using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppointmentsNamespace
{
    public class Appointments
    {
        //Variables
        private int appID;
        private String appDate, empID, appTime, custID, treatment;

        //Contructor
        public Appointments()
        {
            appID = 0;
            appDate = "";
            appTime = "";
            custID = "";
            treatment = "";
            empID = "";
        }

        //properties
        public int AppID
        {
            get { return appID; }
            set { appID = value; }
        }

        public string AppDate
        {
            get { return appDate; }
            set { appDate = value; }
        }

        public string AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }

        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        public string Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }
    }
}
