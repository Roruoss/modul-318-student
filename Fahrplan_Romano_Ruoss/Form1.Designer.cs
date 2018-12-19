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
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtstar = new System.Windows.Forms.TextBox();
            this.lblverb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnswitch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtend);
            this.panel1.Controls.Add(this.txtstar);
            this.panel1.Controls.Add(this.lblverb);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtZeit);
            this.panel1.Controls.Add(this.txtDatum);
            this.panel1.Controls.Add(this.btnswitch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSuchen);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 677);
            this.panel1.TabIndex = 0;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(355, 97);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(100, 25);
            this.txtend.TabIndex = 13;
            // 
            // txtstar
            // 
            this.txtstar.Location = new System.Drawing.Point(53, 97);
            this.txtstar.Name = "txtstar";
            this.txtstar.Size = new System.Drawing.Size(100, 25);
            this.txtstar.TabIndex = 12;
            this.txtstar.TextChanged += new System.EventHandler(this.txtstar_TextChanged);
            // 
            // lblverb
            // 
            this.lblverb.AutoSize = true;
            this.lblverb.Location = new System.Drawing.Point(49, 350);
            this.lblverb.Name = "lblverb";
            this.lblverb.Size = new System.Drawing.Size(86, 20);
            this.lblverb.TabIndex = 11;
            this.lblverb.Text = "Verbindungen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum";
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(355, 196);
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(110, 25);
            this.txtZeit.TabIndex = 7;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(50, 196);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(135, 25);
            this.txtDatum.TabIndex = 6;
            // 
            // btnswitch
            // 
            this.btnswitch.Location = new System.Drawing.Point(211, 85);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(105, 33);
            this.btnswitch.TabIndex = 5;
            this.btnswitch.Text = "<>";
            this.btnswitch.UseVisualStyleBackColor = true;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(50, 248);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(135, 52);
            this.btnSuchen.TabIndex = 0;
            this.btnSuchen.Text = "Verbindungen suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 712);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void combstart_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZeit;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblverb;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtstar;
    }
}

