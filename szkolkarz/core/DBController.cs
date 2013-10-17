using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace szkolkarz.core
{
    class DBController
    {
        DBConnection dbConnection = new DBConnection();
        utils.Queries queries = new utils.Queries();

        public void createConnection()
        {
            if (dbConnection.Equals(null))
                dbConnection = new DBConnection();
            dbConnection.openConnection();
        }

        public void getSownHistory(string rowID)
        {
            string query = queries.getSelectAllSownAfterId()+rowID;
            SqlDataReader result = dbConnection.executeQuery(query);
            // TODO
        }
    }
}
