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
            this.txt_sortMax = new System.Windows.Forms.TextBox();
            this.txt_sortMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_minus2 = new System.Windows.Forms.CheckBox();
            this.cb_minus1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btn_print.Location = new System.Drawing.Point(220, 470);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(150, 80);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Prindi";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_sortMax
            // 
            this.txt_sortMax.Enabled = false;
            this.txt_sortMax.Location = new System.Drawing.Point(234, 283);
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
            this.txt_sortMin.Location = new System.Drawing.Point(234, 309);
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
            this.label1.Location = new System.Drawing.Point(327, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MAX";
            // 
            // cb_minus2
            // 
            this.cb_minus2.AutoSize = true;
            this.cb_minus2.Enabled = false;
            this.cb_minus2.Location = new System.Drawing.Point(234, 224);
            this.cb_minus2.Name = "cb_minus2";
            this.cb_minus2.Size = new System.Drawing.Size(109, 17);
            this.cb_minus2.TabIndex = 8;
            this.cb_minus2.Text = "Eemalda nimest 2";
            this.cb_minus2.UseVisualStyleBackColor = true;
            this.cb_minus2.CheckedChanged += new System.EventHandler(this.cb_minus2_CheckedChanged);
            // 
            // cb_minus1
            // 
            this.cb_minus1.AutoSize = true;
            this.cb_minus1.Enabled = false;
            this.cb_minus1.Location = new System.Drawing.Point(234, 201);
            this.cb_minus1.Name = "cb_minus1";
            this.cb_minus1.Size = new System.Drawing.Size(109, 17);
            this.cb_minus1.TabIndex = 9;
            this.cb_minus1.Text = "Eemalda nimest 1";
            this.cb_minus1.UseVisualStyleBackColor = true;
            this.cb_minus1.CheckedChanged += new System.EventHandler(this.cb_minus1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sorteerimine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Faili nimetus:";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_minus1);
            this.Controls.Add(this.cb_minus2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sortMin);
            this.Controls.Add(this.txt_sortMax);
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
        private System.Windows.Forms.TextBox txt_sortMax;
        private System.Windows.Forms.TextBox txt_sortMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_minus2;
        private System.Windows.Forms.CheckBox cb_minus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

