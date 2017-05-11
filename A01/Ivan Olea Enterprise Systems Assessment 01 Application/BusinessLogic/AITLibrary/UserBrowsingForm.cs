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
    public partial class BookBrowsingForm : PersistentData
    {
        DataGridViewRow selectedRow;
        String          selectedISBN;

        public BookBrowsingForm()
        {
            InitializeComponent();
        }

        private void button_ShowAllBooks_Click(object sender, EventArgs e)
        {
            BookLogic bl = new BookLogic();

            //clear message box
                label_Message.Text = ""; 

            //clear view
                dataGridView_BookBrowsing.Refresh();

            //populate grid view with data
                dataGridView_BookBrowsing.DataSource = bl.GetBooks();
        }


        private void button_SearchWithCriteria(object sender, EventArgs e)
        {
            BookLogic bl = new BookLogic();
            string wildCard = "%";

            string _bookStringToSearch = textBox_ByBookName.Text;
            string _authorToSearch = textBox_ByAuthorName.Text;



            // if an input is NOT null then add wildcards
            if (_bookStringToSearch != "")
            {
                _bookStringToSearch = wildCard + _bookStringToSearch + wildCard;
            }
            if (_authorToSearch != "")
            {
                _authorToSearch = wildCard + _authorToSearch + wildCard;
            }
            //

            //clear message box
            label_Message.Text = "";

            //clear view
            dataGridView_BookBrowsing.Refresh();

            //check validity
            //not implemented

            List<BookModel> _books = bl.GetCriteria_BookName_Author(_bookStringToSearch, _authorToSearch);

            if (_books.Count > 0)
            {
                dataGridView_BookBrowsing.DataSource = _books;
            }
            else
            {
                dataGridView_BookBrowsing.Refresh();
                label_Message.Text = "No Books Found";
            }
        }

        private void button_BookDetails_Click(object sender, EventArgs e)
        {
            // open book details window with selected ISBN
                //start new thread with new form
                    System.Threading.Thread thread1 = new System.Threading.Thread(new System.Threading.ThreadStart(openBookDetail_GUI));
                        thread1.Start();
                //destroy old thread
                //this.Close(); 
                
                
        }

        private void dataGridView_BookBrowsing_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_BookBrowsing.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_BookBrowsing.SelectedCells[0].RowIndex;

                selectedRow = dataGridView_BookBrowsing.Rows[selectedrowindex];
                
                selectedISBN = Convert.ToString(selectedRow.Cells["ISBN"].Value);

                

                //pass ISBN to persistentData
                    shareISBN = selectedISBN;
                        Console.WriteLine("Selected Row Index is: " + selectedrowindex + "\n"
                                + "ISBN Value is: " + shareISBN);
                    

            }
        }

        private void openBookDetail_GUI()
        {
            Application.Run(new BookDetailsForm());
        }
       

 
    }//end class

}
