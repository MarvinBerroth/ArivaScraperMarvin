namespace ArivaScraperMarvin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnScraping = new System.Windows.Forms.Button();
            this.BtnAddtoSQL = new System.Windows.Forms.Button();
            this.BtnDatenüberprüfen = new System.Windows.Forms.Button();
            this.LUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(64, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(651, 44);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnScraping
            // 
            this.BtnScraping.Location = new System.Drawing.Point(64, 345);
            this.BtnScraping.Name = "BtnScraping";
            this.BtnScraping.Size = new System.Drawing.Size(197, 34);
            this.BtnScraping.TabIndex = 1;
            this.BtnScraping.Text = "Daten Scraping";
            this.BtnScraping.UseVisualStyleBackColor = true;
            this.BtnScraping.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddtoSQL
            // 
            this.BtnAddtoSQL.Location = new System.Drawing.Point(540, 345);
            this.BtnAddtoSQL.Name = "BtnAddtoSQL";
            this.BtnAddtoSQL.Size = new System.Drawing.Size(175, 34);
            this.BtnAddtoSQL.TabIndex = 2;
            this.BtnAddtoSQL.Text = "Daten hinzufügen";
            this.BtnAddtoSQL.UseVisualStyleBackColor = true;
            // 
            // BtnDatenüberprüfen
            // 
            this.BtnDatenüberprüfen.Location = new System.Drawing.Point(295, 345);
            this.BtnDatenüberprüfen.Name = "BtnDatenüberprüfen";
            this.BtnDatenüberprüfen.Size = new System.Drawing.Size(202, 34);
            this.BtnDatenüberprüfen.TabIndex = 3;
            this.BtnDatenüberprüfen.Text = "Daten überprüfen";
            this.BtnDatenüberprüfen.UseVisualStyleBackColor = true;
            this.BtnDatenüberprüfen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LUrl
            // 
            this.LUrl.AutoSize = true;
            this.LUrl.Location = new System.Drawing.Point(64, 48);
            this.LUrl.Name = "LUrl";
            this.LUrl.Size = new System.Drawing.Size(631, 25);
            this.LUrl.TabIndex = 4;
            this.LUrl.Text = "Url eintragen z.b --> https://www.ariva.de/ado_properties_s-a-aktie/bilanz-guv";
            this.LUrl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LUrl);
            this.Controls.Add(this.BtnDatenüberprüfen);
            this.Controls.Add(this.BtnAddtoSQL);
            this.Controls.Add(this.BtnScraping);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnScraping;
        private System.Windows.Forms.Button BtnAddtoSQL;
        private System.Windows.Forms.Button BtnDatenüberprüfen;
        private System.Windows.Forms.Label LUrl;
    }
}

