using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMT_pdfMerge
{
    public partial class form_main : Form
    {
        //init values
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\print\";
        private string _merge = @"merge\";

        private int _autoSortMin = 0;
        private int _autoSortMax = int.MaxValue;

        private int _manualSortMin = 0;
        private int _manualSortMax = 0;

        private bool _removeTwo = false;
        private bool _magic = false;

        private ImportedGroup PDFfiles;

        //init form
        public form_main()
        {
            InitializeComponent();
        }

        //clear static values
        private void form_main_Load(object sender, EventArgs e)
        {
            txt_path.Text = _path;
            txt_original.Text = "";
            txt_sorted.Text = "";
            txt_sortMax.Text = _autoSortMax.ToString();
            txt_sortMin.Text = _autoSortMin.ToString();
        }

        //file path
        private void txt_path_TextChanged(object sender, EventArgs e)
        {
            _path = txt_path.Text;

            if (!_path.EndsWith(@"\"))
            {
                _path = _path + @"\";
            }
        }

        //import button
        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                formImport();
                formSort(_autoSortMin, _autoSortMax);

                if (PDFfiles.unsortedList.Count != 0)
                {
                    cb_manual.Enabled = true;
                    txt_sortMax.Text = _autoSortMax.ToString();
                    txt_sortMin.Text = _autoSortMin.ToString();
                }
                else
                {
                    cb_manual.Checked = false;
                    cb_manual.Enabled = false;
                    cb_minus2.Checked = false;
                    cb_magic.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Viga faili lugemisel");
            }
        }

        //import files 
        private void formImport()
        {
            string[] importedPDFfiles = ImportModule.importFiles(_path);
            PDFfiles = new ImportedGroup(importedPDFfiles);
            _autoSortMax = PDFfiles.findAutoSortValue(_removeTwo);
            outputPreviewImported();
        }

        //start sorting
        private void formSort(int min, int max)
        {
            PDFfiles.sortLogic(min, max);
            PDFfiles.sortSubLists();
            outputPreviewSorted();
        }

        //show grouped files
        private void outputPreviewImported()
        {
            txt_original.Clear();

            foreach (ImportedFile unsortedPDF in PDFfiles.unsortedList)
            {
                txt_original.AppendText(unsortedPDF.fileName + Environment.NewLine);
            }
        }

        //show grouped files
        private void outputPreviewSorted()
        {
            txt_sorted.Clear();

            foreach (GroupedFiles sortedSubList in PDFfiles.sortedList)
            {
                foreach (ImportedFile sortedPDF in sortedSubList.group)
                {
                    txt_sorted.AppendText(sortedPDF.fileName + Environment.NewLine);
                }
                txt_sorted.AppendText("--------------" + Environment.NewLine);
            }
        }

        //manual checkbox
        private void cb_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_manual.Checked == true)
            {
                txt_sortMax.Enabled = true;
                txt_sortMin.Enabled = true;
                btn_manual.Enabled = true;
                cb_minus2.Enabled = true;
                cb_magic.Enabled = true;
            }
            else
            {
                txt_sortMax.Enabled = false;
                txt_sortMin.Enabled = false;
                btn_manual.Enabled = false;
                cb_minus2.Enabled = false;
                cb_magic.Enabled = false;
            }
        }

        //check manual sort values
        private void txt_sortMax_TextChanged(object sender, EventArgs e)
        {
            int newManualMax;
            int.TryParse(txt_sortMax.Text, out newManualMax);

            if (newManualMax > _autoSortMax+5)
            {
                _manualSortMax = _autoSortMax;
                txt_sortMax.Text = _manualSortMax.ToString();
            }
            else if (newManualMax < _autoSortMin)
            {
                _manualSortMax = _autoSortMax;
                txt_sortMax.Text = _manualSortMax.ToString();
            }
            else
            {
                _manualSortMax = newManualMax;
            }
        }

        //check manual sort values
        private void txt_sortMin_TextChanged(object sender, EventArgs e)
        {
            int newManualMin;
            int.TryParse(txt_sortMin.Text, out newManualMin);
            if (newManualMin >= _manualSortMax)
            {
                _manualSortMin = _autoSortMin;
                txt_sortMin.Text = _manualSortMin.ToString();
            }
            else if (newManualMin <= _autoSortMin)
            {
                _manualSortMin = _autoSortMin;
                txt_sortMin.Text = _manualSortMin.ToString();
            }
            else
            {
                _manualSortMin = newManualMin;
            }
        }

        //manual sorting button
        private void btn_manual_Click(object sender, EventArgs e)
        {
            try
            {
                formSort(_manualSortMin, _manualSortMax);
            }
            catch (Exception)
            {
                MessageBox.Show("Viga sorteerimisel, proovi muu väärtus");
                _manualSortMin = _autoSortMin;
                _manualSortMax = _autoSortMax;
                txt_sortMin.Text = _manualSortMin.ToString();
                txt_sortMax.Text = _manualSortMax.ToString();
            }

        }

        //print button
        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                string mergePath = _path + _merge;
                ExportModule.exportFiles(PDFfiles.sortedList, mergePath, _removeTwo, _magic);
                MessageBox.Show("OK");
            }
            catch (Exception)
            {
                MessageBox.Show("Viga failide kirjutamisel");
            }
        }

        private void cb_minus2_CheckedChanged(object sender, EventArgs e)
        {
            _removeTwo = cb_minus2.Checked;
        }

        private void cb_magic_CheckedChanged(object sender, EventArgs e)
        {
            _magic = cb_magic.Checked;
        }
    }
}
