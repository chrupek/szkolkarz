using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using ExporterObjects;

namespace szkolkarz.core.utils
{
    class Exporter
    {
        public void exportToExcel(List<V_FULL_SOWN_LOG> dataToExport)
        {
            ExportList<V_FULL_SOWN_LOG> export = new ExportList<V_FULL_SOWN_LOG>();
            export.PathTemplateFolder = "/Exports";
            string fileName = "raport_" + DateTime.Now.ToString();
            export.ExportTo(dataToExport, ExportToFormat.Excel2007, fileName);
        }

        public void exportToPDF(List<V_FULL_SOWN_LOG> dataToExport)
        {
            ExportList<V_FULL_SOWN_LOG> export = new ExportList<V_FULL_SOWN_LOG>();
            export.PathTemplateFolder = "/Exports";
            string fileName = "raport_"+DateTime.Now.ToString();
            export.ExportTo(dataToExport, ExportToFormat.PDFtextSharpXML, fileName);
        }
            
   }

 }
