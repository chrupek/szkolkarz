using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data.Objects;

namespace szkolkarz.core
{
    class DBController : System.IDisposable
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
            szkolkarzEntities dc = null;

            try
            {
                dc = new szkolkarzEntities();
                List<ADM_SOWN_LOG> sownLog = from c in dc.ADM_SOWN_LOG
                                             select new
                                             {
                                                 rowID = c.ID,
                                                 tapeID = c.TAPE_ID,
                                                 year = c.YEAR,
                                                 plantID = c.ADM_PLANT_ID
                                             };
                return sownLog;
            }
            finally
            {
                if (dc != null)
                {
                    dc = null;
                }
            }
        }
    }
}
