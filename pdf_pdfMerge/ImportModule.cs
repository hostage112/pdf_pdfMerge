using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace DMT_pdfMerge
{
    static class ImportModule
    {
        static public List<string> importFiles(string path)
        {
            string[] importFiles = Directory.GetFiles(path, "*.PDF");
            List<string> sortedFiles = new List<string>(importFiles);
            sortedFiles.Sort();
            return sortedFiles;
        }
    }
}
