namespace Autovermietung2023
{
    partial class frmFahrzeugFilter
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
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.gbFahrzeugFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.gbFahrzeugFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "bezeichnung",
            "typ"});
            this.cbFilterbei.Location = new System.Drawing.Point(136, 76);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(298, 37);
            this.cbFilterbei.TabIndex = 0;
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(440, 75);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(528, 38);
            this.txtFilterWert.TabIndex = 1;
            // 
            // btnSuche
            // 
            this.btnSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuche.Location = new System.Drawing.Point(455, 188);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(248, 41);
            this.btnSuche.TabIndex = 2;
            this.btnSuche.Text = "Suche";
            this.btnSuche.UseVisualStyleBackColor = true;
       
            // 
            // gbFahrzeugFilter
            // 
            this.gbFahrzeugFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbFahrzeugFilter.Controls.Add(this.cbFilterbei);
            this.gbFahrzeugFilter.Controls.Add(this.label1);
            this.gbFahrzeugFilter.Controls.Add(this.txtFilterWert);
            this.gbFahrzeugFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFahrzeugFilter.Location = new System.Drawing.Point(15, 29);
            this.gbFahrzeugFilter.Name = "gbFahrzeugFilter";
            this.gbFahrzeugFilter.Size = new System.Drawing.Size(974, 153);
            this.gbFahrzeugFilter.TabIndex = 3;
            this.gbFahrzeugFilter.TabStop = false;
            this.gbFahrzeugFilter.Text = "Fharzeug Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter bei:";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(735, 188);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(248, 41);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // frmFahrzeugFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1001, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.gbFahrzeugFilter);
            this.Controls.Add(this.btnSuche);
            this.Name = "frmFahrzeugFilter";
            this.Text = "Fahrzeug-filter";
            this.Load += new System.EventHandler(this.frmFahrzeugFilter_Load);
            this.gbFahrzeugFilter.ResumeLayout(false);
            this.gbFahrzeugFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.GroupBox gbFahrzeugFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}