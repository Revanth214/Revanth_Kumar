using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportExporter
{
        // Interface = contract
        interface IReportExporter
        {
            void Export(string report);
        }

        // PDF implementation
        class PDFExporter : IReportExporter
        {
            public void Export(string report)
            {
                Console.WriteLine($"Exporting '{report}' as PDF.");
            }
        }

        // Excel implementation
        class ExcelExporter : IReportExporter
        {
            public void Export(string report)
            {
                Console.WriteLine($"Exporting '{report}' as Excel.");
            }
        }

        // CSV implementation
        class CSVExporter : IReportExporter
        {
            public void Export(string report)
            {
                Console.WriteLine($"Exporting '{report}' as CSV.");
            }
        }
}
