namespace Autovermietung2023
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAbholUndRueckgabe = new System.Windows.Forms.ComboBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAbholdatum = new System.Windows.Forms.DateTimePicker();
            this.dtRückgabedatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAbholUhrzeit = new System.Windows.Forms.ComboBox();
            this.cbRückgabeUhezeit = new System.Windows.Forms.ComboBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abhol-&&Rückgabeort";
            // 
            // cbAbholUndRueckgabe
            // 
            this.cbAbholUndRueckgabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAbholUndRueckgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAbholUndRueckgabe.FormattingEnabled = true;
            this.cbAbholUndRueckgabe.Location = new System.Drawing.Point(18, 424);
            this.cbAbholUndRueckgabe.Name = "cbAbholUndRueckgabe";
            this.cbAbholUndRueckgabe.Size = new System.Drawing.Size(747, 46);
            this.cbAbholUndRueckgabe.TabIndex = 6;
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(41, 51);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(146, 55);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Autovermietung2023.Properties.Resources.pexels_negativespace_97079;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1522, 810);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Abholdatum";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rückgabedatum";
            // 
            // dtpAbholdatum
            // 
            this.dtpAbholdatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAbholdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAbholdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbholdatum.Location = new System.Drawing.Point(309, 497);
            this.dtpAbholdatum.Name = "dtpAbholdatum";
            this.dtpAbholdatum.Size = new System.Drawing.Size(456, 41);
            this.dtpAbholdatum.TabIndex = 10;
            // 
            // dtRückgabedatum
            // 
            this.dtRückgabedatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtRückgabedatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRückgabedatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRückgabedatum.Location = new System.Drawing.Point(309, 625);
            this.dtRückgabedatum.Name = "dtRückgabedatum";
            this.dtRückgabedatum.Size = new System.Drawing.Size(456, 41);
            this.dtRückgabedatum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Abhol-Uhrzeit";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rückgabe-Uhrzeit";
            // 
            // cbAbholUhrzeit
            // 
            this.cbAbholUhrzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAbholUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAbholUhrzeit.FormattingEnabled = true;
            this.cbAbholUhrzeit.Location = new System.Drawing.Point(309, 564);
            this.cbAbholUhrzeit.Name = "cbAbholUhrzeit";
            this.cbAbholUhrzeit.Size = new System.Drawing.Size(456, 39);
            this.cbAbholUhrzeit.TabIndex = 15;
            // 
            // cbRückgabeUhezeit
            // 
            this.cbRückgabeUhezeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRückgabeUhezeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRückgabeUhezeit.FormattingEnabled = true;
            this.cbRückgabeUhezeit.Location = new System.Drawing.Point(309, 695);
            this.cbRückgabeUhezeit.Name = "cbRückgabeUhezeit";
            this.cbRückgabeUhezeit.Size = new System.Drawing.Size(456, 39);
            this.cbRückgabeUhezeit.TabIndex = 16;
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.Yellow;
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuchen.Location = new System.Drawing.Point(309, 752);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(456, 58);
            this.btnSuchen.TabIndex = 17;
            this.btnSuchen.Text = "Suche";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 810);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.cbRückgabeUhezeit);
            this.Controls.Add(this.cbAbholUhrzeit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtRückgabedatum);
            this.Controls.Add(this.dtpAbholdatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAbholUndRueckgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAbholUndRueckgabe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAbholdatum;
        private System.Windows.Forms.DateTimePicker dtRückgabedatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAbholUhrzeit;
        private System.Windows.Forms.ComboBox cbRückgabeUhezeit;
        private System.Windows.Forms.Button btnSuchen;
    }
}