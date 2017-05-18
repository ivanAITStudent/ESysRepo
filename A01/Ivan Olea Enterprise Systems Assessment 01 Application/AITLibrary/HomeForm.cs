using System;

namespace AITLibrary
{
    public partial class HomeForm : PersistentData
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //hide and unhide details based on user level
            if(pUserLevel == 1) //user view
            {
                return_button.Visible = false;
            }
            else if (pUserLevel == 2) // supervisor view
            {

            }
            else if (pUserLevel == 3) // Admin view
            {
            }
        }

    }
}
