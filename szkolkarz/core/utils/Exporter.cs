using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel; 

namespace szkolkarz.core.utils
{
    class Exporter
    {
        public void exportToExcel(List<V_FULL_SOWN_LOG> dataToExport)
        {
            string data = null;
            int i = 0;
            int j = 0; 

            Application xlApp ;
            Workbook xlWorkBook = new Workbook();
            Worksheet xlWorkSheet ;

            xlApp = new Application();
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= dataToExport.Count - 1; i++)
            {
                    data = dataToExport.ElementAt(i).ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
            }

            xlWorkBook.SaveAs("file.xls", XlFileFormat.xlWorkbookNormal, XlSaveAsAccessMode.xlExclusive);
            xlWorkBook.Close(true);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            System.Windows.Forms.MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                GC.Collect();
            }
        }
            
   }

 }
