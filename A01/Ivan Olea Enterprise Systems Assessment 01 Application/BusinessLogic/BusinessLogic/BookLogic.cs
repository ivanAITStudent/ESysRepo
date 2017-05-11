using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BookLogic
    {
        private BooksDataAccessObject _bookDAO;
        private List<BookModel> _books;

        private BooksDataSet.BookTableDataTable _bookTableSet;

        private BookModel _selectedBook;

        //constructor
        public BookLogic()
        {
            _bookDAO = new BooksDataAccessObject();
            _books = new List<BookModel>();
            _bookTableSet = new BooksDataSet.BookTableDataTable();

            _selectedBook = new BookModel(); 
        }

        public List<BookModel> GetBooks()
        {
            _books = new List<BookModel>();

            try
            {
                // get book data table from DAO
                _bookTableSet = _bookDAO.GetBooks();

                // set up presentation of data
                foreach (BooksDataSet.BookTableRow row in _bookTableSet.Rows)
                {
                    _books.Add(BookModel.Parse(row));
                }//end for

                // remove unwanted rows before passing table over
                _books = removeUnwantedRows(_books);
                
                return _books;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BookModel> GetCriteria_BookName_Author(String inputBookName, String inputAuthor)
        {
            _books = new List<BookModel>();
            try
            {
                _bookTableSet = _bookDAO.GetCriteria_BookName_Author(inputBookName, inputAuthor);

                foreach (BooksDataSet.BookTableRow row in _bookTableSet.Rows)
                {
                    _books.Add(BookModel.Parse(row));
                }//end for

                // remove unwanted rows before passing table over
                _books = removeUnwantedRows(_books);

                return _books;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // end method

        public List<BookModel> removeUnwantedRows(List<BookModel> list)
        {
            // Assumes that LIst is sorted!
            // Unwanted rows include 
                // duplicates without checked reserve or loans or 
                // duplicates without checked reserve or loans 
            
            // Algorithm
            // 1. scan through list of books
            // 2. if the ISBN of the currentBook equals the isbn of the nextBook then we have a duplicate so 
            // 3. remove duplicates (bookList, currentBook, nextBook)
            // 4.   if nextBook._isReserved is true
            // 5.       currentBook._isReserved is true
            // 6.   if nextBook._isOnLoan is true
            // 7.       currentBook._isOnLoan is true
            // 8.       delete nextBook


            //DEBUG List SORT
                foreach (BookModel m in list)
                {
                    Console.WriteLine("ISBN: " + m.ISBN);
                }
            //END DEBUG

            int index = 0;
            int length = list.Count;
            while (index <  length - 1)
            {


                BookModel currentBook = list[index];
                BookModel nextBook = list[index + 1];


                if (currentBook.ISBN == nextBook.ISBN)
                {
                    // move checked items up 
                    if (nextBook.Reserved == true)
                    {
                        currentBook.Reserved = true;
                    }

                    if (nextBook.OnLoan == true)
                    {
                        currentBook.OnLoan = true;
                    }

                    //delete next book
                    list.RemoveAt(index + 1);

                    //update where index remains at the current index and length is one less because of deleted item
                    length = list.Count;

                }
                else
                {
                    //update index and length
                    index++;
                    length = list.Count;
                }//end if 



            }

            return list;

        } //end method

        public List<BookModel> GetBookDetail(String _ISBN)
        {
            _books = new List<BookModel>();
            try
            {
                // get selected book using DAO
                _bookTableSet = _bookDAO.GetByISBN(_ISBN);

                // set up presetnation of data
                foreach (BooksDataSet.BookTableRow row in _bookTableSet.Rows)
                {
                    _books.Add(BookModel.Parse(row));
                }//end for

                return _books;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        ///* 
        public void ReserveBook(int userID, String _isbn, System.DateTime selectedDate)
        {
            try
            {
                int numberOfRowsAffected = _bookDAO.InsertIntoReserve(userID, _isbn, selectedDate);
                    Console.WriteLine("\nNumber of Rows Affected" + numberOfRowsAffected); //insert return an int
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //*/

    }//end class
}// end package
