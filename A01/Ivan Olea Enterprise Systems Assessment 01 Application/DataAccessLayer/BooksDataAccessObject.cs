using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.BooksDataSetTableAdapters;

namespace DataAccessLayer
{
    public class BooksDataAccessObject
    {
        //we create two variable for a User Data Set and Table Adapter
            private BooksDataSet            _bookDataSet;
            private BookTableTableAdapter   _bookTableAdapter;
            private TabReservedTableAdapter _reserveBookTableAdapter;

        //constructor method to instantiate private variables
            public BooksDataAccessObject()
            {
                _bookDataSet            = new BooksDataSet();
                _bookTableAdapter       = new BookTableTableAdapter();
                _reserveBookTableAdapter = new TabReservedTableAdapter();
            }

        //create a Get functions that returns a DATASET from TABBOK Info and is captured in the variable _bookDataSet 
            public BooksDataSet.BookTableDataTable GetBooks()
            {
                try
                {
                    _bookDataSet.BookTable.Clear();
                    _bookDataSet.EnforceConstraints = false;

                    //Debug
                    for (int i = 0; i < _bookDataSet.BookTable.Columns.Count; i++)
                    {
                        Console.WriteLine("Book Model Column Name: " + _bookDataSet.BookTable.Columns[i].ToString());
                    }

                    _bookTableAdapter.FillAll(_bookDataSet.BookTable);
                    //END DEBUG


                    return _bookDataSet.BookTable;
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public BooksDataSet.BookTableDataTable GetCriteria_BookName_Author(String inputBookName, String inputAuthor)
            {
                try
                {
                    //_bookDataSet.BookTable.Clear();
                    //_bookDataSet.EnforceConstraints = false;
                    _bookTableAdapter.FillByBookORAuthor(_bookDataSet.BookTable, inputBookName, inputAuthor);
                    return _bookDataSet.BookTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }//end method

            public BooksDataSet.BookTableDataTable GetByISBN(String _isbn)
            {
                try
                {
                    _bookDataSet.BookTable.Clear(); // clear datatable 
                    _bookDataSet.EnforceConstraints = false; // relax contraints on data types
                    _bookTableAdapter.FillByISBN(_bookDataSet.BookTable, _isbn); // query data

                    return _bookDataSet.BookTable; // return table
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }//end method

            public int InsertIntoReserve(int userID, String _isbn, System.DateTime _selectedDate)
            {
               
                String reserveDate = _selectedDate.ToString();
                    //DEBUG
                        Console.WriteLine("reserveDate = " + reserveDate  + " : " + "_selectedDate = " + _selectedDate);
                            //END DEBUG

                        try
                        {
                            int recordsAffected = _reserveBookTableAdapter.InsertIntoReserve_Query(userID, _isbn, reserveDate); // query data
                            return recordsAffected;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
            }
    }//end class
}//end package
