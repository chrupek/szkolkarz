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
        public void openConnection()
        {
            

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["DbAdress"]))
            {
                try
                {
                    connection.Open();
                }
                catch (System.Data e)
                {
                    Console.WriteLine(e.StackTrace);
                    System.Windows.Forms.MessageBox.Show("Sql command exceution faild", "ERROR",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
