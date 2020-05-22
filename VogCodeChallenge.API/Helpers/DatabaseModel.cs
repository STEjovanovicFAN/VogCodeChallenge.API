using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Helpers
{
    public class DatabaseModel
    {
        /*
         * 1. Create connection to database here 
         * 2. Stored procedures are already created in the database so call them here
         * 3. Basic error handling in case the execution of the stored procedure goes wrong 
         */


        public string getconnectionstring()
        {
            //get a connection string from project parameters or from other sources  
            return "";
        }
        public MySqlConnection GetSQLConnection()
        {
            if (getconnectionstring() == null)
                return null;
            return new MySqlConnection(getconnectionstring());
        }

        public DataTable Execute_Data_Query_Store_Procedure(string procedureName, MySqlParameter[] parameters)
        {
            if (GetSQLConnection() == null)
                return null;

            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(procedureName, GetSQLConnection());
            sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                //execute stored procedure here 
            }
            catch (Exception er)
            {
                //error handling 
                string ee = er.ToString();
                dataTable = null;
            }

            //close database conenction here 

            return dataTable;
        }

        public DataTable GetEmployees()
        {
            MySqlParameter[] Parameters = new MySqlParameter[0];
            //add parameters here like department id like for the other api call  
            return Execute_Data_Query_Store_Procedure("getReceipt", Parameters);
        }
    }
}
