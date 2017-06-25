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
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public MyMessageBox(int iconIndex, string message)
        {
            InitializeComponent();
            changeIcon(iconIndex);
            changeMessage(message);
        }

        private void changeMessage(string message)
        {
            body_lbl.Text = message;
        }

        public MyMessageBox(int iconIndex, string message, string title)
        {
            InitializeComponent();
            changeIcon(iconIndex);
            changeMessage(message);
            changeTitle(title);
        }

        private void changeTitle(string title)
        {
            title_lbl.Text = title;
        }

        public MyMessageBox(int iconIndex, string message, string title, string footer)
        {
            InitializeComponent();

        }


        private void changeIcon(int index)
        {
            MessageIcon.Image = MyMessageImageList.Images[index];
        }

        public void getIcons()
        {
            for (int i = 0; i < MyMessageImageList.Images.Count; i++)
            {
                MyMessageBox m = new MyMessageBox(i, i.ToString(), "Icons");

            }

        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void MessageIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
