using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace DBapplication
{
    public class DBManager
    {

        //Data Source =.\\SQLEXPRESS;Database=YourDatabase;Integrated Security = True


        // public static string DB_Connection_String = @"Data Source=KHALED\SQLEXPRESS;Initial Catalog=Rent;Integrated Security=True";
        // public static string DB_Connection_String = @"Integrated Security = SSPI; Initial Catalog = Rent; Data Source = KHALED\SQLEXPRESS";

             string DB_Connection_String =
     System.Configuration.ConfigurationManager.
     ConnectionStrings["MyConnectionString"].ConnectionString;
        public SqlConnection myConnection;
        
        
        public DBManager()
        {
           myConnection = new SqlConnection(DB_Connection_String);
	   try
           {
    		myConnection.Open();
	       }
	   catch (Exception e)
	   {
     		Console.WriteLine("The DB connection to :" + DB_Connection_String+ " failed!");
     		MessageBoxs.mes.Show("An error occurred while connecting to the database!");
           }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        
        public int ExecuteNonQueryImage(string query,byte[] img)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add(new SqlParameter("@img", img));
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

       

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public object ExecuteScalarImage(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
;
