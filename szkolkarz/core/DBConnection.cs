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


        public void openConnection()
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
                    throw;
                }
            }
           
        }

        public SqlDataReader executeQuery(String query)
        {
            if (!isOpen)
                openConnection();

            SqlDataReader reader;
            try{
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
                throw;
            }
        }

        public void closeConnection()
        {
            if (isOpen)
            {
                connection.Close();
                isOpen = false;
            }
        }
    }
}
