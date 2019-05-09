﻿namespace Barcelona
{
    partial class Gebruiker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gebruiker));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKeuze = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartscherm = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lstAlleKeuzeActiviteiten = new System.Windows.Forms.ListBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGsmNummer = new System.Windows.Forms.TextBox();
            this.strnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.cmbKlas = new System.Windows.Forms.ComboBox();
            this.pcbURL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbURL)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kies uw activiteiten";
            // 
            // cmbKeuze
            // 
            this.cmbKeuze.FormattingEnabled = true;
            this.cmbKeuze.Location = new System.Drawing.Point(444, 91);
            this.cmbKeuze.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKeuze.Name = "cmbKeuze";
            this.cmbKeuze.Size = new System.Drawing.Size(160, 24);
            this.cmbKeuze.TabIndex = 6;
            this.cmbKeuze.SelectedIndexChanged += new System.EventHandler(this.cmbKeuze_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voor:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnStartscherm
            // 
            this.btnStartscherm.Location = new System.Drawing.Point(13, 228);
            this.btnStartscherm.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartscherm.Name = "btnStartscherm";
            this.btnStartscherm.Size = new System.Drawing.Size(145, 73);
            this.btnStartscherm.TabIndex = 12;
            this.btnStartscherm.Text = "Terug";
            this.btnStartscherm.UseVisualStyleBackColor = true;
            this.btnStartscherm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(473, 124);
            this.btnVolgende.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(132, 28);
            this.btnVolgende.TabIndex = 7;
            this.btnVolgende.Text = "Bevestig keuze";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(420, 160);
            this.btnRegistreer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(184, 47);
            this.btnRegistreer.TabIndex = 5;
            this.btnRegistreer.Text = "Voeg leerling toe";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(433, 63);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(16, 17);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "_";
            // 
            // lstAlleKeuzeActiviteiten
            // 
            this.lstAlleKeuzeActiviteiten.FormattingEnabled = true;
            this.lstAlleKeuzeActiviteiten.ItemHeight = 16;
            this.lstAlleKeuzeActiviteiten.Location = new System.Drawing.Point(185, 213);
            this.lstAlleKeuzeActiviteiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAlleKeuzeActiviteiten.Name = "lstAlleKeuzeActiviteiten";
            this.lstAlleKeuzeActiviteiten.Size = new System.Drawing.Size(253, 84);
            this.lstAlleKeuzeActiviteiten.TabIndex = 15;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(196, 28);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(160, 22);
            this.txtVoornaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voornaam";
            // 
            // txtGsmNummer
            // 
            this.txtGsmNummer.Location = new System.Drawing.Point(196, 92);
            this.txtGsmNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtGsmNummer.Name = "txtGsmNummer";
            this.txtGsmNummer.Size = new System.Drawing.Size(160, 22);
            this.txtGsmNummer.TabIndex = 3;
            // 
            // strnaam
            // 
            this.strnaam.Location = new System.Drawing.Point(196, 60);
            this.strnaam.Margin = new System.Windows.Forms.Padding(4);
            this.strnaam.Name = "strnaam";
            this.strnaam.Size = new System.Drawing.Size(160, 22);
            this.strnaam.TabIndex = 2;
            this.strnaam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Klas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gsmnummer";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(39, 64);
            this.lblAchternaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(84, 17);
            this.lblAchternaam.TabIndex = 7;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // cmbKlas
            // 
            this.cmbKlas.FormattingEnabled = true;
            this.cmbKlas.Items.AddRange(new object[] {
            "6AIT",
            "6ITN",
            "6MO1",
            "6MO2",
            "6OMC"});
            this.cmbKlas.Location = new System.Drawing.Point(260, 124);
            this.cmbKlas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKlas.Name = "cmbKlas";
            this.cmbKlas.Size = new System.Drawing.Size(96, 24);
            this.cmbKlas.TabIndex = 4;
            // 
            // pcbURL
            // 
            this.pcbURL.Location = new System.Drawing.Point(621, 12);
            this.pcbURL.Name = "pcbURL";
            this.pcbURL.Size = new System.Drawing.Size(255, 289);
            this.pcbURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbURL.TabIndex = 16;
            this.pcbURL.TabStop = false;
            // 
            // Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(888, 314);
            this.Controls.Add(this.pcbURL);
            this.Controls.Add(this.lstAlleKeuzeActiviteiten);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnStartscherm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKeuze);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKlas);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.strnaam);
            this.Controls.Add(this.txtGsmNummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVoornaam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gebruiker";
            this.Text = "Voeg een leerling toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gebruiker_FormClosed);
            this.Load += new System.EventHandler(this.VoegLeerlingToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbURL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKeuze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartscherm;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ListBox lstAlleKeuzeActiviteiten;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGsmNummer;
        private System.Windows.Forms.TextBox strnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.ComboBox cmbKlas;
        private System.Windows.Forms.PictureBox pcbURL;
    }
}

