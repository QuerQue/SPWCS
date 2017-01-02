using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.IO;

using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

using System.Drawing;
using System.Windows.Forms;

namespace SPWCS
{
    class PDFConverter
    {

        public static  void exportToPDF(DataGridView dg, String name)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dg.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dg.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dg.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string folderpath = startuppath + "" + @"\..\PDFs\";
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(startuppath + "" + @"\..\PDFs\");
            }
            using (FileStream stream = new FileStream(folderpath + name+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

    }
}
