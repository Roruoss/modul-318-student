using System;

namespace Fahrplan_Romano_Ruoss
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoogleMaps = new System.Windows.Forms.Button();
            this.lsbEnd = new System.Windows.Forms.ListBox();
            this.lsbStart = new System.Windows.Forms.ListBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtZeit = new System.Windows.Forms.DateTimePicker();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.lbLaden = new System.Windows.Forms.Label();
            this.lbswitch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVerbindungen = new System.Windows.Forms.DataGridView();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.WBGMaps = new System.Windows.Forms.WebBrowser();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.WBGMaps);
            this.panel1.Controls.Add(this.btnGoogleMaps);
            this.panel1.Controls.Add(this.lsbEnd);
            this.panel1.Controls.Add(this.lsbStart);
            this.panel1.Controls.Add(this.btnSchliessen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAbfahrtstafel);
            this.panel1.Controls.Add(this.btnSuchen);
            this.panel1.Controls.Add(this.dtZeit);
            this.panel1.Controls.Add(this.dtDatum);
            this.panel1.Controls.Add(this.lbLaden);
            this.panel1.Controls.Add(this.lbswitch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgVerbindungen);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 647);
            this.panel1.TabIndex = 0;
            // 
            // btnGoogleMaps
            // 
            this.btnGoogleMaps.Location = new System.Drawing.Point(417, 159);
            this.btnGoogleMaps.Name = "btnGoogleMaps";
            this.btnGoogleMaps.Size = new System.Drawing.Size(144, 75);
            this.btnGoogleMaps.TabIndex = 18;
            this.btnGoogleMaps.Text = "Google Maps";
            this.btnGoogleMaps.UseVisualStyleBackColor = true;
            this.btnGoogleMaps.Click += new System.EventHandler(this.btnGoogleMaps_Click);
            // 
            // lsbEnd
            // 
            this.lsbEnd.FormattingEnabled = true;
            this.lsbEnd.Location = new System.Drawing.Point(243, 83);
            this.lsbEnd.Name = "lsbEnd";
            this.lsbEnd.Size = new System.Drawing.Size(129, 43);
            this.lsbEnd.TabIndex = 17;
            this.lsbEnd.SelectedIndexChanged += new System.EventHandler(this.lsbEnd_SelectedIndexChanged);
            // 
            // lsbStart
            // 
            this.lsbStart.FormattingEnabled = true;
            this.lsbStart.Location = new System.Drawing.Point(39, 83);
            this.lsbStart.Name = "lsbStart";
            this.lsbStart.Size = new System.Drawing.Size(130, 43);
            this.lsbStart.TabIndex = 16;
            this.lsbStart.SelectedIndexChanged += new System.EventHandler(this.lsbStart_SelectedIndexChanged);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(417, 83);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(144, 71);
            this.btnSchliessen.TabIndex = 15;
            this.btnSchliessen.Text = "App beenden";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum";
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(182, 325);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(105, 20);
            this.btnEmail.TabIndex = 12;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Verbindungen";
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(417, 9);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(144, 68);
            this.btnAbfahrtstafel.TabIndex = 10;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(417, 240);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(144, 60);
            this.btnSuchen.TabIndex = 9;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // dtZeit
            // 
            this.dtZeit.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtZeit.CustomFormat = "HH.mm";
            this.dtZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtZeit.Location = new System.Drawing.Point(39, 248);
            this.dtZeit.Name = "dtZeit";
            this.dtZeit.ShowUpDown = true;
            this.dtZeit.Size = new System.Drawing.Size(200, 20);
            this.dtZeit.TabIndex = 8;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(39, 184);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 7;
            // 
            // lbLaden
            // 
            this.lbLaden.AutoSize = true;
            this.lbLaden.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaden.Location = new System.Drawing.Point(444, 478);
            this.lbLaden.Name = "lbLaden";
            this.lbLaden.Size = new System.Drawing.Size(200, 31);
            this.lbLaden.TabIndex = 6;
            this.lbLaden.Text = "Der Fahrplan lädt...";
            // 
            // lbswitch
            // 
            this.lbswitch.AutoSize = true;
            this.lbswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbswitch.Location = new System.Drawing.Point(187, 46);
            this.lbswitch.Name = "lbswitch";
            this.lbswitch.Size = new System.Drawing.Size(27, 20);
            this.lbswitch.TabIndex = 5;
            this.lbswitch.Text = "<>";
            this.lbswitch.Click += new System.EventHandler(this.lbswitch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Von";
            // 
            // dtgVerbindungen
            // 
            this.dtgVerbindungen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVerbindungen.Location = new System.Drawing.Point(51, 408);
            this.dtgVerbindungen.Name = "dtgVerbindungen";
            this.dtgVerbindungen.Size = new System.Drawing.Size(929, 187);
            this.dtgVerbindungen.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(243, 46);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(129, 31);
            this.txtEnd.TabIndex = 1;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(39, 46);
            this.txtStart.Multiline = true;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(130, 31);
            this.txtStart.TabIndex = 0;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // WBGMaps
            // 
            this.WBGMaps.Location = new System.Drawing.Point(635, 9);
            this.WBGMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBGMaps.Name = "WBGMaps";
            this.WBGMaps.Size = new System.Drawing.Size(345, 379);
            this.WBGMaps.TabIndex = 19;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(51, 325);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 712);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVerbindungen)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbswitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgVerbindungen;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lbLaden;
        private System.Windows.Forms.DateTimePicker dtZeit;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.ListBox lsbEnd;
        private System.Windows.Forms.ListBox lsbStart;
        private System.Windows.Forms.Button btnGoogleMaps;
        private System.Windows.Forms.WebBrowser WBGMaps;
        private System.Windows.Forms.TextBox txtMail;
    }
}

