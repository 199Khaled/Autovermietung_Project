namespace Autovermietung2023
{
    partial class frmLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.llbPasswortVergessen = new System.Windows.Forms.LinkLabel();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.btnKontoErstellen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.lblFehlerText = new System.Windows.Forms.Label();
            this.cbErennereMich = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Benutzerkonto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ihre Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passwort";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 162);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(696, 58);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(96, 270);
            this.txtPasswort.Multiline = true;
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(696, 58);
            this.txtPasswort.TabIndex = 4;
            // 
            // llbPasswortVergessen
            // 
            this.llbPasswortVergessen.AutoSize = true;
            this.llbPasswortVergessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPasswortVergessen.Location = new System.Drawing.Point(101, 390);
            this.llbPasswortVergessen.Name = "llbPasswortVergessen";
            this.llbPasswortVergessen.Size = new System.Drawing.Size(188, 25);
            this.llbPasswortVergessen.TabIndex = 6;
            this.llbPasswortVergessen.TabStop = true;
            this.llbPasswortVergessen.Text = "Passwort vergessen";
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinloggen.ForeColor = System.Drawing.Color.Green;
            this.btnEinloggen.Location = new System.Drawing.Point(96, 493);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(696, 64);
            this.btnEinloggen.TabIndex = 7;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = true;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // btnKontoErstellen
            // 
            this.btnKontoErstellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontoErstellen.ForeColor = System.Drawing.Color.Green;
            this.btnKontoErstellen.Location = new System.Drawing.Point(96, 588);
            this.btnKontoErstellen.Name = "btnKontoErstellen";
            this.btnKontoErstellen.Size = new System.Drawing.Size(696, 64);
            this.btnKontoErstellen.TabIndex = 8;
            this.btnKontoErstellen.Text = "Regestrieren";
            this.btnKontoErstellen.UseVisualStyleBackColor = true;
            this.btnKontoErstellen.Click += new System.EventHandler(this.btnKontoErstellen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Image = global::Autovermietung2023.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(829, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 85);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.FlatAppearance.BorderSize = 0;
            this.btnAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnzeigen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAnzeigen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnzeigen.Location = new System.Drawing.Point(682, 270);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(110, 58);
            this.btnAnzeigen.TabIndex = 5;
            this.btnAnzeigen.Text = "ANZEIGEN";
            this.btnAnzeigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // lblFehlerText
            // 
            this.lblFehlerText.AutoSize = true;
            this.lblFehlerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFehlerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFehlerText.Location = new System.Drawing.Point(101, 427);
            this.lblFehlerText.Name = "lblFehlerText";
            this.lblFehlerText.Size = new System.Drawing.Size(23, 25);
            this.lblFehlerText.TabIndex = 10;
            this.lblFehlerText.Text = "#";
            this.lblFehlerText.Visible = false;
            // 
            // cbErennereMich
            // 
            this.cbErennereMich.AutoSize = true;
            this.cbErennereMich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbErennereMich.Location = new System.Drawing.Point(96, 343);
            this.cbErennereMich.Name = "cbErennereMich";
            this.cbErennereMich.Size = new System.Drawing.Size(166, 29);
            this.cbErennereMich.TabIndex = 11;
            this.cbErennereMich.Text = "Erennerer mich";
            this.cbErennereMich.UseVisualStyleBackColor = true;
            this.cbErennereMich.CheckedChanged += new System.EventHandler(this.cbErennereMich_CheckedChanged);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 676);
            this.ControlBox = false;
            this.Controls.Add(this.cbErennereMich);
            this.Controls.Add(this.lblFehlerText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKontoErstellen);
            this.Controls.Add(this.btnEinloggen);
            this.Controls.Add(this.llbPasswortVergessen);
            this.Controls.Add(this.btnAnzeigen);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoginForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoginForm_FormClosed);
            this.Load += new System.EventHandler(this.frmLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.LinkLabel llbPasswortVergessen;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Button btnKontoErstellen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFehlerText;
        private System.Windows.Forms.CheckBox cbErennereMich;
    }
}