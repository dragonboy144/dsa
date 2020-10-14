namespace DSATools
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
            this.bBerechnen = new System.Windows.Forms.Button();
            this.lBSpalte = new System.Windows.Forms.ListBox();
            this.nUDStartwert = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDEndwert = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tBAPPreis = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cBEidetisch = new System.Windows.Forms.CheckBox();
            this.cBAkademisch = new System.Windows.Forms.CheckBox();
            this.cBGut = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDStartwert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEndwert)).BeginInit();
            this.SuspendLayout();
            // 
            // bBerechnen
            // 
            this.bBerechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBerechnen.AutoSize = true;
            this.bBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBerechnen.Location = new System.Drawing.Point(572, 200);
            this.bBerechnen.Name = "bBerechnen";
            this.bBerechnen.Size = new System.Drawing.Size(164, 121);
            this.bBerechnen.TabIndex = 0;
            this.bBerechnen.Text = "Berechnen";
            this.bBerechnen.UseVisualStyleBackColor = true;
            this.bBerechnen.Click += new System.EventHandler(this.bBerechnen_Click);
            // 
            // lBSpalte
            // 
            this.lBSpalte.FormattingEnabled = true;
            this.lBSpalte.Items.AddRange(new object[] {
            "A*",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.lBSpalte.Location = new System.Drawing.Point(12, 41);
            this.lBSpalte.Name = "lBSpalte";
            this.lBSpalte.Size = new System.Drawing.Size(120, 121);
            this.lBSpalte.TabIndex = 1;
            this.lBSpalte.SelectedIndexChanged += new System.EventHandler(this.lBSpalte_SelectedIndexChanged);
            // 
            // nUDStartwert
            // 
            this.nUDStartwert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDStartwert.AutoSize = true;
            this.nUDStartwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDStartwert.Location = new System.Drawing.Point(138, 93);
            this.nUDStartwert.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUDStartwert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nUDStartwert.Name = "nUDStartwert";
            this.nUDStartwert.Size = new System.Drawing.Size(465, 29);
            this.nUDStartwert.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spalte";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aktuell";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endwert";
            // 
            // nUDEndwert
            // 
            this.nUDEndwert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nUDEndwert.AutoSize = true;
            this.nUDEndwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDEndwert.Location = new System.Drawing.Point(609, 93);
            this.nUDEndwert.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUDEndwert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDEndwert.Name = "nUDEndwert";
            this.nUDEndwert.Size = new System.Drawing.Size(120, 29);
            this.nUDEndwert.TabIndex = 7;
            this.nUDEndwert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "AP Preis";
            // 
            // tBAPPreis
            // 
            this.tBAPPreis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBAPPreis.BackColor = System.Drawing.SystemColors.Control;
            this.tBAPPreis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBAPPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.tBAPPreis.Location = new System.Drawing.Point(12, 277);
            this.tBAPPreis.Name = "tBAPPreis";
            this.tBAPPreis.ReadOnly = true;
            this.tBAPPreis.Size = new System.Drawing.Size(202, 37);
            this.tBAPPreis.TabIndex = 10;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "csv";
            this.OpenFileDialog.FileName = "SteigerungsTabelle";
            this.OpenFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            this.OpenFileDialog.Title = "Datei öffnen";
            // 
            // cBEidetisch
            // 
            this.cBEidetisch.AutoSize = true;
            this.cBEidetisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBEidetisch.Location = new System.Drawing.Point(138, 169);
            this.cBEidetisch.Name = "cBEidetisch";
            this.cBEidetisch.Size = new System.Drawing.Size(340, 35);
            this.cBEidetisch.TabIndex = 12;
            this.cBEidetisch.Text = "Eidetisches Gedächtnis";
            this.cBEidetisch.UseVisualStyleBackColor = true;
            // 
            // cBAkademisch
            // 
            this.cBAkademisch.AutoSize = true;
            this.cBAkademisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAkademisch.Location = new System.Drawing.Point(138, 210);
            this.cBAkademisch.Name = "cBAkademisch";
            this.cBAkademisch.Size = new System.Drawing.Size(359, 35);
            this.cBAkademisch.TabIndex = 13;
            this.cBAkademisch.Text = "Akademische Ausbildung";
            this.cBAkademisch.UseVisualStyleBackColor = true;
            // 
            // cBGut
            // 
            this.cBGut.AutoSize = true;
            this.cBGut.Enabled = false;
            this.cBGut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGut.Location = new System.Drawing.Point(138, 128);
            this.cBGut.Name = "cBGut";
            this.cBGut.Size = new System.Drawing.Size(267, 35);
            this.cBGut.TabIndex = 14;
            this.cBGut.Text = "Gutes Gedächtnis";
            this.cBGut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 333);
            this.Controls.Add(this.cBGut);
            this.Controls.Add(this.cBAkademisch);
            this.Controls.Add(this.cBEidetisch);
            this.Controls.Add(this.tBAPPreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDEndwert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDStartwert);
            this.Controls.Add(this.lBSpalte);
            this.Controls.Add(this.bBerechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AP Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDStartwert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEndwert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBerechnen;
        private System.Windows.Forms.ListBox lBSpalte;
        private System.Windows.Forms.NumericUpDown nUDStartwert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDEndwert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBAPPreis;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.CheckBox cBEidetisch;
        private System.Windows.Forms.CheckBox cBAkademisch;
        private System.Windows.Forms.CheckBox cBGut;
    }
}

