﻿namespace DSATools
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
            this.bTabelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDStartwert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEndwert)).BeginInit();
            this.SuspendLayout();
            // 
            // bBerechnen
            // 
            this.bBerechnen.Enabled = false;
            this.bBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBerechnen.Location = new System.Drawing.Point(227, 200);
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
            this.nUDStartwert.Size = new System.Drawing.Size(120, 29);
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
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aktuell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endwert";
            // 
            // nUDEndwert
            // 
            this.nUDEndwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDEndwert.Location = new System.Drawing.Point(264, 93);
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
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "AP Preis";
            // 
            // tBAPPreis
            // 
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
            // bTabelle
            // 
            this.bTabelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTabelle.Location = new System.Drawing.Point(227, 128);
            this.bTabelle.Name = "bTabelle";
            this.bTabelle.Size = new System.Drawing.Size(164, 66);
            this.bTabelle.TabIndex = 11;
            this.bTabelle.Text = "Tabelle Laden";
            this.bTabelle.UseVisualStyleBackColor = true;
            this.bTabelle.Click += new System.EventHandler(this.bTabelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 333);
            this.Controls.Add(this.bTabelle);
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
        private System.Windows.Forms.Button bTabelle;
    }
}

