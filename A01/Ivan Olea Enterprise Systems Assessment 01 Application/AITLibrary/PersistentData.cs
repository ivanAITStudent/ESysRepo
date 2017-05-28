using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public class PersistentData : Form
    {
        public static int pUserID;
        public static int pUserLevel;
        public static String pUserName;
        public static String pUserEmail;
        public static String pNullDate= "2001-01-01"; //shoudl get from Business Layer
        public static int pItemsToShow = 3; //should get from Business Layer
        public static int pLoanPeriod = 14;
        public static char sql_Wildcard = '%';
        public static int selectedMediaID;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PersistentData
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "PersistentData";
            this.Load += new System.EventHandler(this.PersistentData_Load);
            this.ResumeLayout(false);

        }

        private void PersistentData_Load(object sender, EventArgs e)
        {

        }

      

    }//end class
}
