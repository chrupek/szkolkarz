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
        utils.predefinedQueries queries = new utils.predefinedQueries();

        public void createConnection()
        {
            if (dbConnection.Equals(null))
                dbConnection = new DBConnection();
            dbConnection.openConnection();
        }

        public List<ADM_SOWN_LOG> getSownHistory(string rowID)
        {
            List<ADM_SOWN_LOG> sownsLog = new List<ADM_SOWN_LOG>();
            string query = queries.getSelectAllSownAfterId()+rowID;
            SqlDataReader queryResult = dbConnection.executeQuery(query);

            if (queryResult == null)
            {
                return null;
            }

            return sownsLog;
        }
    }
}
