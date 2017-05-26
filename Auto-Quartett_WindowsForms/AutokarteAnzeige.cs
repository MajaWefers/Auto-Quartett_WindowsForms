﻿using System.Drawing;
using System.Windows.Forms;
using System;

namespace Auto_Quartett_WindowsForms
{
    public partial class AutokarteAnzeige : UserControl
    {
        private Label[] labels;

        public AutokarteAnzeige(Autokarte autokarte)
        {
            this.InitializeComponent();
            this.initialisiereLabels();
            this.setzeWerte(autokarte);
        }

        public void SetzeErgebnisFarben(Ergebnis vergleichsErgebnis,int vergleichsfeld)
        {
            switch (vergleichsErgebnis)
            {
                case Ergebnis.Gewinn:
                    this.labels[vergleichsfeld].BackColor = Color.Chartreuse;
                    break;
                case Ergebnis.Niederlage:
                    this.labels[vergleichsfeld].BackColor = Color.LightCoral;
                    break;
                case Ergebnis.Gleichstand:
                    this.labels[vergleichsfeld].BackColor = Color.LightBlue;
                    break;
            }
        }

        private void initialisiereLabels()
        {
            this.labels = new[]
            {
                this.GeschwindigkeitWert,
                this.LeistungWert,
                this.VerbrauchWert,
                this.ZylinderWert,
                this.HubraumWert,
                this.BeschleunigungWert,
                this.ZuladungWert,
                this.LadevolumenWert
            };
        }

        private void setzeWerte(Autokarte autokarte)
        {
            this.Marke.Text = autokarte.marke.ToUpper();
            this.Modell.Text = autokarte.modell.ToUpper();
            this.GeschwindigkeitWert.Text = autokarte.geschwindigkeit.ToString();
            this.LeistungWert.Text = autokarte.leistung.ToString();
            this.VerbrauchWert.Text = autokarte.verbrauch.ToString("N1");
            this.ZylinderWert.Text = autokarte.zylinder.ToString();
            this.HubraumWert.Text = autokarte.hubraum.ToString("N1");
            this.BeschleunigungWert.Text = autokarte.beschleunigung.ToString("N1");
            this.ZuladungWert.Text = autokarte.zuladung.ToString();
            this.LadevolumenWert.Text = autokarte.ladevolumen.ToString();
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Button eigenschaft = (Button)sender;
            //TODO verbinden
            int vergleichsfeld = Convert.ToInt16(eigenschaft.Text);
        }
    }
}
