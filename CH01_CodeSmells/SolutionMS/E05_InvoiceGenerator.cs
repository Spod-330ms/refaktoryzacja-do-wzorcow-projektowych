using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class E05_InvoiceGenerator
    {

        public void GenerateInvoice()
        {
            int invoiceNumber = 12345;
            using (PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf"))
            {

                // Generowanie faktury
                pdfWriter.Write("Invoice Content");
                pdfWriter.Close();
            }
        }

        public void OtherMethod()
        {
            // Metoda, która nie korzysta z tymczasowych pól
        }

    }
}
