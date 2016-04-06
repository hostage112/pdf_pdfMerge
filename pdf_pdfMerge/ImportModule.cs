using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace DMT_pdfMerge
{
    static class ImportModule
    {
        static public string[] importFiles(string path)
        {
            string[] importFiles = Directory.GetFiles(path, "*.PDF");
            return importFiles;
        }
    }
}
