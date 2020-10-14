namespace DSATools
{
    partial class Main
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
            this.bSteigern = new System.Windows.Forms.Button();
            this.bZauberwerkstatt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSteigern
            // 
            this.bSteigern.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSteigern.Location = new System.Drawing.Point(12, 12);
            this.bSteigern.Name = "bSteigern";
            this.bSteigern.Size = new System.Drawing.Size(308, 164);
            this.bSteigern.TabIndex = 0;
            this.bSteigern.Text = "Steigerungsrechner";
            this.bSteigern.UseVisualStyleBackColor = true;
            this.bSteigern.Click += new System.EventHandler(this.bSteigern_Click);
            // 
            // bZauberwerkstatt
            // 
            this.bZauberwerkstatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZauberwerkstatt.Location = new System.Drawing.Point(12, 182);
            this.bZauberwerkstatt.Name = "bZauberwerkstatt";
            this.bZauberwerkstatt.Size = new System.Drawing.Size(308, 164);
            this.bZauberwerkstatt.TabIndex = 1;
            this.bZauberwerkstatt.Text = "Zauberwerkstatt";
            this.bZauberwerkstatt.UseVisualStyleBackColor = true;
            this.bZauberwerkstatt.Click += new System.EventHandler(this.bZauberwerkstatt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 362);
            this.Controls.Add(this.bZauberwerkstatt);
            this.Controls.Add(this.bSteigern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSteigern;
        private System.Windows.Forms.Button bZauberwerkstatt;
    }
}