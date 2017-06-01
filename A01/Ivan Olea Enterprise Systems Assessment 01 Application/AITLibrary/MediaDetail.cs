using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class MediaDetail : PersistentData
    {
        private int mid;

        public MediaDetail(int id)
        {
            InitializeComponent();
            PersistentData.selectedMediaID = id;
        }

        private void MediaDetail_Load(object sender, EventArgs e)
        {
            // on load 
            // access database 
            // extract 
        }
    }
}
