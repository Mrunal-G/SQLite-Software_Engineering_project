﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Assignment
{
    class dbAccess
    {
        public static string sqlQuery(string sqlstring)
        {
            string queryreturn = "";
            // queryreturn will, eventually, store the result of our query.

            
            // Connection string to access the database, provider will be different for different DBs, often includes usernames and passwords as well.
        
            string strAccessConn = "Data Source=courseworkdb.db";
            DataSet myDataSet = new DataSet();
            // Sets up the .net Dataset
            SQLiteConnection myAccessConn = null;
            try
            // Here we are actually trying to connect to the DB so we use try/catch so that we can get information back if it goes wrong.
            {
                myAccessConn = new SQLiteConnection(strAccessConn);
                SQLiteCommand myAccessCommand = new SQLiteCommand(sqlstring, myAccessConn);
                // Specifying the command to send the sqlstring from Form1 to the DB specified in myAccessConn, all the searching is carried out by the DB.


                //reader
               // SQLiteDataReader myReader;
                //myReader = myAccessCommand.ExecuteReader();
            
                // end of reader

                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(myAccessCommand);
                myAccessConn.Open();
                // Send the SQL Query
                myDataAdapter.Fill(myDataSet, "TestResults");
                // Put the DBs response in a DataSet called TestResults.
                myAccessConn.Close();
                //Close the Connection.

            }

            catch (Exception ex)
            {
                return ex.ToString();
                // Return an error if it went horribly wrong.
                // Typical errors returned would be if we can't find the DB or if we wrote the SQL wrong.

            }

            DataColumnCollection drc = myDataSet.Tables["TestResults"].Columns;

            DataRowCollection dra = myDataSet.Tables["TestResults"].Rows;
           

            foreach (DataRow dr in dra)
            {
                foreach (DataColumn dc in drc)
                {
                    queryreturn = queryreturn + dr[dc] + "".PadRight(7);
                }

                queryreturn = queryreturn + "\r\n";

            }

            // Two loops, first one moves through every row in the returned results, second goes through every column.
            // We write that into a string, seperating the column values with a tab "\t" and seperating rows with a new line "\r\n"




            return queryreturn;

        } // end of sqlQuery




        public static string sqlChange(string sqlstring)
        {




            string strAccessConn = "Data Source=courseworkdb.db";
            SQLiteConnection myAccessConn = null;
            try
            // Here we are actually trying to connect to the DB so we use try/catch so that we can get information back if it goes wrong.
            {
                myAccessConn = new SQLiteConnection(strAccessConn);
                SQLiteCommand myAccessCommand = new SQLiteCommand(sqlstring, myAccessConn);
                // Specifying the command to send the sqlstring from Form1 to the DB specified in myAccessConn, all the searching is carried out by the DB.




                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(myAccessCommand);
                myAccessConn.Open();
                // Send the SQL Query
                myAccessCommand.ExecuteNonQuery();
                // This line tells the database to carry out a non select SQL command, it will make sure the command is run.
                myAccessConn.Close();
                //Close the Connection.

                return ("Ok");
                // If we got this far the command was accepted and no errors were thrown.


            }

            catch (Exception ex)
            {
                return ex.ToString();
                // Return an error if it went horribly wrong.
                // Typical errors returned would be if we can't find the DB or if we wrote the SQL wrong.

            }













        } // end of sqlchange



    }
}