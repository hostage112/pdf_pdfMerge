using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace DMT_pdfMerge
{
    public class ImportedFile
    {
        public ImportedFile(string path)
        {
            _fileLocation = path;
            _fileName = Path.GetFileName(path);
            _fileNameWords = splitString(path);
        }

        private string _fileLocation;
        private string _fileName;
        private string[] _fileNameWords;

        public string fileLocation
        {
            get { return _fileLocation; }
            set { _fileLocation = value; }
        }
        public string fileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public string[] fileNameWords
        {
            get { return _fileNameWords; }
            set { _fileNameWords = value; }
        }

        private string[] splitString(string path)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            fileName = fileName.Replace(" ", "_");
            fileName = fileName.Replace("-", "_");
            fileName = fileName.Replace("__", "_");
            string[] splitName = fileName.Split('_');

            return splitName;
        }
    }
}