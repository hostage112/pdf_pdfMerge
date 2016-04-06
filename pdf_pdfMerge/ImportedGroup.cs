using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DMT_pdfMerge
{
    public class ImportedGroup
    {
        public ImportedGroup(List<string> filePaths)
        {
            _unsortedList = convertFiles(filePaths);
        }

        private ArrayList _unsortedList;
        private ArrayList _sortedList;

        public ArrayList unsortedList
        {
            get { return _unsortedList; }
            set { _unsortedList = value; }
        }
        public ArrayList sortedList
        {
            get { return _sortedList; }
            set { _sortedList = value; }
        }

        private ArrayList convertFiles(List<string> filePaths)
        {
            ArrayList convertedFiles = new ArrayList();

            foreach (string path in filePaths)
            {
                ImportedFile currentPDF = new ImportedFile(path);
                convertedFiles.Add(currentPDF);
            }

            return convertedFiles;
        }

        internal int findAutoSortValue(bool removeTwo)
        {
            int minKey = int.MaxValue;
            int maxKey = int.MinValue;

            foreach (ImportedFile pdf in _unsortedList)
            {
                minKey = Math.Min(minKey, pdf.fileNameWords.Count());
                maxKey = Math.Max(maxKey, pdf.fileNameWords.Count());
            }

            if (maxKey - minKey == 0)
            {
                if (maxKey > 2 && removeTwo)
                {
                    return maxKey - 2;
                }
            }

            return minKey;
        }

        internal void sortLogic(int minKey, int maxKey)
        {
            _sortedList = new ArrayList();

            foreach (ImportedFile unsortedPDF in _unsortedList)
            {
                bool isNewElement = sortCurrentPDF(unsortedPDF, minKey, maxKey);
                if (isNewElement)
                {
                    GroupedFiles newSubList = new GroupedFiles(unsortedPDF);
                    _sortedList.Add(newSubList);
                }
            }
        }

        private bool sortCurrentPDF(ImportedFile pdf, int minKey, int maxKey)
        {
            foreach (GroupedFiles sortedSubList in _sortedList)
            {
                bool inList = sortedSubList.isInCurrentList(pdf, minKey, maxKey);
                if (inList)
                {
                    sortedSubList.AddToList(pdf);
                    return false;
                }
            }
            return true;
        }

        internal void sortSubLists()
        {
            foreach (GroupedFiles subList in _sortedList)
            {
                subList.sortSelf();
            }
        }



    }
}
