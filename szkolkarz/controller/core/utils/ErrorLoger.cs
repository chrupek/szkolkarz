using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace szkolkarz.core.utils
{
    static class ErrorLoger
    {
        static public void writeErrorToFile(Exception e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("ErrorLog_"+DateTime.Now.ToString("yyyyMMdd_HHmmss")+".log");
            file.WriteLine(e.StackTrace);

            file.Close();
        }
    }
}
