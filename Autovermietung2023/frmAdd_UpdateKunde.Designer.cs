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
            this.dtpAblaufDatum = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpAusstaltungsDatum = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLizenzDateiHochladen = new System.Windows.Forms.Button();
            this.cbGeschlecht = new System.Windows.Forms.ComboBox();
            this.txtLizenzFoto = new System.Windows.Forms.TextBox();
            this.txtLizenzNummer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbKundeDaten.SuspendLayout();
            this.gbKontaktDaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKundeDaten
            // 
            this.gbKundeDaten.Controls.Add(this.dtpAblaufDatum);
            this.gbKundeDaten.Controls.Add(this.label17);
            this.gbKundeDaten.Controls.Add(this.dtpAusstaltungsDatum);
            this.gbKundeDaten.Controls.Add(this.label16);
            this.gbKundeDaten.Controls.Add(this.btnLizenzDateiHochladen);
            this.gbKundeDaten.Controls.Add(this.cbGeschlecht);
            this.gbKundeDaten.Controls.Add(this.txtLizenzFoto);
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
            this.gbKundeDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKundeDaten.Location = new System.Drawing.Point(16, 15);
            this.gbKundeDaten.Margin = new System.Windows.Forms.Padding(4);
            this.gbKundeDaten.Name = "gbKundeDaten";
            this.gbKundeDaten.Padding = new System.Windows.Forms.Padding(4);
            this.gbKundeDaten.Size = new System.Drawing.Size(1399, 526);
            this.gbKundeDaten.TabIndex = 0;
            this.gbKundeDaten.TabStop = false;
            this.gbKundeDaten.Text = "Kunde daten";
            // 
            // dtpAblaufDatum
            // 
            this.dtpAblaufDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAblaufDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAblaufDatum.Location = new System.Drawing.Point(912, 444);
            this.dtpAblaufDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAblaufDatum.Name = "dtpAblaufDatum";
            this.dtpAblaufDatum.Size = new System.Drawing.Size(419, 41);
            this.dtpAblaufDatum.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(712, 449);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 29);
            this.label17.TabIndex = 28;
            this.label17.Text = "AblaufDatum:*";
            // 
            // dtpAusstaltungsDatum
            // 
            this.dtpAusstaltungsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAusstaltungsDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAusstaltungsDatum.Location = new System.Drawing.Point(236, 439);
            this.dtpAusstaltungsDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAusstaltungsDatum.Name = "dtpAusstaltungsDatum";
            this.dtpAusstaltungsDatum.Size = new System.Drawing.Size(419, 41);
            this.dtpAusstaltungsDatum.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 444);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 29);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ausst_datum:*";
            // 
            // btnLizenzDateiHochladen
            // 
            this.btnLizenzDateiHochladen.Location = new System.Drawing.Point(735, 372);
            this.btnLizenzDateiHochladen.Name = "btnLizenzDateiHochladen";
            this.btnLizenzDateiHochladen.Size = new System.Drawing.Size(147, 40);
            this.btnLizenzDateiHochladen.TabIndex = 25;
            this.btnLizenzDateiHochladen.Text = "Lizenz-Bild";
            this.btnLizenzDateiHochladen.UseVisualStyleBackColor = true;
            this.btnLizenzDateiHochladen.Click += new System.EventHandler(this.btnLizenzDateiHochladen_Click);
            // 
            // cbGeschlecht
            // 
            this.cbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeschlecht.FormattingEnabled = true;
            this.cbGeschlecht.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbGeschlecht.Location = new System.Drawing.Point(240, 247);
            this.cbGeschlecht.Margin = new System.Windows.Forms.Padding(4);
            this.cbGeschlecht.Name = "cbGeschlecht";
            this.cbGeschlecht.Size = new System.Drawing.Size(419, 44);
            this.cbGeschlecht.TabIndex = 4;
            // 
            // txtLizenzFoto
            // 
            this.txtLizenzFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLizenzFoto.Location = new System.Drawing.Point(912, 368);
            this.txtLizenzFoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtLizenzFoto.MaxLength = 255;
            this.txtLizenzFoto.Name = "txtLizenzFoto";
            this.txtLizenzFoto.Size = new System.Drawing.Size(420, 41);
            this.txtLizenzFoto.TabIndex = 9;
            // 
            // txtLizenzNummer
            // 
            this.txtLizenzNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLizenzNummer.Location = new System.Drawing.Point(239, 376);
            this.txtLizenzNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtLizenzNummer.MaxLength = 12;
            this.txtLizenzNummer.Name = "txtLizenzNummer";
            this.txtLizenzNummer.Size = new System.Drawing.Size(419, 41);
            this.txtLizenzNummer.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 378);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Lizenznummer:*";
            // 
            // dtpKundeSeit
            // 
            this.dtpKundeSeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKundeSeit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKundeSeit.Location = new System.Drawing.Point(912, 307);
            this.dtpKundeSeit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKundeSeit.Name = "dtpKundeSeit";
            this.dtpKundeSeit.Size = new System.Drawing.Size(419, 41);
            this.dtpKundeSeit.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "KundeSeit:";
            // 
            // txtKundeNummer
            // 
            this.txtKundeNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundeNummer.Location = new System.Drawing.Point(240, 52);
            this.txtKundeNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtKundeNummer.MaxLength = 50;
            this.txtKundeNummer.Name = "txtKundeNummer";
            this.txtKundeNummer.ReadOnly = true;
            this.txtKundeNummer.Size = new System.Drawing.Size(419, 41);
            this.txtKundeNummer.TabIndex = 17;
            this.txtKundeNummer.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kundenummer:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGeburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(240, 182);
            this.dtpGeburtsdatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(419, 41);
            this.dtpGeburtsdatum.TabIndex = 2;
            // 
            // txtOrt
            // 
            this.txtOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrt.Location = new System.Drawing.Point(912, 249);
            this.txtOrt.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrt.MaxLength = 50;
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(419, 41);
            this.txtOrt.TabIndex = 5;
            // 
            // txtPostleitzahl
            // 
            this.txtPostleitzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostleitzahl.Location = new System.Drawing.Point(240, 315);
            this.txtPostleitzahl.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostleitzahl.MaxLength = 5;
            this.txtPostleitzahl.Name = "txtPostleitzahl";
            this.txtPostleitzahl.Size = new System.Drawing.Size(419, 41);
            this.txtPostleitzahl.TabIndex = 6;
            // 
            // txtStraße
            // 
            this.txtStraße.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStraße.Location = new System.Drawing.Point(912, 186);
            this.txtStraße.Margin = new System.Windows.Forms.Padding(4);
            this.txtStraße.MaxLength = 50;
            this.txtStraße.Name = "txtStraße";
            this.txtStraße.Size = new System.Drawing.Size(419, 41);
            this.txtStraße.TabIndex = 3;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(912, 119);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(4);
            this.txtVorname.MaxLength = 50;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(419, 41);
            this.txtVorname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(240, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(419, 41);
            this.txtName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ort:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postleitzahl:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Straße:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geschlecht:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtsdatum:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:*";
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
            this.gbKontaktDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKontaktDaten.Location = new System.Drawing.Point(16, 549);
            this.gbKontaktDaten.Margin = new System.Windows.Forms.Padding(4);
            this.gbKontaktDaten.Name = "gbKontaktDaten";
            this.gbKontaktDaten.Padding = new System.Windows.Forms.Padding(4);
            this.gbKontaktDaten.Size = new System.Drawing.Size(1399, 261);
            this.gbKontaktDaten.TabIndex = 1;
            this.gbKontaktDaten.TabStop = false;
            this.gbKontaktDaten.Text = "Kontakt daten";
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon2.Location = new System.Drawing.Point(902, 190);
            this.txtTelefon2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon2.MaxLength = 12;
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(419, 41);
            this.txtTelefon2.TabIndex = 15;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon1.Location = new System.Drawing.Point(238, 186);
            this.txtTelefon1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon1.MaxLength = 12;
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(419, 41);
            this.txtTelefon1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(765, 195);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Telefon2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(84, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = "Telefon1:";
            // 
            // txtKontaktID
            // 
            this.txtKontaktID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontaktID.Location = new System.Drawing.Point(236, 51);
            this.txtKontaktID.Margin = new System.Windows.Forms.Padding(4);
            this.txtKontaktID.MaxLength = 50;
            this.txtKontaktID.Name = "txtKontaktID";
            this.txtKontaktID.ReadOnly = true;
            this.txtKontaktID.Size = new System.Drawing.Size(419, 41);
            this.txtKontaktID.TabIndex = 23;
            this.txtKontaktID.Text = "-1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "KontaktID:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(902, 117);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswort.MaxLength = 50;
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(419, 41);
            this.txtPasswort.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(236, 118);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(419, 41);
            this.txtEmail.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Passwort:*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Email:*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(252, 829);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(273, 65);
            this.btnSpeichern.TabIndex = 16;
            this.btnSpeichern.Text = "Daten speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // bntAbrechen
            // 
            this.bntAbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAbrechen.Location = new System.Drawing.Point(567, 829);
            this.bntAbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.bntAbrechen.Name = "bntAbrechen";
            this.bntAbrechen.Size = new System.Drawing.Size(273, 65);
            this.bntAbrechen.TabIndex = 17;
            this.bntAbrechen.Text = "Abbrechen";
            this.bntAbrechen.UseVisualStyleBackColor = true;
            this.bntAbrechen.Click += new System.EventHandler(this.bntAbrechen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmAddnewKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 934);
            this.Controls.Add(this.bntAbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.gbKontaktDaten);
            this.Controls.Add(this.gbKundeDaten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtLizenzFoto;
        private System.Windows.Forms.TextBox txtLizenzNummer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbGeschlecht;
        private System.Windows.Forms.Button btnLizenzDateiHochladen;
        private System.Windows.Forms.DateTimePicker dtpAblaufDatum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpAusstaltungsDatum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}