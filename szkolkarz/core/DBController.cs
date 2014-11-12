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



        public List<ADM_SOWN_LOG> getSownHistory(List<int> rowsList)
        {
            try
            {
                using (var context = new szkolkarz.szkolkarzEntities())
                {
                    var query = context.ADM_SOWN_LOG.Where(a => rowsList.Contains(a.TAPE_ID));
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
