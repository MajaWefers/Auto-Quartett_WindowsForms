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
            this.lblAuswahlVergleichswert = new System.Windows.Forms.Label();
            this.lblGewonnenVerloren = new System.Windows.Forms.Label();
            this.btnNeu = new System.Windows.Forms.Button();
            this.PanelAuto1 = new System.Windows.Forms.Panel();
            this.PanelAuto2 = new System.Windows.Forms.Panel();
            this.btnGeschwindigkeit = new System.Windows.Forms.Button();
            this.btnLeistung = new System.Windows.Forms.Button();
            this.btnVerbrauch = new System.Windows.Forms.Button();
            this.btnZylinder = new System.Windows.Forms.Button();
            this.btnHubraum = new System.Windows.Forms.Button();
            this.btnBeschleunigung = new System.Windows.Forms.Button();
            this.btnLadevolumen = new System.Windows.Forms.Button();
            this.btnZuladung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuswahlVergleichswert
            // 
            this.lblAuswahlVergleichswert.AutoSize = true;
            this.lblAuswahlVergleichswert.Location = new System.Drawing.Point(12, 19);
            this.lblAuswahlVergleichswert.Name = "lblAuswahlVergleichswert";
            this.lblAuswahlVergleichswert.Size = new System.Drawing.Size(322, 13);
            this.lblAuswahlVergleichswert.TabIndex = 5;
            this.lblAuswahlVergleichswert.Text = "Welchen Wert möchten Sie vergleichen? Klicken Sie auf die Zeile.";
            // 
            // lblGewonnenVerloren
            // 
            this.lblGewonnenVerloren.AutoSize = true;
            this.lblGewonnenVerloren.Location = new System.Drawing.Point(195, 48);
            this.lblGewonnenVerloren.Name = "lblGewonnenVerloren";
            this.lblGewonnenVerloren.Size = new System.Drawing.Size(103, 13);
            this.lblGewonnenVerloren.TabIndex = 14;
            this.lblGewonnenVerloren.Text = "Gewonnen/Verloren";
            this.lblGewonnenVerloren.Visible = false;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(356, 14);
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
            this.PanelAuto1.Location = new System.Drawing.Point(42, 64);
            this.PanelAuto1.Name = "PanelAuto1";
            this.PanelAuto1.Size = new System.Drawing.Size(223, 385);
            this.PanelAuto1.TabIndex = 17;
            // 
            // PanelAuto2
            // 
            this.PanelAuto2.AutoSize = true;
            this.PanelAuto2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto2.Location = new System.Drawing.Point(293, 64);
            this.PanelAuto2.Name = "PanelAuto2";
            this.PanelAuto2.Size = new System.Drawing.Size(219, 385);
            this.PanelAuto2.TabIndex = 18;
            // 
            // btnGeschwindigkeit
            // 
            this.btnGeschwindigkeit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGeschwindigkeit.Location = new System.Drawing.Point(12, 249);
            this.btnGeschwindigkeit.Name = "btnGeschwindigkeit";
            this.btnGeschwindigkeit.Size = new System.Drawing.Size(24, 23);
            this.btnGeschwindigkeit.TabIndex = 19;
            this.btnGeschwindigkeit.UseVisualStyleBackColor = true;
            this.btnGeschwindigkeit.Click += new System.EventHandler(this.btnGeschwindigkeit_Click);
            // 
            // btnLeistung
            // 
            this.btnLeistung.Location = new System.Drawing.Point(12, 272);
            this.btnLeistung.Name = "btnLeistung";
            this.btnLeistung.Size = new System.Drawing.Size(24, 23);
            this.btnLeistung.TabIndex = 20;
            this.btnLeistung.UseVisualStyleBackColor = true;
            this.btnLeistung.Click += new System.EventHandler(this.btnLeistung_Click);
            // 
            // btnVerbrauch
            // 
            this.btnVerbrauch.Location = new System.Drawing.Point(12, 295);
            this.btnVerbrauch.Name = "btnVerbrauch";
            this.btnVerbrauch.Size = new System.Drawing.Size(24, 23);
            this.btnVerbrauch.TabIndex = 21;
            this.btnVerbrauch.UseVisualStyleBackColor = true;
            this.btnVerbrauch.Click += new System.EventHandler(this.btnVerbrauch_Click);
            // 
            // btnZylinder
            // 
            this.btnZylinder.Location = new System.Drawing.Point(12, 318);
            this.btnZylinder.Name = "btnZylinder";
            this.btnZylinder.Size = new System.Drawing.Size(24, 23);
            this.btnZylinder.TabIndex = 22;
            this.btnZylinder.UseVisualStyleBackColor = true;
            this.btnZylinder.Click += new System.EventHandler(this.btnZylinder_Click);
            // 
            // btnHubraum
            // 
            this.btnHubraum.Location = new System.Drawing.Point(12, 341);
            this.btnHubraum.Name = "btnHubraum";
            this.btnHubraum.Size = new System.Drawing.Size(24, 23);
            this.btnHubraum.TabIndex = 44;
            this.btnHubraum.UseVisualStyleBackColor = true;
            this.btnHubraum.Click += new System.EventHandler(this.btnHubraum_Click);
            // 
            // btnBeschleunigung
            // 
            this.btnBeschleunigung.Location = new System.Drawing.Point(12, 364);
            this.btnBeschleunigung.Name = "btnBeschleunigung";
            this.btnBeschleunigung.Size = new System.Drawing.Size(24, 23);
            this.btnBeschleunigung.TabIndex = 45;
            this.btnBeschleunigung.UseVisualStyleBackColor = true;
            this.btnBeschleunigung.Click += new System.EventHandler(this.btnBeschleunigung_Click);
            // 
            // btnLadevolumen
            // 
            this.btnLadevolumen.Location = new System.Drawing.Point(12, 410);
            this.btnLadevolumen.Name = "btnLadevolumen";
            this.btnLadevolumen.Size = new System.Drawing.Size(24, 23);
            this.btnLadevolumen.TabIndex = 46;
            this.btnLadevolumen.UseVisualStyleBackColor = true;
            this.btnLadevolumen.Click += new System.EventHandler(this.btnLadevolumen_Click);
            // 
            // btnZuladung
            // 
            this.btnZuladung.Location = new System.Drawing.Point(12, 387);
            this.btnZuladung.Name = "btnZuladung";
            this.btnZuladung.Size = new System.Drawing.Size(24, 23);
            this.btnZuladung.TabIndex = 47;
            this.btnZuladung.UseVisualStyleBackColor = true;
            this.btnZuladung.Click += new System.EventHandler(this.btnZuladung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 494);
            this.Controls.Add(this.btnZuladung);
            this.Controls.Add(this.btnLadevolumen);
            this.Controls.Add(this.btnBeschleunigung);
            this.Controls.Add(this.btnHubraum);
            this.Controls.Add(this.btnZylinder);
            this.Controls.Add(this.btnVerbrauch);
            this.Controls.Add(this.btnLeistung);
            this.Controls.Add(this.btnGeschwindigkeit);
            this.Controls.Add(this.PanelAuto2);
            this.Controls.Add(this.PanelAuto1);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.lblGewonnenVerloren);
            this.Controls.Add(this.lblAuswahlVergleichswert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAuswahlVergleichswert;
        private System.Windows.Forms.Label lblGewonnenVerloren;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Panel PanelAuto1;
        private System.Windows.Forms.Panel PanelAuto2;
        private System.Windows.Forms.Button btnGeschwindigkeit;
        private System.Windows.Forms.Button btnLeistung;
        private System.Windows.Forms.Button btnVerbrauch;
        private System.Windows.Forms.Button btnZylinder;
        private System.Windows.Forms.Button btnHubraum;
        private System.Windows.Forms.Button btnBeschleunigung;
        private System.Windows.Forms.Button btnLadevolumen;
        private System.Windows.Forms.Button btnZuladung;
    }
}

