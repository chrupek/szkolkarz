using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data.Objects;
using System.Linq;

namespace szkolkarz.core
{
    class DBController : System.IDisposable{
    
        
        public void Dispose()
        {
 	        throw new NotImplementedException();
        }



        public List<ADM_SOWN_LOG> getSownHistory(string rowID)
        {
            int id = Convert.ToInt32(rowID);

           using( var dbEntities = new szkolkarzEntities())
           {
               var query = from asw in
                               dbEntities.ADM_SOWN_LOG
                               where asw.ID == id      
                           orderby asw.ADM_PLANT_ID
                           select asw;
              return query.ToList<ADM_SOWN_LOG>();
           }
        }
    }
}
