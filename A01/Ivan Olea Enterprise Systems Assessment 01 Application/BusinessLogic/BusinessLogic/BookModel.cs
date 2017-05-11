using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BookModel
    {
       
        // fields (private variables) 

        private string _BookName; 
        private string _Author;
        private string _ISBN;
        private string _Category;
        private string _Language;
        private System.Int32 _PublishYear;
        private System.Int32 _Pages;
        private string _Publisher;
        private string _ReserveDate;
        private string _ReturnDate;
        private string _ActualReturnDate;


        private Boolean _isReserved;
        private Boolean _isOnLoan;

        private static String nullDate = "2000-01-01";

        // properties 
        public string BookName { get { return _BookName; } set { _BookName = value; } }
        public string Author { get { return _Author; } set { _Author = value; } }
        public string ISBN { get { return _ISBN; } set { _ISBN = value; } }
        public string Category { get { return _Category; } set { _Category = value; } }
        public string Language { get { return _Language; } set { _Language = value; } }
        public System.Int32 Year { get { return _PublishYear; } set { _PublishYear = value; } }
        public System.Int32 Pages { get { return _Pages; } set { _Pages = value; } }
        public string Publisher { get { return _Publisher; } set { _Publisher = value; } }
        public string ReserveDate { get { return _ReserveDate; } set { _ReserveDate = value; } }
        public string ReturnDate { get { return _ReturnDate; } set { _ReturnDate = value; } }
        public string ActualReturnDate { get { return _ActualReturnDate; } set { _ActualReturnDate = value; } }

        public Boolean Reserved { get { return _isReserved; } set { _isReserved = value; } }
        public Boolean OnLoan { get { return _isOnLoan; } set { _isOnLoan = value; } }

        public String NullDate { get { return nullDate; } set { nullDate = value;} }

        //ststic parsing method 
        public static BookModel Parse(BooksDataSet.BookTableRow rowFromDataSet)
        {
            if (rowFromDataSet == null)
            {
                return null;
            }

            BookModel modelData = new BookModel();
                modelData._ISBN = rowFromDataSet.ISBN;
                modelData.BookName = rowFromDataSet.BookName;
                modelData.Year = rowFromDataSet.PublishYear;
                modelData.Pages = rowFromDataSet.Pages;
                modelData.Author = rowFromDataSet.AuthorName;
                modelData.Publisher = rowFromDataSet.Publisher;
                modelData.Category = rowFromDataSet.CategoryName;
                modelData.Language = rowFromDataSet.LanguageName;
                // In order to capture date formats comming from the DB
                // Convert them to strings for display in columns
                modelData.ReserveDate = convertToString("ReservedDate", rowFromDataSet);
                modelData.ReturnDate = convertToString("ReturnDate", rowFromDataSet);
                modelData.ActualReturnDate = convertToString("ActualReturnDate", rowFromDataSet);

                
                //Set is Reserved
                    modelData._isReserved = checkIfReserved("ReservedDate", rowFromDataSet); // book is reserved reserve date exists and the current date is less than or equal to reserve date
                    
                //Set On loan 
                    modelData._isOnLoan = checkIfOnLoan("ReturnDate", rowFromDataSet); // book is on loan if the current date is less than or equal to return date AND actual return 

            return modelData;
        }

        private static String convertToString(String colName, BooksDataSet.BookTableRow row)
        {
            String date = "";
            DateTime cellValue;

            // get column date value
            if (row[colName] == DBNull.Value)
            {
                cellValue = DateTime.Parse(nullDate);
                    //DEBUG 
                        Console.WriteLine(DateTime.Parse(nullDate)); //END DEBUG
            }
            else
            {
                cellValue = (DateTime)row[colName];
                    //DEBUG 
                        Console.WriteLine((DateTime)row[colName]); //END DEBUG
            }

            date = cellValue.ToShortDateString();

            return date;
        }

        public static Boolean checkIfReserved(String colName, BooksDataSet.BookTableRow row){
            
            DateTime cellValue;

            // get column date value
                if (row[colName] == DBNull.Value)
                {
                    cellValue = DateTime.Parse(nullDate);
                        //DEBUG 
                            Console.WriteLine(DateTime.Parse(nullDate)); //END DEBUG
                }
                else
                {
                    cellValue = (DateTime)row[colName];
                        //DEBUG 
                            Console.WriteLine((DateTime)row[colName]); //END DEBUG
                }
            

            DateTime currentDate = DateTime.Today;

            int colmIndex = row.Table.Columns.IndexOf(colName);

            //DEBUG
                Console.WriteLine("Check if Reserved" + "\n"
                                + "Col: " + colmIndex + " - " + row.Table.Columns[colmIndex] + "\n"
                                + "Cell Date: \t" + row[colName].ToString() + "\n"
                                + "Converted Date: \t" + cellValue.ToString() + "\n"
                                + "Current Date: \t" + currentDate);
            //END DEBUG
                
            //if cell value is empty or NULL then 
                // no reservation exists 
                // therefore book is not reserved
                //return false;
                if (cellValue.Equals(DateTime.Parse(nullDate)))
                {
                    return false;
                }
                //else if cell has a value and the current date > cell value
                    // reservation exists
                        // but the current date is after the reservation date
                            // therfore book is not reserved 
                                // return false;
                else if (currentDate.CompareTo(cellValue) > 0)
                {
                    return false;
                }

                // else if cell has a value and the current date <= cell value
                    // reservation exists
                         // and the current date is less than the reservation date
                            // therfore book has a reservation
                                //return true
                else if (currentDate.CompareTo(cellValue) <= 0)
                {
                    return true;
                }
                // else cell value is undefined
                    // throw error 
                    //return false;
                else
                {
                    //throw not implemented
                    Console.WriteLine("Undefined Value in Cell");
                    return false; 
                }
        }

        public static Boolean checkIfOnLoan(String colName, BooksDataSet.BookTableRow row)
        {
            DateTime cellValue;

            // get column date value
                if (row[colName] == DBNull.Value)
                {
                    cellValue = DateTime.Parse(nullDate);
                        //DEBUG 
                            Console.WriteLine(DateTime.Parse(nullDate)); //END DEBUG
                }
                else
                {
                    cellValue = (DateTime)row[colName];
                        //DEBUG 
                            Console.WriteLine((DateTime)row[colName]); //END DEBUG
                }
            


            DateTime currentDate = DateTime.Today;

            int colmIndex = row.Table.Columns.IndexOf(colName);

            Console.WriteLine("Check If On Loan" + "\n"
                                + "Col: " + colmIndex + " - " + row.Table.Columns[colmIndex] + "\n"
                                + "Cell Date: \t" + row[colName].ToString() + "\n"
                                + "Converted Date: \t" + cellValue.ToString() + "\n"
                                + "Current Date: \t" + currentDate);
            // if cell value is empty or NULL then 
                // no loan exists 
                    // therefore book is not on loan
                        //return false;
            if (cellValue.Equals(DateTime.Parse(nullDate)))
            {
                //DEBUG 
                    Console.WriteLine("cellValue EQUALS nullDate:\n " 
                        + "cellValue: " + cellValue + ", nullDate: " + nullDate + "\n"
                        + "Result: " + cellValue.Equals(DateTime.Parse(nullDate)) + "\n"
                        );
                //End Debug

                return false;
            }

            // else if cell has a value and the current date > cell value
                // a laon exists
                    // and the book should have been returned
                        // so must check current date agaisnt the actual return date in case book is overdue (has not been returned when required)
                            //check if book as been returned ("ActualReturnDate", row) 
                                // if book has NOT been returned 
                                    //return true; // book is on loan
                                // else book has been returned
                                    // return false; // book is NOT on loan
            else if (currentDate.CompareTo(cellValue) > 0)
            {
                //DEBUG 
                Console.WriteLine("currentDate COMPARETO cellValue > 0 :\n "
                    + "currentDate: " + currentDate + ", cellValue: " + nullDate + "\n"
                    + "Result: " + (currentDate.CompareTo(cellValue) > 0) + "\n"
                    );
                //End Debug

                colName = "ActualReturnDate";
                if (! (hasBeenReturned(colName, row)) )
                {
                    //DEBUG
                    Console.WriteLine("hasBeenReturned(colName, row)"
                                        + "colName" + colName + "" + row.ToString() + "\n"
                                        + "Result: " + hasBeenReturned(colName, row) + "\n"
                                        );
                    // END DEBUG

                    return true; // book is on loan
                }
                else
                {
                    //DEBUG
                    Console.WriteLine("hasBeenReturned(colName, row)"
                                        + "colName" + colName + "" + row.ToString() + "\n"
                                        + "Result: " + hasBeenReturned(colName, row) + "\n"
                                        );
                    // END DEBUg
                    
                    return false; 
                }
            }

            // else if cell has a value and the current date <= cell value
                // a loan exists
                    // and is still on loan
                        // however must check current date agaist actual return date in case the book has been returned early
                            // check if book as been returned ("ActualReturnDate", row) 
                                // if book has NOT been returned 
                                    //return true; // book is on loan
                            // else book has been returned
                                    // return false; // book is NOT on loan

            else if (currentDate.CompareTo(cellValue) <= 0)
            {
                colName = "ActualReturnDate";
                if (!(hasBeenReturned(colName, row)))
                {
                    return true; // book is on loan
                }
                else
                {
                    return false;
                }
            }
            // else cell value is undefined
                // throw error 
                    //return false;
            else
            {
                //throw not implemented
                Console.WriteLine("Undefined Value in Cell");
                return false;
            }
        }

        public static Boolean hasBeenReturned(String colName, BooksDataSet.BookTableRow row) // it is assumed that this functin is called IFF there is a loan 
        {
            // NOTE: an actual return date can not be greater than the current date as you can not physically return a date in the future (see "Back to the Future" Trilogy for an explanation)
            
            DateTime cellValue;

            // get column date value
                if (row[colName] == DBNull.Value)
                {
                    cellValue = DateTime.Parse(nullDate);
                        //DEBUG 
                            Console.WriteLine(DateTime.Parse(nullDate)); //END DEBUG
                }
                else
                {
                    cellValue = (DateTime)row[colName];
                        //DEBUG 
                            Console.WriteLine((DateTime)row[colName]); //END DEBUG
                }

            DateTime currentDate = DateTime.Today;

            int colmIndex = row.Table.Columns.IndexOf(colName);

            Console.WriteLine("Check If Returned" + "\n"
                                + "Col: " + colmIndex + " - " + row.Table.Columns[colmIndex] + "\n"
                                + "Cell Date: \t" + row[colName].ToString() + "\n"
                                + "Converted Date: \t" + cellValue.ToString() + "\n"
                                + "Current Date: \t" + currentDate);

            // if cell value is empty or NULL then 
                // book has not been returned 
                    //return false;
                if ( cellValue.Equals(DateTime.Parse(nullDate)) )
                {
                    return false;
                }

            // else if cell has a value AND currentDate > cellValue
                // book has been returned
                    //return true
                else if (currentDate.CompareTo(cellValue) > 0)
                {
                    return true;
                }

            // else if cell has a value AND currentDate <= cellValue
                // an error has occurred, data intergrity has been compromised
                    // an actual return date can not be greater than the current date (see "Back to the Future" Trilogy for a reason and a consequence of such a thing happening)
                        // throw data intergrity has been compromised
                            //return false;
                else if (currentDate.CompareTo(cellValue) <= 0)
                {
                    //throw exception not implemented
                    Console.WriteLine("Error: Return Date Set in the Future");
                    return false;
                }
                else
                {
                    //throw exception not implemented
                    Console.WriteLine("Error: Value Undefined");
                    return false;
                }

            
        }

    } //end class
} //end namespace
