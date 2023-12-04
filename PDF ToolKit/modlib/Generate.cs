using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modlib
{
    public class Generate
    {
        public void generateBlank(int noOfPage, string outputPdfPath)
        {
            if (noOfPage.Equals(0) || noOfPage < 0)
            {
                throw new Exception("Invalid No. of pages");
            }
            if (string.IsNullOrWhiteSpace(outputPdfPath))
            {
                throw new Exception("Empty Output path.");
            }
            if (File.Exists(outputPdfPath))
            {
                File.Delete(outputPdfPath);
                Console.WriteLine($"Existing file '{outputPdfPath}' deleted.");
            }
            var writer = new PdfWriter(outputPdfPath);
            var pdf = new PdfDocument(writer);
            try
            {
                using (writer)
                {
                    using (pdf)
                    {
                        for (int i = 0; i < noOfPage + 1; i++)
                        {
                            pdf.AddNewPage(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
                pdf.Close();

            }

        }
    }
}
