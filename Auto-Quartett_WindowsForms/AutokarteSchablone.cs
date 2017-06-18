﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class AutokarteSchablone : UserControl
    {
        private Label[] labels;

        public AutokarteSchablone(AutokarteDaten autokarte)
        {
            this.InitializeComponent();
            this.initialisiereLabels();
            this.setzeWerte(autokarte);
            this.BildEinfuegen(autokarte);
        }

        public void SetzeErgebnisFarben(SpielVergleichErgebnis vergleichsErgebnis,int vergleichsfeld)
        {
            switch (vergleichsErgebnis)
            {
                case SpielVergleichErgebnis.Gewinn:
                    this.labels[vergleichsfeld].BackColor = Color.Chartreuse;
                    this.BackColor = Color.LightGreen;
                    break;
                case SpielVergleichErgebnis.Niederlage:
                    this.labels[vergleichsfeld].BackColor = Color.LightCoral;
                    this.BackColor = Color.Salmon;
                    break;
                case SpielVergleichErgebnis.Gleichstand:
                    this.labels[vergleichsfeld].BackColor = Color.LightBlue;
                    this.BackColor = Color.Blue;
                    break;
                default:
                    throw new InvalidEnumArgumentException(@"Ungültiges Ergebnis");
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

        private void setzeWerte(AutokarteDaten autokarte)
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

        //Das Bild ist keine Eigenschaft der Autokarte, sondern wird direkt aus dem Bilder-Ordner
        //geladen, der in dem Ordner der ausgeführten Datei liegen muss.
        private void BildEinfuegen(AutokarteDaten autokarte)
        {
            try
            {
                AutoBild.Image = Image.FromFile(@"Bilder\" + autokarte.marke.ToLower() + " " + autokarte.modell.ToLower() + ".jpg");
            }
            catch
            {
                try
                {
                    AutoBild.Image = Image.FromFile(@"Bilder\" + "autodefault.jpg");
                }
                catch
                {
                }
            }
        }
    }
}
