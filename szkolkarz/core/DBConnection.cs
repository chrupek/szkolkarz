using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using szkolkarz.core;

namespace szkolkarz.core
{
    class DBConnection
    {
        
        private SqlConnection connection;
        public Boolean isOpen{get; private set;}

        public DBConnection()
        {
            isOpen = false;
        }

        public SqlDataReader executeQuery(String query)
        {
            openConnection();

            SqlDataReader reader;
            try
            {
                using (var command = new SqlCommand(query, connection))

                using (reader = command.ExecuteReader())
                {
                    return reader;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                System.Windows.Forms.MessageBox.Show("Sql command exceution faild", "ERROR",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return ExceptionHandler(out reader);
            }
        }

        private static SqlDataReader ExceptionHandler(out SqlDataReader reader)
        {
            reader = new SqlDataReader();
            reader.Close();
            return reader;
        }

        public void openConnection()
        {
            if (!isOpen)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbAdress"].ConnectionString;
                using (connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        isOpen = true;
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.StackTrace);
                        System.Windows.Forms.MessageBox.Show("Could not connect to data base!", "ERROR",
                            System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void closeConnection()
        {
            connection.Close();
            isOpen = false;
        }

    }
}
