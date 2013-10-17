using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace szkolkarz.core.utils
{
    class Queries
    {
        static string selectAllSownAfterId = @"SELECT * FROM ADM_SOWN_LOG WHERE ID = ";
        
        public string getSelectAllSownAfterId()
        {
            return selectAllSownAfterId;
        }

        static string selectAllAuditAfterAction = @"SELECT * FROM AUDIT_LOG WHERE ACTION = ";

        public string getSelectAllAuditAfterAction()
        {
            return selectAllAuditAfterAction;
        }
    }
}
