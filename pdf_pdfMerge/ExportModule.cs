using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

using PdfSharp.Pdf;

namespace DMT_pdfMerge
{
    static class ExportModule
    {
        public static void exportFiles(ArrayList sortedList, string path, bool removeOne, bool removeTwo)
        {
            if (!System.IO.Directory.Exists(path) && sortedList.Count > 0)
            {
                System.IO.Directory.CreateDirectory(path);
            }

            foreach (GroupedFiles group in sortedList)
            {
                string filePath;
                PdfDocument mergedPDF = mergeSubList(group.group);
                filePath = generatePath(group, path, removeOne, removeTwo);
                mergedPDF.Save(filePath);
            }
        }

        static private string generatePath(GroupedFiles group, string path, bool removeOne, bool removeTwo)
        {
            int addon = 0;
            string fileName = group.generateGroupName(removeOne, removeTwo);
            string filePath = path + fileName + ".pdf";

            while (File.Exists(filePath))
            {
                int removeIndex = filePath.Length - 4;
                filePath = filePath.Remove(removeIndex);
                if (filePath.EndsWith(@"(" + (addon - 1).ToString() + @")"))
                {
                    int removeIndex2 = filePath.Length - 3;
                    filePath = filePath.Remove(removeIndex2);
                }

                filePath = filePath + @"(" + addon.ToString() + @")" + ".pdf";
                addon++;
            }

            return filePath;
        }

        static private PdfDocument mergeSubList(ArrayList group)
        {
            PdfDocument mergedPDF = new PdfDocument();

            foreach (ImportedFile file in group)
            {
                PdfDocument inputDocument = PdfSharp.Pdf.IO.PdfReader.Open(file.fileLocation, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                for (int pageNumber = 0; pageNumber < inputDocument.PageCount; pageNumber++)
                {
                    PdfPage page = inputDocument.Pages[pageNumber];
                    mergedPDF.AddPage(page);
                }
            }

            return mergedPDF;
        }


    }
}
