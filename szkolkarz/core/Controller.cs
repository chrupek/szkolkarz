using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace szkolkarz.core
{
    class Controller
    {
        DBConnection dbConnection = new DBConnection();

        public void createConnection()
        {
            if (dbConnection.Equals(null))
                dbConnection = new DBConnection();
            dbConnection.openConnection();
        }

        public void getDBData(int rowID)
        {

        }
    }
}
