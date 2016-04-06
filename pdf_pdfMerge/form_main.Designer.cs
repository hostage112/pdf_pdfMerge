namespace DMT_pdfMerge
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_original = new System.Windows.Forms.TextBox();
            this.txt_sorted = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.cb_manual = new System.Windows.Forms.CheckBox();
            this.txt_sortMax = new System.Windows.Forms.TextBox();
            this.txt_sortMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_manual = new System.Windows.Forms.Button();
            this.cb_minus2 = new System.Windows.Forms.CheckBox();
            this.cb_magic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(15, 15);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(560, 20);
            this.txt_path.TabIndex = 0;
            this.txt_path.Text = "<pathValue>";
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // txt_original
            // 
            this.txt_original.Location = new System.Drawing.Point(15, 50);
            this.txt_original.Multiline = true;
            this.txt_original.Name = "txt_original";
            this.txt_original.ReadOnly = true;
            this.txt_original.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_original.Size = new System.Drawing.Size(200, 500);
            this.txt_original.TabIndex = 1;
            this.txt_original.Text = "<originalList>";
            // 
            // txt_sorted
            // 
            this.txt_sorted.Location = new System.Drawing.Point(375, 50);
            this.txt_sorted.Multiline = true;
            this.txt_sorted.Name = "txt_sorted";
            this.txt_sorted.ReadOnly = true;
            this.txt_sorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sorted.Size = new System.Drawing.Size(200, 500);
            this.txt_sorted.TabIndex = 1;
            this.txt_sorted.Text = "<sortedList>";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(220, 50);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(150, 30);
            this.btn_import.TabIndex = 2;
            this.btn_import.Text = "Loe andmed";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(220, 90);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(150, 80);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Prindi";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // cb_manual
            // 
            this.cb_manual.AutoSize = true;
            this.cb_manual.Enabled = false;
            this.cb_manual.Location = new System.Drawing.Point(230, 409);
            this.cb_manual.Name = "cb_manual";
            this.cb_manual.Size = new System.Drawing.Size(100, 17);
            this.cb_manual.TabIndex = 4;
            this.cb_manual.Text = "Manual settings";
            this.cb_manual.UseVisualStyleBackColor = true;
            this.cb_manual.CheckedChanged += new System.EventHandler(this.cb_manual_CheckedChanged);
            // 
            // txt_sortMax
            // 
            this.txt_sortMax.Enabled = false;
            this.txt_sortMax.Location = new System.Drawing.Point(230, 330);
            this.txt_sortMax.Name = "txt_sortMax";
            this.txt_sortMax.Size = new System.Drawing.Size(75, 20);
            this.txt_sortMax.TabIndex = 5;
            this.txt_sortMax.Text = "<sortMax>";
            this.txt_sortMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sortMax.TextChanged += new System.EventHandler(this.txt_sortMax_TextChanged);
            // 
            // txt_sortMin
            // 
            this.txt_sortMin.Enabled = false;
            this.txt_sortMin.Location = new System.Drawing.Point(230, 360);
            this.txt_sortMin.Name = "txt_sortMin";
            this.txt_sortMin.Size = new System.Drawing.Size(75, 20);
            this.txt_sortMin.TabIndex = 6;
            this.txt_sortMin.Text = "<sortMin>";
            this.txt_sortMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sortMin.TextChanged += new System.EventHandler(this.txt_sortMin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MAX";
            // 
            // btn_manual
            // 
            this.btn_manual.Enabled = false;
            this.btn_manual.Location = new System.Drawing.Point(219, 260);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(150, 30);
            this.btn_manual.TabIndex = 2;
            this.btn_manual.Text = "Sorteeri uuesti";
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // cb_minus2
            // 
            this.cb_minus2.AutoSize = true;
            this.cb_minus2.Enabled = false;
            this.cb_minus2.Location = new System.Drawing.Point(230, 307);
            this.cb_minus2.Name = "cb_minus2";
            this.cb_minus2.Size = new System.Drawing.Size(109, 17);
            this.cb_minus2.TabIndex = 8;
            this.cb_minus2.Text = "Eemalda nimest 2";
            this.cb_minus2.UseVisualStyleBackColor = true;
            this.cb_minus2.CheckedChanged += new System.EventHandler(this.cb_minus2_CheckedChanged);
            // 
            // cb_magic
            // 
            this.cb_magic.AutoSize = true;
            this.cb_magic.Enabled = false;
            this.cb_magic.Location = new System.Drawing.Point(230, 386);
            this.cb_magic.Name = "cb_magic";
            this.cb_magic.Size = new System.Drawing.Size(55, 17);
            this.cb_magic.TabIndex = 9;
            this.cb_magic.Text = "Magic";
            this.cb_magic.UseVisualStyleBackColor = true;
            this.cb_magic.CheckedChanged += new System.EventHandler(this.cb_magic_CheckedChanged);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cb_magic);
            this.Controls.Add(this.cb_minus2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sortMin);
            this.Controls.Add(this.txt_sortMax);
            this.Controls.Add(this.cb_manual);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.txt_sorted);
            this.Controls.Add(this.txt_original);
            this.Controls.Add(this.txt_path);
            this.Name = "form_main";
            this.Text = "DMT PDF merge";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.TextBox txt_original;
        private System.Windows.Forms.TextBox txt_sorted;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.CheckBox cb_manual;
        private System.Windows.Forms.TextBox txt_sortMax;
        private System.Windows.Forms.TextBox txt_sortMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.CheckBox cb_minus2;
        private System.Windows.Forms.CheckBox cb_magic;
    }
}

