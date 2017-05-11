using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class TestRetrieval : PersistentData
    {
        public TestRetrieval()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogic u1 = new UserLogic();
            try
            {
                dataGridView1.DataSource = u1.GetAllUserDetails(pUserLevel);
            }
            catch (MLMSExceptions ex)
            {
                Console.WriteLine(ex);
                label1.Text = ex.Message;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {   
            MediaLogic _mediaLogic = new MediaLogic();

            // create a media model object to house criteria
                MediaModel criteriaList = new MediaModel();
                criteriaList.Director = director_tb.Text;
                criteriaList.Title = title_tb.Text;
            
            // convert empty year to a 0 value
            if (director_tb.Text == "")
            {
                criteriaList.Director = "null";
            }
            else
            {
                criteriaList.Director = director_tb.Text;
            }

            if (title_tb.Text.Equals(""))
            {
                criteriaList.Title = "null";
            }
            else
            {
                criteriaList.Title = title_tb.Text;
            }

                if (year_tb.Text.Equals(""))
                {
                    criteriaList.PublishYear = 0;
                }
                else
                {
                    criteriaList.PublishYear = Int32.Parse(year_tb.Text);
                }

            //STUB Check criteria
                string criteriaCaptured = "Criteria: " + criteriaList.Director + " " + criteriaList.Title + " " + criteriaList.PublishYear;
                    label1.Text = criteriaCaptured;
            //
            
            
            dataGridView1.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);

            //dataGridView1.Columns[0].Visible = false; //hide MediaID

        }
    }
}
