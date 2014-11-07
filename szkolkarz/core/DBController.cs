using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using DotSpatial.Data;

namespace szkolkarz.core
{
    class DBController : System.IDisposable{
    
        
        public void Dispose()
        {
 	        throw new NotImplementedException();
        }



        public List<ADM_SOWN_LOG> getSownHistory(List<IFeature> rowsList)
        {
            List<int> ids  = new List<int>();
            foreach (IFeature row in rowsList)
                ids.Add(row.Fid);

            try
            {
                using (var dbEntities = new szkolkarzEntities())
                {
                    var query = from asw in
                                    dbEntities.ADM_SOWN_LOG
                                where asw.ID 
                                orderby asw.ADM_PLANT_ID
                                select asw;
                    return query.ToList<ADM_SOWN_LOG>();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
