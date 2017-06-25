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
        private static String pNullDate = new DateTime(2001, 01, 01).ToString(); //shoudl get from Business Layer
        private static DateTime pNullDateTime = new DateTime(2001, 01, 01);
        public static int pItemsToShow = 3; //should get from Business Layer
        private static int pLoanPeriod = 14;
        public static char sql_Wildcard = '%';
        public static int selectedMediaID = 0;

        public static int PLoanPeriod { get => pLoanPeriod; set => pLoanPeriod = value; }
        public static string PNullDate { get => pNullDate; set => pNullDate = value; }
        public static DateTime PNullDateTime { get => pNullDateTime; set => pNullDateTime = value; }

        //STYLING
        // LabelFont = Impact, 12pt, style=Italic
        // LabelColor = Chocolate

        // TextboxStyle = Impact, 14.25pt, style=Italic
        // TextboxBorderStyle = None

        // Buttons
        // ButtonText = Impact, 14.25pt, style=Italic
        // ButtonTextForeColor = DimGray;
        // ButtonBorderSize = 0
        // ButtonFlatStyle = Flat
        // ButtonTextAlign = MiddleCenter

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
            Console.WriteLine("Null Date: " + PNullDate +"\n");
            Console.WriteLine("Null Date Time: " + PNullDateTime + "\n");

        }

        private void PersistentData_Load(object sender, EventArgs e)
        {

        }

        protected void ClearData()
        {
            pUserID = 0;
            pUserLevel = 99;
            pUserName = "";
            pUserEmail = "";
            PLoanPeriod = 0;
        }

      

    }//end class
}
