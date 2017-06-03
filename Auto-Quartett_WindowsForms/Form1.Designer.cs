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
            this.lblSpielerpunkte = new System.Windows.Forms.Label();
            this.lblGegnerpunkte = new System.Windows.Forms.Label();
            this.lblDoppelpunkt = new System.Windows.Forms.Label();
            this.lblVergleich = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuswahlVergleichswert
            // 
            this.lblAuswahlVergleichswert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuswahlVergleichswert.BackColor = System.Drawing.Color.White;
            this.lblAuswahlVergleichswert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuswahlVergleichswert.Location = new System.Drawing.Point(115, 14);
            this.lblAuswahlVergleichswert.Name = "lblAuswahlVergleichswert";
            this.lblAuswahlVergleichswert.Size = new System.Drawing.Size(116, 23);
            this.lblAuswahlVergleichswert.TabIndex = 5;
            this.lblAuswahlVergleichswert.Text = "Ihre Spielkarte";
            this.lblAuswahlVergleichswert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNeu
            // 
            this.btnNeu.Enabled = false;
            this.btnNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeu.Location = new System.Drawing.Point(363, 199);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(68, 47);
            this.btnNeu.TabIndex = 15;
            this.btnNeu.Text = "Nächste Karte";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // PanelAuto1
            // 
            this.PanelAuto1.AutoSize = true;
            this.PanelAuto1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto1.Location = new System.Drawing.Point(21, 44);
            this.PanelAuto1.Name = "PanelAuto1";
            this.PanelAuto1.Size = new System.Drawing.Size(293, 461);
            this.PanelAuto1.TabIndex = 17;
            // 
            // PanelAuto2
            // 
            this.PanelAuto2.AutoSize = true;
            this.PanelAuto2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto2.Location = new System.Drawing.Point(477, 44);
            this.PanelAuto2.Name = "PanelAuto2";
            this.PanelAuto2.Size = new System.Drawing.Size(293, 461);
            this.PanelAuto2.TabIndex = 18;
            // 
            // btnGeschwindigkeit
            // 
            this.btnGeschwindigkeit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGeschwindigkeit.Location = new System.Drawing.Point(383, 297);
            this.btnGeschwindigkeit.Name = "btnGeschwindigkeit";
            this.btnGeschwindigkeit.Size = new System.Drawing.Size(24, 23);
            this.btnGeschwindigkeit.TabIndex = 1;
            this.btnGeschwindigkeit.UseVisualStyleBackColor = true;
            this.btnGeschwindigkeit.Click += new System.EventHandler(this.btnGeschwindigkeit_Click);
            // 
            // btnLeistung
            // 
            this.btnLeistung.Location = new System.Drawing.Point(383, 320);
            this.btnLeistung.Name = "btnLeistung";
            this.btnLeistung.Size = new System.Drawing.Size(24, 23);
            this.btnLeistung.TabIndex = 2;
            this.btnLeistung.UseVisualStyleBackColor = true;
            this.btnLeistung.Click += new System.EventHandler(this.btnLeistung_Click);
            // 
            // btnVerbrauch
            // 
            this.btnVerbrauch.Location = new System.Drawing.Point(383, 343);
            this.btnVerbrauch.Name = "btnVerbrauch";
            this.btnVerbrauch.Size = new System.Drawing.Size(24, 23);
            this.btnVerbrauch.TabIndex = 3;
            this.btnVerbrauch.UseVisualStyleBackColor = true;
            this.btnVerbrauch.Click += new System.EventHandler(this.btnVerbrauch_Click);
            // 
            // btnZylinder
            // 
            this.btnZylinder.Location = new System.Drawing.Point(383, 366);
            this.btnZylinder.Name = "btnZylinder";
            this.btnZylinder.Size = new System.Drawing.Size(24, 23);
            this.btnZylinder.TabIndex = 4;
            this.btnZylinder.UseVisualStyleBackColor = true;
            this.btnZylinder.Click += new System.EventHandler(this.btnZylinder_Click);
            // 
            // btnHubraum
            // 
            this.btnHubraum.Location = new System.Drawing.Point(383, 389);
            this.btnHubraum.Name = "btnHubraum";
            this.btnHubraum.Size = new System.Drawing.Size(24, 23);
            this.btnHubraum.TabIndex = 5;
            this.btnHubraum.UseVisualStyleBackColor = true;
            this.btnHubraum.Click += new System.EventHandler(this.btnHubraum_Click);
            // 
            // btnBeschleunigung
            // 
            this.btnBeschleunigung.Location = new System.Drawing.Point(383, 412);
            this.btnBeschleunigung.Name = "btnBeschleunigung";
            this.btnBeschleunigung.Size = new System.Drawing.Size(24, 23);
            this.btnBeschleunigung.TabIndex = 6;
            this.btnBeschleunigung.UseVisualStyleBackColor = true;
            this.btnBeschleunigung.Click += new System.EventHandler(this.btnBeschleunigung_Click);
            // 
            // btnLadevolumen
            // 
            this.btnLadevolumen.Location = new System.Drawing.Point(383, 458);
            this.btnLadevolumen.Name = "btnLadevolumen";
            this.btnLadevolumen.Size = new System.Drawing.Size(24, 23);
            this.btnLadevolumen.TabIndex = 8;
            this.btnLadevolumen.UseVisualStyleBackColor = true;
            this.btnLadevolumen.Click += new System.EventHandler(this.btnLadevolumen_Click);
            // 
            // btnZuladung
            // 
            this.btnZuladung.Location = new System.Drawing.Point(383, 435);
            this.btnZuladung.Name = "btnZuladung";
            this.btnZuladung.Size = new System.Drawing.Size(24, 23);
            this.btnZuladung.TabIndex = 7;
            this.btnZuladung.UseVisualStyleBackColor = true;
            this.btnZuladung.Click += new System.EventHandler(this.btnZuladung_Click);
            // 
            // lblSpielerpunkte
            // 
            this.lblSpielerpunkte.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielerpunkte.Location = new System.Drawing.Point(323, 134);
            this.lblSpielerpunkte.Name = "lblSpielerpunkte";
            this.lblSpielerpunkte.Size = new System.Drawing.Size(73, 51);
            this.lblSpielerpunkte.TabIndex = 19;
            this.lblSpielerpunkte.Text = "0";
            this.lblSpielerpunkte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGegnerpunkte
            // 
            this.lblGegnerpunkte.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGegnerpunkte.Location = new System.Drawing.Point(404, 134);
            this.lblGegnerpunkte.Name = "lblGegnerpunkte";
            this.lblGegnerpunkte.Size = new System.Drawing.Size(67, 51);
            this.lblGegnerpunkte.TabIndex = 20;
            this.lblGegnerpunkte.Text = "0";
            this.lblGegnerpunkte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoppelpunkt
            // 
            this.lblDoppelpunkt.AutoSize = true;
            this.lblDoppelpunkt.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoppelpunkt.Location = new System.Drawing.Point(385, 133);
            this.lblDoppelpunkt.Name = "lblDoppelpunkt";
            this.lblDoppelpunkt.Size = new System.Drawing.Size(37, 49);
            this.lblDoppelpunkt.TabIndex = 21;
            this.lblDoppelpunkt.Text = ":";
            // 
            // lblVergleich
            // 
            this.lblVergleich.AutoSize = true;
            this.lblVergleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVergleich.Location = new System.Drawing.Point(359, 265);
            this.lblVergleich.Name = "lblVergleich";
            this.lblVergleich.Size = new System.Drawing.Size(79, 20);
            this.lblVergleich.TabIndex = 22;
            this.lblVergleich.Text = "Vergleich:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gegnerspielkarte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVergleich);
            this.Controls.Add(this.lblGegnerpunkte);
            this.Controls.Add(this.lblSpielerpunkte);
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
            this.Controls.Add(this.lblAuswahlVergleichswert);
            this.Controls.Add(this.lblDoppelpunkt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAuswahlVergleichswert;
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
        private System.Windows.Forms.Label lblSpielerpunkte;
        private System.Windows.Forms.Label lblGegnerpunkte;
        private System.Windows.Forms.Label lblDoppelpunkt;
        private System.Windows.Forms.Label lblVergleich;
        private System.Windows.Forms.Label label1;
    }
}

