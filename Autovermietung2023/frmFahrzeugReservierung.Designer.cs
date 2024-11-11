namespace Autovermietung2023
{
    partial class frmFahrzeugReservierung
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
            this.btnReservieren = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReservierungNummer = new System.Windows.Forms.TextBox();
            this.txtFahrzeugNummer = new System.Windows.Forms.TextBox();
            this.txtPreiProTag = new System.Windows.Forms.TextBox();
            this.dtpGueltigBis = new System.Windows.Forms.DateTimePicker();
            this.cbBezeichnung = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReservieren
            // 
            this.btnReservieren.BackColor = System.Drawing.Color.Teal;
            this.btnReservieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservieren.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservieren.Location = new System.Drawing.Point(246, 316);
            this.btnReservieren.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservieren.Name = "btnReservieren";
            this.btnReservieren.Size = new System.Drawing.Size(167, 39);
            this.btnReservieren.TabIndex = 1;
            this.btnReservieren.Text = "Reservieren";
            this.btnReservieren.UseVisualStyleBackColor = false;
            this.btnReservieren.Click += new System.EventHandler(this.btnReservieren_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.Teal;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbbrechen.Location = new System.Drawing.Point(432, 316);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(167, 39);
            this.btnAbbrechen.TabIndex = 2;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ReserierungNummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "FahrzeugNummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bezeichnung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "PreisProTag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "ReservierungsDatum:";
            // 
            // txtReservierungNummer
            // 
            this.txtReservierungNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservierungNummer.Location = new System.Drawing.Point(260, 28);
            this.txtReservierungNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservierungNummer.Name = "txtReservierungNummer";
            this.txtReservierungNummer.ReadOnly = true;
            this.txtReservierungNummer.Size = new System.Drawing.Size(340, 38);
            this.txtReservierungNummer.TabIndex = 9;
            // 
            // txtFahrzeugNummer
            // 
            this.txtFahrzeugNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrzeugNummer.Location = new System.Drawing.Point(260, 76);
            this.txtFahrzeugNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtFahrzeugNummer.Name = "txtFahrzeugNummer";
            this.txtFahrzeugNummer.ReadOnly = true;
            this.txtFahrzeugNummer.Size = new System.Drawing.Size(340, 38);
            this.txtFahrzeugNummer.TabIndex = 10;
            // 
            // txtPreiProTag
            // 
            this.txtPreiProTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreiProTag.Location = new System.Drawing.Point(260, 212);
            this.txtPreiProTag.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreiProTag.Name = "txtPreiProTag";
            this.txtPreiProTag.Size = new System.Drawing.Size(340, 38);
            this.txtPreiProTag.TabIndex = 13;
            // 
            // dtpGueltigBis
            // 
            this.dtpGueltigBis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGueltigBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGueltigBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGueltigBis.Location = new System.Drawing.Point(260, 257);
            this.dtpGueltigBis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGueltigBis.Name = "dtpGueltigBis";
            this.dtpGueltigBis.Size = new System.Drawing.Size(340, 38);
            this.dtpGueltigBis.TabIndex = 14;
            // 
            // cbBezeichnung
            // 
            this.cbBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBezeichnung.FormattingEnabled = true;
            this.cbBezeichnung.Location = new System.Drawing.Point(260, 164);
            this.cbBezeichnung.Margin = new System.Windows.Forms.Padding(4);
            this.cbBezeichnung.Name = "cbBezeichnung";
            this.cbBezeichnung.Size = new System.Drawing.Size(340, 39);
            this.cbBezeichnung.TabIndex = 15;
            this.cbBezeichnung.SelectedIndexChanged += new System.EventHandler(this.cbBezeichnung_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(260, 120);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(340, 39);
            this.cbType.TabIndex = 16;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // frmFahrzeugReservierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 380);
            this.ControlBox = false;
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbBezeichnung);
            this.Controls.Add(this.dtpGueltigBis);
            this.Controls.Add(this.txtPreiProTag);
            this.Controls.Add(this.txtFahrzeugNummer);
            this.Controls.Add(this.txtReservierungNummer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnReservieren);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFahrzeugReservierung";
            this.Text = "Fahrzeug-Reservierung";
            this.Load += new System.EventHandler(this.frmFahrzeugReservierung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReservieren;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReservierungNummer;
        private System.Windows.Forms.TextBox txtFahrzeugNummer;
        private System.Windows.Forms.TextBox txtPreiProTag;
        private System.Windows.Forms.DateTimePicker dtpGueltigBis;
        private System.Windows.Forms.ComboBox cbBezeichnung;
        private System.Windows.Forms.ComboBox cbType;
    }
}