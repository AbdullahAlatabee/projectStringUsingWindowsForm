namespace Abdullah_Hassan_Abdo_Hassan
{
    partial class Form1
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
            this.txtAll_text = new System.Windows.Forms.TextBox();
            this.txtShowAll = new System.Windows.Forms.TextBox();
            this.btnAllLength = new System.Windows.Forms.Button();
            this.btnSelectLength = new System.Windows.Forms.Button();
            this.txtSelect_Length = new System.Windows.Forms.TextBox();
            this.btnLengthWord = new System.Windows.Forms.Button();
            this.txtLengthWord = new System.Windows.Forms.TextBox();
            this.btnDeleteSelectionTxt = new System.Windows.Forms.Button();
            this.btnNoSelect = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnLengthNoSpace = new System.Windows.Forms.Button();
            this.btnLengthSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtedite = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchBefor = new System.Windows.Forms.Button();
            this.btnSearchAfter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPast = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtCopyPast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowLeters = new System.Windows.Forms.Button();
            this.btnShowWords = new System.Windows.Forms.Button();
            this.listBoxShowChar = new System.Windows.Forms.ListBox();
            this.listBoxShowWord = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAll_text
            // 
            this.txtAll_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAll_text.Location = new System.Drawing.Point(0, 0);
            this.txtAll_text.Multiline = true;
            this.txtAll_text.Name = "txtAll_text";
            this.txtAll_text.Size = new System.Drawing.Size(970, 99);
            this.txtAll_text.TabIndex = 0;
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(820, 140);
            this.txtShowAll.Multiline = true;
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(141, 31);
            this.txtShowAll.TabIndex = 1;
            // 
            // btnAllLength
            // 
            this.btnAllLength.Location = new System.Drawing.Point(817, 98);
            this.btnAllLength.Name = "btnAllLength";
            this.btnAllLength.Size = new System.Drawing.Size(141, 38);
            this.btnAllLength.TabIndex = 2;
            this.btnAllLength.Text = "طول النص كامل";
            this.btnAllLength.UseVisualStyleBackColor = true;
            this.btnAllLength.Click += new System.EventHandler(this.btnAllLength_Click);
            // 
            // btnSelectLength
            // 
            this.btnSelectLength.Location = new System.Drawing.Point(659, 98);
            this.btnSelectLength.Name = "btnSelectLength";
            this.btnSelectLength.Size = new System.Drawing.Size(152, 38);
            this.btnSelectLength.TabIndex = 4;
            this.btnSelectLength.Text = "طول النص المحدد";
            this.btnSelectLength.UseVisualStyleBackColor = true;
            this.btnSelectLength.Click += new System.EventHandler(this.btnSelectLength_Click);
            // 
            // txtSelect_Length
            // 
            this.txtSelect_Length.Location = new System.Drawing.Point(659, 140);
            this.txtSelect_Length.Multiline = true;
            this.txtSelect_Length.Name = "txtSelect_Length";
            this.txtSelect_Length.Size = new System.Drawing.Size(155, 31);
            this.txtSelect_Length.TabIndex = 3;
            // 
            // btnLengthWord
            // 
            this.btnLengthWord.Location = new System.Drawing.Point(510, 98);
            this.btnLengthWord.Name = "btnLengthWord";
            this.btnLengthWord.Size = new System.Drawing.Size(141, 38);
            this.btnLengthWord.TabIndex = 6;
            this.btnLengthWord.Text = "عدد الكلمات";
            this.btnLengthWord.UseVisualStyleBackColor = true;
            this.btnLengthWord.Click += new System.EventHandler(this.btnLengthWord_Click);
            // 
            // txtLengthWord
            // 
            this.txtLengthWord.Location = new System.Drawing.Point(524, 140);
            this.txtLengthWord.Multiline = true;
            this.txtLengthWord.Name = "txtLengthWord";
            this.txtLengthWord.Size = new System.Drawing.Size(132, 31);
            this.txtLengthWord.TabIndex = 5;
            // 
            // btnDeleteSelectionTxt
            // 
            this.btnDeleteSelectionTxt.Location = new System.Drawing.Point(340, 98);
            this.btnDeleteSelectionTxt.Name = "btnDeleteSelectionTxt";
            this.btnDeleteSelectionTxt.Size = new System.Drawing.Size(165, 38);
            this.btnDeleteSelectionTxt.TabIndex = 8;
            this.btnDeleteSelectionTxt.Text = "حذف النص المحدد";
            this.btnDeleteSelectionTxt.UseVisualStyleBackColor = true;
            this.btnDeleteSelectionTxt.Click += new System.EventHandler(this.btnDeleteSelectionTxt_Click);
            // 
            // btnNoSelect
            // 
            this.btnNoSelect.Location = new System.Drawing.Point(220, 98);
            this.btnNoSelect.Name = "btnNoSelect";
            this.btnNoSelect.Size = new System.Drawing.Size(118, 38);
            this.btnNoSelect.TabIndex = 9;
            this.btnNoSelect.Text = "إلغاء التحديد";
            this.btnNoSelect.UseVisualStyleBackColor = true;
            this.btnNoSelect.Click += new System.EventHandler(this.btnNoSelect_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(154, 98);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(64, 38);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "نسخ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(88, 98);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(64, 38);
            this.btnCut.TabIndex = 11;
            this.btnCut.Text = "قص";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(8, 98);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(74, 38);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnLengthNoSpace
            // 
            this.btnLengthNoSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLengthNoSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthNoSpace.Location = new System.Drawing.Point(275, 136);
            this.btnLengthNoSpace.Name = "btnLengthNoSpace";
            this.btnLengthNoSpace.Size = new System.Drawing.Size(243, 38);
            this.btnLengthNoSpace.TabIndex = 13;
            this.btnLengthNoSpace.Text = "طول النص كامل بدون الفراغات";
            this.btnLengthNoSpace.UseVisualStyleBackColor = false;
            this.btnLengthNoSpace.Click += new System.EventHandler(this.btnLengthNoSpace_Click);
            // 
            // btnLengthSelected
            // 
            this.btnLengthSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLengthSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthSelected.Location = new System.Drawing.Point(29, 134);
            this.btnLengthSelected.Name = "btnLengthSelected";
            this.btnLengthSelected.Size = new System.Drawing.Size(240, 38);
            this.btnLengthSelected.TabIndex = 14;
            this.btnLengthSelected.Text = "طول النص المحدد بدون الفراغات";
            this.btnLengthSelected.UseVisualStyleBackColor = false;
            this.btnLengthSelected.Click += new System.EventHandler(this.btnLengthSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtedite);
            this.groupBox1.Controls.Add(this.btnSwap);
            this.groupBox1.Location = new System.Drawing.Point(524, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(434, 162);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استبدال";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "النص الجديد";
            // 
            // txtedite
            // 
            this.txtedite.Location = new System.Drawing.Point(126, 66);
            this.txtedite.Multiline = true;
            this.txtedite.Name = "txtedite";
            this.txtedite.Size = new System.Drawing.Size(212, 41);
            this.txtedite.TabIndex = 8;
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.Silver;
            this.btnSwap.Location = new System.Drawing.Point(191, 109);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(141, 38);
            this.btnSwap.TabIndex = 7;
            this.btnSwap.Text = "استبدال";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchBefor);
            this.groupBox2.Controls.Add(this.btnSearchAfter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(51, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(434, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            // 
            // btnSearchBefor
            // 
            this.btnSearchBefor.BackColor = System.Drawing.Color.Silver;
            this.btnSearchBefor.Location = new System.Drawing.Point(11, 106);
            this.btnSearchBefor.Name = "btnSearchBefor";
            this.btnSearchBefor.Size = new System.Drawing.Size(141, 38);
            this.btnSearchBefor.TabIndex = 11;
            this.btnSearchBefor.Text = "بحث عن السابق";
            this.btnSearchBefor.UseVisualStyleBackColor = false;
            this.btnSearchBefor.Click += new System.EventHandler(this.btnSearchBefor_Click);
            // 
            // btnSearchAfter
            // 
            this.btnSearchAfter.BackColor = System.Drawing.Color.Silver;
            this.btnSearchAfter.Location = new System.Drawing.Point(155, 107);
            this.btnSearchAfter.Name = "btnSearchAfter";
            this.btnSearchAfter.Size = new System.Drawing.Size(141, 38);
            this.btnSearchAfter.TabIndex = 10;
            this.btnSearchAfter.Text = "بحث عن التالي";
            this.btnSearchAfter.UseVisualStyleBackColor = false;
            this.btnSearchAfter.Click += new System.EventHandler(this.btnSearchAfter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "النص المراد البحث عنه";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(177, 54);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(212, 41);
            this.txtsearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(301, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPast
            // 
            this.btnPast.BackColor = System.Drawing.Color.Silver;
            this.btnPast.Location = new System.Drawing.Point(836, 373);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(89, 38);
            this.btnPast.TabIndex = 17;
            this.btnPast.Text = "لصق";
            this.btnPast.UseVisualStyleBackColor = false;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.Silver;
            this.btnReverse.Location = new System.Drawing.Point(546, 376);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(89, 38);
            this.btnReverse.TabIndex = 18;
            this.btnReverse.Text = "تراجع";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // txtCopyPast
            // 
            this.txtCopyPast.Location = new System.Drawing.Point(546, 421);
            this.txtCopyPast.Multiline = true;
            this.txtCopyPast.Name = "txtCopyPast";
            this.txtCopyPast.Size = new System.Drawing.Size(379, 191);
            this.txtCopyPast.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "احرف الكلمة المحددة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "كلمات الجملة المحددة";
            // 
            // btnShowLeters
            // 
            this.btnShowLeters.BackColor = System.Drawing.Color.Silver;
            this.btnShowLeters.Location = new System.Drawing.Point(314, 421);
            this.btnShowLeters.Name = "btnShowLeters";
            this.btnShowLeters.Size = new System.Drawing.Size(169, 38);
            this.btnShowLeters.TabIndex = 22;
            this.btnShowLeters.Text = "عرض";
            this.btnShowLeters.UseVisualStyleBackColor = false;
            this.btnShowLeters.Click += new System.EventHandler(this.btnShowLeters_Click);
            // 
            // btnShowWords
            // 
            this.btnShowWords.BackColor = System.Drawing.Color.Silver;
            this.btnShowWords.Location = new System.Drawing.Point(62, 421);
            this.btnShowWords.Name = "btnShowWords";
            this.btnShowWords.Size = new System.Drawing.Size(169, 38);
            this.btnShowWords.TabIndex = 23;
            this.btnShowWords.Text = "عرض";
            this.btnShowWords.UseVisualStyleBackColor = false;
            this.btnShowWords.Click += new System.EventHandler(this.btnShowWords_Click);
            // 
            // listBoxShowChar
            // 
            this.listBoxShowChar.FormattingEnabled = true;
            this.listBoxShowChar.ItemHeight = 25;
            this.listBoxShowChar.Items.AddRange(new object[] {
            " "});
            this.listBoxShowChar.Location = new System.Drawing.Point(314, 465);
            this.listBoxShowChar.Name = "listBoxShowChar";
            this.listBoxShowChar.Size = new System.Drawing.Size(169, 154);
            this.listBoxShowChar.TabIndex = 26;
            // 
            // listBoxShowWord
            // 
            this.listBoxShowWord.FormattingEnabled = true;
            this.listBoxShowWord.ItemHeight = 25;
            this.listBoxShowWord.Items.AddRange(new object[] {
            " "});
            this.listBoxShowWord.Location = new System.Drawing.Point(62, 458);
            this.listBoxShowWord.Name = "listBoxShowWord";
            this.listBoxShowWord.Size = new System.Drawing.Size(169, 154);
            this.listBoxShowWord.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(970, 643);
            this.Controls.Add(this.listBoxShowWord);
            this.Controls.Add(this.listBoxShowChar);
            this.Controls.Add(this.btnShowWords);
            this.Controls.Add(this.btnShowLeters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCopyPast);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLengthSelected);
            this.Controls.Add(this.btnLengthNoSpace);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnNoSelect);
            this.Controls.Add(this.btnDeleteSelectionTxt);
            this.Controls.Add(this.btnLengthWord);
            this.Controls.Add(this.txtLengthWord);
            this.Controls.Add(this.btnSelectLength);
            this.Controls.Add(this.txtSelect_Length);
            this.Controls.Add(this.btnAllLength);
            this.Controls.Add(this.txtShowAll);
            this.Controls.Add(this.txtAll_text);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAll_text;
        private System.Windows.Forms.TextBox txtShowAll;
        private System.Windows.Forms.Button btnAllLength;
        private System.Windows.Forms.Button btnSelectLength;
        private System.Windows.Forms.TextBox txtSelect_Length;
        private System.Windows.Forms.Button btnLengthWord;
        private System.Windows.Forms.TextBox txtLengthWord;
        private System.Windows.Forms.Button btnDeleteSelectionTxt;
        private System.Windows.Forms.Button btnNoSelect;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnLengthNoSpace;
        private System.Windows.Forms.Button btnLengthSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtedite;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchBefor;
        private System.Windows.Forms.Button btnSearchAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtCopyPast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowLeters;
        private System.Windows.Forms.Button btnShowWords;
        private System.Windows.Forms.ListBox listBoxShowChar;
        private System.Windows.Forms.ListBox listBoxShowWord;
    }
}

