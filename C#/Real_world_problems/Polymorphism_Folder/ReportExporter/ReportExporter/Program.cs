using System;
using System.Collections.Generic;

namespace ReportExporter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IReportExporter> exporters = new List<IReportExporter>();

            exporters.Add(new PDFExporter());
            exporters.Add(new ExcelExporter());
            exporters.Add(new CSVExporter());

            foreach (IReportExporter exporter in exporters)
            {
                exporter.Export("Monthly Sales Report");
            }

            Console.ReadLine();
        }
    }
}