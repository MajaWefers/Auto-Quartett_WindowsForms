﻿namespace Auto_Quartett_WindowsForms
{
    partial class Spiel
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
            this.btnNaechsteKarte = new System.Windows.Forms.Button();
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
            this.btnEinfach = new System.Windows.Forms.Button();
            this.btnSchwer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuswahlVergleichswert
            // 
            this.lblAuswahlVergleichswert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuswahlVergleichswert.BackColor = System.Drawing.Color.White;
            this.lblAuswahlVergleichswert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuswahlVergleichswert.Location = new System.Drawing.Point(115, 14);
            this.lblAuswahlVergleichswert.Name = "lblAuswahlVergleichswert";
            this.lblAuswahlVergleichswert.Size = new System.Drawing.Size(116, 23);
            this.lblAuswahlVergleichswert.TabIndex = 5;
            this.lblAuswahlVergleichswert.Text = "Ihre Spielkarte";
            this.lblAuswahlVergleichswert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNaechsteKarte
            // 
            this.btnNaechsteKarte.Enabled = false;
            this.btnNaechsteKarte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaechsteKarte.Location = new System.Drawing.Point(363, 189);
            this.btnNaechsteKarte.Name = "btnNaechsteKarte";
            this.btnNaechsteKarte.Size = new System.Drawing.Size(68, 47);
            this.btnNaechsteKarte.TabIndex = 15;
            this.btnNaechsteKarte.Text = "Nächste Karte";
            this.btnNaechsteKarte.UseVisualStyleBackColor = true;
            this.btnNaechsteKarte.Click += new System.EventHandler(this.btnNaechsteKarte_Click);
            // 
            // PanelAuto1
            // 
            this.PanelAuto1.AutoSize = true;
            this.PanelAuto1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto1.Location = new System.Drawing.Point(21, 44);
            this.PanelAuto1.Name = "PanelAuto1";
            this.PanelAuto1.Size = new System.Drawing.Size(300, 461);
            this.PanelAuto1.TabIndex = 17;
            // 
            // PanelAuto2
            // 
            this.PanelAuto2.AutoSize = true;
            this.PanelAuto2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAuto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PanelAuto2.Location = new System.Drawing.Point(477, 44);
            this.PanelAuto2.Name = "PanelAuto2";
            this.PanelAuto2.Size = new System.Drawing.Size(293, 461);
            this.PanelAuto2.TabIndex = 18;
            // 
            // btnGeschwindigkeit
            // 
            this.btnGeschwindigkeit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeschwindigkeit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGeschwindigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeschwindigkeit.Location = new System.Drawing.Point(383, 297);
            this.btnGeschwindigkeit.Name = "btnGeschwindigkeit";
            this.btnGeschwindigkeit.Size = new System.Drawing.Size(24, 23);
            this.btnGeschwindigkeit.TabIndex = 1;
            this.btnGeschwindigkeit.Text = "↑";
            this.btnGeschwindigkeit.UseVisualStyleBackColor = true;
            this.btnGeschwindigkeit.Click += new System.EventHandler(this.btnGeschwindigkeit_Click);
            // 
            // btnLeistung
            // 
            this.btnLeistung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeistung.Location = new System.Drawing.Point(383, 320);
            this.btnLeistung.Name = "btnLeistung";
            this.btnLeistung.Size = new System.Drawing.Size(24, 23);
            this.btnLeistung.TabIndex = 2;
            this.btnLeistung.Text = "↑";
            this.btnLeistung.UseVisualStyleBackColor = true;
            this.btnLeistung.Click += new System.EventHandler(this.btnLeistung_Click);
            // 
            // btnVerbrauch
            // 
            this.btnVerbrauch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerbrauch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbrauch.Location = new System.Drawing.Point(383, 343);
            this.btnVerbrauch.Name = "btnVerbrauch";
            this.btnVerbrauch.Size = new System.Drawing.Size(24, 23);
            this.btnVerbrauch.TabIndex = 3;
            this.btnVerbrauch.Text = "↓";
            this.btnVerbrauch.UseVisualStyleBackColor = true;
            this.btnVerbrauch.Click += new System.EventHandler(this.btnVerbrauch_Click);
            // 
            // btnZylinder
            // 
            this.btnZylinder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZylinder.Location = new System.Drawing.Point(383, 366);
            this.btnZylinder.Name = "btnZylinder";
            this.btnZylinder.Size = new System.Drawing.Size(24, 23);
            this.btnZylinder.TabIndex = 4;
            this.btnZylinder.Text = "↑";
            this.btnZylinder.UseVisualStyleBackColor = true;
            this.btnZylinder.Click += new System.EventHandler(this.btnZylinder_Click);
            // 
            // btnHubraum
            // 
            this.btnHubraum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHubraum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHubraum.Location = new System.Drawing.Point(383, 389);
            this.btnHubraum.Name = "btnHubraum";
            this.btnHubraum.Size = new System.Drawing.Size(24, 23);
            this.btnHubraum.TabIndex = 5;
            this.btnHubraum.Text = "↑";
            this.btnHubraum.UseVisualStyleBackColor = true;
            this.btnHubraum.Click += new System.EventHandler(this.btnHubraum_Click);
            // 
            // btnBeschleunigung
            // 
            this.btnBeschleunigung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBeschleunigung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeschleunigung.Location = new System.Drawing.Point(383, 412);
            this.btnBeschleunigung.Name = "btnBeschleunigung";
            this.btnBeschleunigung.Size = new System.Drawing.Size(24, 23);
            this.btnBeschleunigung.TabIndex = 6;
            this.btnBeschleunigung.Text = "↓";
            this.btnBeschleunigung.UseVisualStyleBackColor = true;
            this.btnBeschleunigung.Click += new System.EventHandler(this.btnBeschleunigung_Click);
            // 
            // btnLadevolumen
            // 
            this.btnLadevolumen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLadevolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadevolumen.Location = new System.Drawing.Point(383, 458);
            this.btnLadevolumen.Name = "btnLadevolumen";
            this.btnLadevolumen.Size = new System.Drawing.Size(24, 23);
            this.btnLadevolumen.TabIndex = 8;
            this.btnLadevolumen.Text = "↑";
            this.btnLadevolumen.UseVisualStyleBackColor = true;
            this.btnLadevolumen.Click += new System.EventHandler(this.btnLadevolumen_Click);
            // 
            // btnZuladung
            // 
            this.btnZuladung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZuladung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZuladung.Location = new System.Drawing.Point(383, 435);
            this.btnZuladung.Name = "btnZuladung";
            this.btnZuladung.Size = new System.Drawing.Size(24, 23);
            this.btnZuladung.TabIndex = 7;
            this.btnZuladung.Text = "↑";
            this.btnZuladung.UseVisualStyleBackColor = true;
            this.btnZuladung.Click += new System.EventHandler(this.btnZuladung_Click);
            // 
            // lblSpielerpunkte
            // 
            this.lblSpielerpunkte.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielerpunkte.Location = new System.Drawing.Point(323, 124);
            this.lblSpielerpunkte.Name = "lblSpielerpunkte";
            this.lblSpielerpunkte.Size = new System.Drawing.Size(73, 51);
            this.lblSpielerpunkte.TabIndex = 19;
            this.lblSpielerpunkte.Text = "0";
            this.lblSpielerpunkte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGegnerpunkte
            // 
            this.lblGegnerpunkte.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGegnerpunkte.Location = new System.Drawing.Point(404, 124);
            this.lblGegnerpunkte.Name = "lblGegnerpunkte";
            this.lblGegnerpunkte.Size = new System.Drawing.Size(67, 51);
            this.lblGegnerpunkte.TabIndex = 20;
            this.lblGegnerpunkte.Text = "0";
            this.lblGegnerpunkte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoppelpunkt
            // 
            this.lblDoppelpunkt.AutoSize = true;
            this.lblDoppelpunkt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoppelpunkt.Location = new System.Drawing.Point(385, 123);
            this.lblDoppelpunkt.Name = "lblDoppelpunkt";
            this.lblDoppelpunkt.Size = new System.Drawing.Size(32, 54);
            this.lblDoppelpunkt.TabIndex = 21;
            this.lblDoppelpunkt.Text = ":";
            // 
            // lblVergleich
            // 
            this.lblVergleich.AutoSize = true;
            this.lblVergleich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVergleich.Location = new System.Drawing.Point(359, 255);
            this.lblVergleich.Name = "lblVergleich";
            this.lblVergleich.Size = new System.Drawing.Size(78, 21);
            this.lblVergleich.TabIndex = 22;
            this.lblVergleich.Text = "Vergleich:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gegnerspielkarte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEinfach
            // 
            this.btnEinfach.BackColor = System.Drawing.Color.Lime;
            this.btnEinfach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinfach.Location = new System.Drawing.Point(324, 48);
            this.btnEinfach.Name = "btnEinfach";
            this.btnEinfach.Size = new System.Drawing.Size(76, 23);
            this.btnEinfach.TabIndex = 24;
            this.btnEinfach.Text = "Einfach";
            this.btnEinfach.UseVisualStyleBackColor = false;
            this.btnEinfach.Click += new System.EventHandler(this.btnEinfach_Click);
            // 
            // btnSchwer
            // 
            this.btnSchwer.BackColor = System.Drawing.Color.Red;
            this.btnSchwer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchwer.Location = new System.Drawing.Point(399, 48);
            this.btnSchwer.Name = "btnSchwer";
            this.btnSchwer.Size = new System.Drawing.Size(76, 23);
            this.btnSchwer.TabIndex = 25;
            this.btnSchwer.Text = "Schwer";
            this.btnSchwer.UseVisualStyleBackColor = false;
            this.btnSchwer.Click += new System.EventHandler(this.btnSchwer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 526);
            this.Controls.Add(this.btnSchwer);
            this.Controls.Add(this.btnEinfach);
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
            this.Controls.Add(this.btnNaechsteKarte);
            this.Controls.Add(this.lblAuswahlVergleichswert);
            this.Controls.Add(this.lblDoppelpunkt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAuswahlVergleichswert;
        private System.Windows.Forms.Button btnNaechsteKarte;
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
        private System.Windows.Forms.Button btnEinfach;
        private System.Windows.Forms.Button btnSchwer;
    }
}

