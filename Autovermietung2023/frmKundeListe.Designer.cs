namespace Autovermietung2023
{
    partial class frmAddnewKunde
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
            this.components = new System.ComponentModel.Container();
            this.gbKundeDaten = new System.Windows.Forms.GroupBox();
            this.dtpKundeSeit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKundeNummer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtPostleitzahl = new System.Windows.Forms.TextBox();
            this.txtStraße = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKontaktDaten = new System.Windows.Forms.GroupBox();
            this.txtTelefon2 = new System.Windows.Forms.TextBox();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKontaktID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.bntAbrechen = new System.Windows.Forms.Button();
            this.txtLizenzNummer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbGeschlecht = new System.Windows.Forms.ComboBox();
            this.gbKundeDaten.SuspendLayout();
            this.gbKontaktDaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKundeDaten
            // 
            this.gbKundeDaten.Controls.Add(this.cbGeschlecht);
            this.gbKundeDaten.Controls.Add(this.textBox1);
            this.gbKundeDaten.Controls.Add(this.label16);
            this.gbKundeDaten.Controls.Add(this.txtLizenzNummer);
            this.gbKundeDaten.Controls.Add(this.label15);
            this.gbKundeDaten.Controls.Add(this.dtpKundeSeit);
            this.gbKundeDaten.Controls.Add(this.label9);
            this.gbKundeDaten.Controls.Add(this.txtKundeNummer);
            this.gbKundeDaten.Controls.Add(this.label8);
            this.gbKundeDaten.Controls.Add(this.dtpGeburtsdatum);
            this.gbKundeDaten.Controls.Add(this.txtOrt);
            this.gbKundeDaten.Controls.Add(this.txtPostleitzahl);
            this.gbKundeDaten.Controls.Add(this.txtStraße);
            this.gbKundeDaten.Controls.Add(this.txtVorname);
            this.gbKundeDaten.Controls.Add(this.txtName);
            this.gbKundeDaten.Controls.Add(this.label7);
            this.gbKundeDaten.Controls.Add(this.label6);
            this.gbKundeDaten.Controls.Add(this.label5);
            this.gbKundeDaten.Controls.Add(this.label4);
            this.gbKundeDaten.Controls.Add(this.label3);
            this.gbKundeDaten.Controls.Add(this.label2);
            this.gbKundeDaten.Controls.Add(this.label1);
            this.gbKundeDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKundeDaten.Location = new System.Drawing.Point(12, 12);
            this.gbKundeDaten.Name = "gbKundeDaten";
            this.gbKundeDaten.Size = new System.Drawing.Size(948, 427);
            this.gbKundeDaten.TabIndex = 0;
            this.gbKundeDaten.TabStop = false;
            this.gbKundeDaten.Text = "Kunde daten";
            // 
            // dtpKundeSeit
            // 
            this.dtpKundeSeit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKundeSeit.Location = new System.Drawing.Point(591, 326);
            this.dtpKundeSeit.Name = "dtpKundeSeit";
            this.dtpKundeSeit.Size = new System.Drawing.Size(315, 26);
            this.dtpKundeSeit.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "KundeSeit:";
            // 
            // txtKundeNummer
            // 
            this.txtKundeNummer.Location = new System.Drawing.Point(151, 36);
            this.txtKundeNummer.MaxLength = 50;
            this.txtKundeNummer.Name = "txtKundeNummer";
            this.txtKundeNummer.ReadOnly = true;
            this.txtKundeNummer.Size = new System.Drawing.Size(315, 26);
            this.txtKundeNummer.TabIndex = 17;
            this.txtKundeNummer.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kundenummer:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(151, 189);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(315, 26);
            this.dtpGeburtsdatum.TabIndex = 13;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(512, 263);
            this.txtOrt.MaxLength = 50;
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(315, 26);
            this.txtOrt.TabIndex = 12;
            // 
            // txtPostleitzahl
            // 
            this.txtPostleitzahl.Location = new System.Drawing.Point(140, 328);
            this.txtPostleitzahl.MaxLength = 5;
            this.txtPostleitzahl.Name = "txtPostleitzahl";
            this.txtPostleitzahl.Size = new System.Drawing.Size(315, 26);
            this.txtPostleitzahl.TabIndex = 11;
            // 
            // txtStraße
            // 
            this.txtStraße.Location = new System.Drawing.Point(512, 191);
            this.txtStraße.MaxLength = 50;
            this.txtStraße.Name = "txtStraße";
            this.txtStraße.Size = new System.Drawing.Size(315, 26);
            this.txtStraße.TabIndex = 10;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(512, 106);
            this.txtVorname.MaxLength = 50;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(315, 26);
            this.txtVorname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 106);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 26);
            this.txtName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ort:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postleitzahl:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Straße:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geschlecht:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtsdatum:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbKontaktDaten
            // 
            this.gbKontaktDaten.Controls.Add(this.txtTelefon2);
            this.gbKontaktDaten.Controls.Add(this.txtTelefon1);
            this.gbKontaktDaten.Controls.Add(this.label13);
            this.gbKontaktDaten.Controls.Add(this.label14);
            this.gbKontaktDaten.Controls.Add(this.txtKontaktID);
            this.gbKontaktDaten.Controls.Add(this.label10);
            this.gbKontaktDaten.Controls.Add(this.txtPasswort);
            this.gbKontaktDaten.Controls.Add(this.txtEmail);
            this.gbKontaktDaten.Controls.Add(this.label11);
            this.gbKontaktDaten.Controls.Add(this.label12);
            this.gbKontaktDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKontaktDaten.Location = new System.Drawing.Point(12, 445);
            this.gbKontaktDaten.Name = "gbKontaktDaten";
            this.gbKontaktDaten.Size = new System.Drawing.Size(499, 259);
            this.gbKontaktDaten.TabIndex = 1;
            this.gbKontaktDaten.TabStop = false;
            this.gbKontaktDaten.Text = "Kontakt daten";
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(151, 204);
            this.txtTelefon2.MaxLength = 12;
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(315, 26);
            this.txtTelefon2.TabIndex = 27;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(151, 164);
            this.txtTelefon1.MaxLength = 12;
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(315, 26);
            this.txtTelefon1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Telefon2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Telefon1:";
            // 
            // txtKontaktID
            // 
            this.txtKontaktID.Location = new System.Drawing.Point(151, 44);
            this.txtKontaktID.MaxLength = 50;
            this.txtKontaktID.Name = "txtKontaktID";
            this.txtKontaktID.ReadOnly = true;
            this.txtKontaktID.Size = new System.Drawing.Size(315, 26);
            this.txtKontaktID.TabIndex = 23;
            this.txtKontaktID.Text = "-1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "KontaktID:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(151, 124);
            this.txtPasswort.MaxLength = 50;
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(315, 26);
            this.txtPasswort.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 84);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 26);
            this.txtEmail.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Passwort:*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Email:*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(141, 710);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(135, 40);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Daten speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // bntAbrechen
            // 
            this.bntAbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAbrechen.Location = new System.Drawing.Point(343, 710);
            this.bntAbrechen.Name = "bntAbrechen";
            this.bntAbrechen.Size = new System.Drawing.Size(135, 40);
            this.bntAbrechen.TabIndex = 3;
            this.bntAbrechen.Text = "Abbrechen";
            this.bntAbrechen.UseVisualStyleBackColor = true;
            this.bntAbrechen.Click += new System.EventHandler(this.bntAbrechen_Click);
            // 
            // txtLizenzNummer
            // 
            this.txtLizenzNummer.Location = new System.Drawing.Point(140, 375);
            this.txtLizenzNummer.MaxLength = 5;
            this.txtLizenzNummer.Name = "txtLizenzNummer";
            this.txtLizenzNummer.Size = new System.Drawing.Size(315, 26);
            this.txtLizenzNummer.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Lizenznummer:*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 372);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 26);
            this.textBox1.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(458, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Lizenznummer:*";
            // 
            // cbGeschlecht
            // 
            this.cbGeschlecht.FormattingEnabled = true;
            this.cbGeschlecht.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbGeschlecht.Location = new System.Drawing.Point(151, 267);
            this.cbGeschlecht.Name = "cbGeschlecht";
            this.cbGeschlecht.Size = new System.Drawing.Size(315, 28);
            this.cbGeschlecht.TabIndex = 24;
            // 
            // frmAddnewKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 759);
            this.Controls.Add(this.bntAbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.gbKontaktDaten);
            this.Controls.Add(this.gbKundeDaten);
            this.Name = "frmAddnewKunde";
            this.Text = "Addneu_Kunde";
            this.Load += new System.EventHandler(this.frmAddnewKunde_Load);
            this.gbKundeDaten.ResumeLayout(false);
            this.gbKundeDaten.PerformLayout();
            this.gbKontaktDaten.ResumeLayout(false);
            this.gbKontaktDaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKundeDaten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtPostleitzahl;
        private System.Windows.Forms.TextBox txtStraße;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKundeNummer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbKontaktDaten;
        private System.Windows.Forms.DateTimePicker dtpKundeSeit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon2;
        private System.Windows.Forms.TextBox txtTelefon1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKontaktID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bntAbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLizenzNummer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbGeschlecht;
    }
}