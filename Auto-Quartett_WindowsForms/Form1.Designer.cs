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
            this.btnVergleichen = new System.Windows.Forms.Button();
            this.lblAuswahlVergleichswert = new System.Windows.Forms.Label();
            this.lblGewonnenVerloren = new System.Windows.Forms.Label();
            this.btnNeu = new System.Windows.Forms.Button();
            this.PanelAuto1 = new System.Windows.Forms.Panel();
            this.btnLadevolumen = new System.Windows.Forms.Button();
            this.btnZuladung = new System.Windows.Forms.Button();
            this.btnBeschleunigung = new System.Windows.Forms.Button();
            this.btnHubraum = new System.Windows.Forms.Button();
            this.btnZylinder = new System.Windows.Forms.Button();
            this.btnVerbrauch = new System.Windows.Forms.Button();
            this.btnLeistung = new System.Windows.Forms.Button();
            this.btnGeschwindigkeit = new System.Windows.Forms.Button();
            this.PanelAuto2 = new System.Windows.Forms.Panel();
            this.PanelAuto1.SuspendLayout();
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
            this.lblAuswahlVergleichswert.Size = new System.Drawing.Size(322, 13);
            this.lblAuswahlVergleichswert.TabIndex = 5;
            this.lblAuswahlVergleichswert.Text = "Welchen Wert möchten Sie vergleichen? Klicken Sie auf die Zeile.";
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
            // PanelAuto1
            // 
            this.PanelAuto1.AutoSize = true;
            this.PanelAuto1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto1.Controls.Add(this.btnLadevolumen);
            this.PanelAuto1.Controls.Add(this.btnZuladung);
            this.PanelAuto1.Controls.Add(this.btnBeschleunigung);
            this.PanelAuto1.Controls.Add(this.btnHubraum);
            this.PanelAuto1.Controls.Add(this.btnZylinder);
            this.PanelAuto1.Controls.Add(this.btnVerbrauch);
            this.PanelAuto1.Controls.Add(this.btnLeistung);
            this.PanelAuto1.Controls.Add(this.btnGeschwindigkeit);
            this.PanelAuto1.Location = new System.Drawing.Point(15, 97);
            this.PanelAuto1.Name = "PanelAuto1";
            this.PanelAuto1.Size = new System.Drawing.Size(223, 385);
            this.PanelAuto1.TabIndex = 17;
            // 
            // btnLadevolumen
            // 
            this.btnLadevolumen.BackColor = System.Drawing.Color.Transparent;
            this.btnLadevolumen.FlatAppearance.BorderSize = 0;
            this.btnLadevolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLadevolumen.Location = new System.Drawing.Point(3, 348);
            this.btnLadevolumen.Name = "btnLadevolumen";
            this.btnLadevolumen.Size = new System.Drawing.Size(202, 23);
            this.btnLadevolumen.TabIndex = 42;
            this.btnLadevolumen.Text = "7";
            this.btnLadevolumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLadevolumen.UseVisualStyleBackColor = false;
            this.btnLadevolumen.Visible = false;
            this.btnLadevolumen.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnZuladung
            // 
            this.btnZuladung.BackColor = System.Drawing.Color.Transparent;
            this.btnZuladung.FlatAppearance.BorderSize = 0;
            this.btnZuladung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZuladung.Location = new System.Drawing.Point(3, 324);
            this.btnZuladung.Name = "btnZuladung";
            this.btnZuladung.Size = new System.Drawing.Size(202, 23);
            this.btnZuladung.TabIndex = 41;
            this.btnZuladung.Text = "6";
            this.btnZuladung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZuladung.UseVisualStyleBackColor = false;
            this.btnZuladung.Visible = false;
            this.btnZuladung.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBeschleunigung
            // 
            this.btnBeschleunigung.BackColor = System.Drawing.Color.Transparent;
            this.btnBeschleunigung.FlatAppearance.BorderSize = 0;
            this.btnBeschleunigung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeschleunigung.Location = new System.Drawing.Point(3, 300);
            this.btnBeschleunigung.Name = "btnBeschleunigung";
            this.btnBeschleunigung.Size = new System.Drawing.Size(202, 23);
            this.btnBeschleunigung.TabIndex = 40;
            this.btnBeschleunigung.Text = "5";
            this.btnBeschleunigung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeschleunigung.UseVisualStyleBackColor = false;
            this.btnBeschleunigung.Visible = false;
            this.btnBeschleunigung.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnHubraum
            // 
            this.btnHubraum.BackColor = System.Drawing.Color.Transparent;
            this.btnHubraum.FlatAppearance.BorderSize = 0;
            this.btnHubraum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHubraum.Location = new System.Drawing.Point(3, 277);
            this.btnHubraum.Name = "btnHubraum";
            this.btnHubraum.Size = new System.Drawing.Size(202, 23);
            this.btnHubraum.TabIndex = 39;
            this.btnHubraum.Text = "4";
            this.btnHubraum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHubraum.UseVisualStyleBackColor = false;
            this.btnHubraum.Visible = false;
            this.btnHubraum.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnZylinder
            // 
            this.btnZylinder.BackColor = System.Drawing.Color.Transparent;
            this.btnZylinder.FlatAppearance.BorderSize = 0;
            this.btnZylinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZylinder.Location = new System.Drawing.Point(3, 250);
            this.btnZylinder.Name = "btnZylinder";
            this.btnZylinder.Size = new System.Drawing.Size(202, 23);
            this.btnZylinder.TabIndex = 38;
            this.btnZylinder.Text = "3";
            this.btnZylinder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZylinder.UseVisualStyleBackColor = false;
            this.btnZylinder.Visible = false;
            this.btnZylinder.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnVerbrauch
            // 
            this.btnVerbrauch.BackColor = System.Drawing.Color.Transparent;
            this.btnVerbrauch.FlatAppearance.BorderSize = 0;
            this.btnVerbrauch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerbrauch.Location = new System.Drawing.Point(3, 226);
            this.btnVerbrauch.Name = "btnVerbrauch";
            this.btnVerbrauch.Size = new System.Drawing.Size(202, 23);
            this.btnVerbrauch.TabIndex = 37;
            this.btnVerbrauch.Text = "2";
            this.btnVerbrauch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerbrauch.UseVisualStyleBackColor = false;
            this.btnVerbrauch.Visible = false;
            this.btnVerbrauch.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLeistung
            // 
            this.btnLeistung.BackColor = System.Drawing.Color.Transparent;
            this.btnLeistung.FlatAppearance.BorderSize = 0;
            this.btnLeistung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeistung.Location = new System.Drawing.Point(3, 200);
            this.btnLeistung.Name = "btnLeistung";
            this.btnLeistung.Size = new System.Drawing.Size(202, 23);
            this.btnLeistung.TabIndex = 36;
            this.btnLeistung.Text = "1";
            this.btnLeistung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeistung.UseVisualStyleBackColor = false;
            this.btnLeistung.Visible = false;
            this.btnLeistung.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGeschwindigkeit
            // 
            this.btnGeschwindigkeit.BackColor = System.Drawing.Color.Transparent;
            this.btnGeschwindigkeit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeschwindigkeit.FlatAppearance.BorderSize = 0;
            this.btnGeschwindigkeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeschwindigkeit.ForeColor = System.Drawing.Color.Black;
            this.btnGeschwindigkeit.Location = new System.Drawing.Point(3, 176);
            this.btnGeschwindigkeit.Name = "btnGeschwindigkeit";
            this.btnGeschwindigkeit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGeschwindigkeit.Size = new System.Drawing.Size(202, 23);
            this.btnGeschwindigkeit.TabIndex = 35;
            this.btnGeschwindigkeit.Text = "0";
            this.btnGeschwindigkeit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeschwindigkeit.UseVisualStyleBackColor = false;
            this.btnGeschwindigkeit.Click += new System.EventHandler(this.Button_Click);
            // 
            // PanelAuto2
            // 
            this.PanelAuto2.AutoSize = true;
            this.PanelAuto2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto2.Location = new System.Drawing.Point(266, 97);
            this.PanelAuto2.Name = "PanelAuto2";
            this.PanelAuto2.Size = new System.Drawing.Size(219, 385);
            this.PanelAuto2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 494);
            this.Controls.Add(this.PanelAuto2);
            this.Controls.Add(this.PanelAuto1);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.lblGewonnenVerloren);
            this.Controls.Add(this.lblAuswahlVergleichswert);
            this.Controls.Add(this.btnVergleichen);
            this.Controls.Add(this.lblEinzelnVgl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.PanelAuto1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEinzelnVgl;
        private System.Windows.Forms.Button btnVergleichen;
        private System.Windows.Forms.Label lblAuswahlVergleichswert;
        private System.Windows.Forms.Label lblGewonnenVerloren;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Panel PanelAuto1;
        private System.Windows.Forms.Panel PanelAuto2;
        public System.Windows.Forms.Button btnLadevolumen;
        public System.Windows.Forms.Button btnZuladung;
        public System.Windows.Forms.Button btnBeschleunigung;
        public System.Windows.Forms.Button btnHubraum;
        public System.Windows.Forms.Button btnZylinder;
        public System.Windows.Forms.Button btnVerbrauch;
        public System.Windows.Forms.Button btnLeistung;
        public System.Windows.Forms.Button btnGeschwindigkeit;
    }
}

