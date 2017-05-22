namespace Auto_Quartett_WindowsForms
{
    partial class Form1
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
            this.lblEinzelnVgl = new System.Windows.Forms.Label();
            this.btnEinzeln = new System.Windows.Forms.Button();
            this.btnVergleichen = new System.Windows.Forms.Button();
            this.lblAuswahlVergleichswert = new System.Windows.Forms.Label();
            this.lblGewonnenVerloren = new System.Windows.Forms.Label();
            this.btnNeu = new System.Windows.Forms.Button();
            this.cbAuswahlWert = new System.Windows.Forms.ComboBox();
            this.PanelAuto1 = new System.Windows.Forms.Panel();
            this.PanelAuto2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEinzelnVgl
            // 
            this.lblEinzelnVgl.AutoSize = true;
            this.lblEinzelnVgl.Location = new System.Drawing.Point(12, 14);
            this.lblEinzelnVgl.Name = "lblEinzelnVgl";
            this.lblEinzelnVgl.Size = new System.Drawing.Size(269, 13);
            this.lblEinzelnVgl.TabIndex = 2;
            this.lblEinzelnVgl.Text = "Möchten Sie Karten einzeln ansehen oder vergleichen?";
            // 
            // btnEinzeln
            // 
            this.btnEinzeln.Location = new System.Drawing.Point(282, 9);
            this.btnEinzeln.Name = "btnEinzeln";
            this.btnEinzeln.Size = new System.Drawing.Size(49, 23);
            this.btnEinzeln.TabIndex = 3;
            this.btnEinzeln.Text = "einzeln";
            this.btnEinzeln.UseVisualStyleBackColor = true;
            // 
            // btnVergleichen
            // 
            this.btnVergleichen.Location = new System.Drawing.Point(332, 9);
            this.btnVergleichen.Name = "btnVergleichen";
            this.btnVergleichen.Size = new System.Drawing.Size(70, 23);
            this.btnVergleichen.TabIndex = 4;
            this.btnVergleichen.Text = "vergleichen";
            this.btnVergleichen.UseVisualStyleBackColor = true;
            this.btnVergleichen.Click += new System.EventHandler(this.btnVergleichen_Click);
            // 
            // lblAuswahlVergleichswert
            // 
            this.lblAuswahlVergleichswert.AutoSize = true;
            this.lblAuswahlVergleichswert.Location = new System.Drawing.Point(12, 41);
            this.lblAuswahlVergleichswert.Name = "lblAuswahlVergleichswert";
            this.lblAuswahlVergleichswert.Size = new System.Drawing.Size(202, 13);
            this.lblAuswahlVergleichswert.TabIndex = 5;
            this.lblAuswahlVergleichswert.Text = "Welchen Wert möchten Sie vergleichen?";
            this.lblAuswahlVergleichswert.Visible = false;
            // 
            // lblGewonnenVerloren
            // 
            this.lblGewonnenVerloren.AutoSize = true;
            this.lblGewonnenVerloren.Location = new System.Drawing.Point(167, 67);
            this.lblGewonnenVerloren.Name = "lblGewonnenVerloren";
            this.lblGewonnenVerloren.Size = new System.Drawing.Size(103, 13);
            this.lblGewonnenVerloren.TabIndex = 14;
            this.lblGewonnenVerloren.Text = "Gewonnen/Verloren";
            this.lblGewonnenVerloren.Visible = false;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(413, 9);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(36, 23);
            this.btnNeu.TabIndex = 15;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // cbAuswahlWert
            // 
            this.cbAuswahlWert.AllowDrop = true;
            this.cbAuswahlWert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuswahlWert.FormattingEnabled = true;
            this.cbAuswahlWert.Items.AddRange(new object[] {
            "Geschwindigkeit",
            "Leistung",
            "Verbrauch",
            "Zylinder",
            "Hubraum",
            "Beschleunigung",
            "Zuladung",
            "Ladevolumen"});
            this.cbAuswahlWert.Location = new System.Drawing.Point(220, 38);
            this.cbAuswahlWert.Name = "cbAuswahlWert";
            this.cbAuswahlWert.Size = new System.Drawing.Size(104, 21);
            this.cbAuswahlWert.TabIndex = 16;
            this.cbAuswahlWert.Visible = false;
            this.cbAuswahlWert.SelectedIndexChanged += new System.EventHandler(this.cbAuswahl_Wert_SelectedIndexChanged);
            // 
            // PanelAuto1
            // 
            this.PanelAuto1.AutoSize = true;
            this.PanelAuto1.Location = new System.Drawing.Point(15, 97);
            this.PanelAuto1.Name = "PanelAuto1";
            this.PanelAuto1.Size = new System.Drawing.Size(199, 308);
            this.PanelAuto1.TabIndex = 17;
            // 
            // PanelAuto2
            // 
            this.PanelAuto2.AutoSize = true;
            this.PanelAuto2.Location = new System.Drawing.Point(241, 97);
            this.PanelAuto2.Name = "PanelAuto2";
            this.PanelAuto2.Size = new System.Drawing.Size(199, 308);
            this.PanelAuto2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 417);
            this.Controls.Add(this.PanelAuto2);
            this.Controls.Add(this.PanelAuto1);
            this.Controls.Add(this.cbAuswahlWert);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.lblGewonnenVerloren);
            this.Controls.Add(this.lblAuswahlVergleichswert);
            this.Controls.Add(this.btnVergleichen);
            this.Controls.Add(this.btnEinzeln);
            this.Controls.Add(this.lblEinzelnVgl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEinzelnVgl;
        private System.Windows.Forms.Button btnEinzeln;
        private System.Windows.Forms.Button btnVergleichen;
        private System.Windows.Forms.Label lblAuswahlVergleichswert;
        private System.Windows.Forms.Label lblGewonnenVerloren;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.ComboBox cbAuswahlWert;
        private System.Windows.Forms.Panel PanelAuto1;
        private System.Windows.Forms.Panel PanelAuto2;
    }
}

