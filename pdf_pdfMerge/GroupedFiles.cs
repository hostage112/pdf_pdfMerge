using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMT_pdfMerge
{
    public class GroupedFiles
    {
        private ArrayList _group;
        private int _minWordCount;
        private int _maxWordCount;
        private bool _firstIteration = true;

        public ArrayList group
        {
            get { return _group; }
            set { _group = value; }
        }

        public GroupedFiles(ImportedFile pdf)
        {
            _group = new ArrayList();
            _group.Add(pdf);
        }

        internal bool isInCurrentList(ImportedFile pdf, int minKey, int maxKey)
        {
            ImportedFile sortedPDF = _group[0] as ImportedFile;
            for (int i = minKey; i < maxKey; i++)
            {
                if (pdf.fileNameWords[i] != sortedPDF.fileNameWords[i])
                {
                    return false;
                }
            }
            return true;
        }

        internal void AddToList(ImportedFile pdf)
        {
            _group.Add(pdf);
        }

        internal void sortSelf()
        {
            findWordCounts();

            if (areAllSameLength())
            {
                if (hasMoreThenTwo())
                {
                    sortByMinusOne();
                }
            }
            else if (isPlusTwo() && _firstIteration)
            {
                _firstIteration = false;
                ImportedFile lastElement = findMinElement();
                _group.Remove(lastElement);
                sortSelf();
                _group.Add(lastElement);
            }
        }

        private void sortByMinusOne()
        {
            ArrayList sortedList = new ArrayList();
            foreach (ImportedFile pdf in _group)
            {
                sortedList = sortCurrentPdf(pdf, sortedList);
            }
            _group = sortedList;
        }

        private ArrayList sortCurrentPdf(ImportedFile pdf, ArrayList sortedList)
        {
            foreach (ImportedFile sortedPdf in sortedList)
            {
                int sorted = Int32.Parse(sortedPdf.fileNameWords[sortedPdf.fileNameWords.Count() - 2]);
                int unsorted = Int32.Parse(pdf.fileNameWords[pdf.fileNameWords.Count() - 2]);
                if (unsorted < sorted)
                {
                    int insertBefore = sortedList.IndexOf(sortedPdf);
                    sortedList.Insert(insertBefore, pdf);
                    return sortedList;
                }
            }
            sortedList.Add(pdf);
            return sortedList;
        }

        private ImportedFile findMinElement()
        {
            foreach (ImportedFile pdf in _group)
            {
                if (pdf.fileNameWords.Count() == _minWordCount)
                {
                    return pdf;
                }
            }

            return null;
        }

        internal string generateGroupName(bool removeOne, bool removeTwo)
        {
            int key = findNameKey(removeTwo);

            if (removeOne)
            {
                key = key - 1;
            }
            ImportedFile first = _group[0] as ImportedFile;
            string newName = first.fileNameWords[0];
            for (int j = 1; j < key; j++)
            {
                newName += "-" + first.fileNameWords[j];
            }
            return newName;
        }
   
        private void findWordCounts()
        {
            int minKey = int.MaxValue;
            int maxKey = int.MinValue;

            foreach (ImportedFile pdf in _group)
            {
                minKey = Math.Min(minKey, pdf.fileNameWords.Count());
                maxKey = Math.Max(maxKey, pdf.fileNameWords.Count());
            }

            _minWordCount = minKey;
            _maxWordCount = maxKey;

        }

        private bool areAllSameLength()
        {
            if (_minWordCount == _maxWordCount)
            {
                return true;
            }
            return false;
        }

        private bool hasMoreThenTwo()
        {
            if (_minWordCount > 2)
            {
                return true;
            }
            return false;
        }

        private bool isPlusTwo()
        {
            if (_maxWordCount - _minWordCount == 2)
            {
                return true;
            }
            return false;
        }

        private int findNameKey(bool removeTwo)
        {
            if (areAllSameLength())
            {
                if (hasMoreThenTwo() && removeTwo)
                {
                    return _minWordCount - 2;
                }
            }
            return _minWordCount;
        }
    }
}
