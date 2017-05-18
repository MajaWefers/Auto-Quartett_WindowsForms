using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class Form1 : Form
    {
        private Autokarte[] autos;
        private readonly DatenZugriff datenZugriff;
        private readonly AutokartenVergleich vergleich;
        private readonly Label[] LabelsAuto1;
        private readonly Label[] LabelsAuto2;

        public Form1(DatenZugriff datenZugriff, AutokartenVergleich vergleich)
        {
            this.datenZugriff = datenZugriff;
            this.vergleich = vergleich;
            this.initialisiereAutos();

            InitializeComponent();

            LabelsAuto1 = new Label[8] { lblGeschwindigkeitWert1, lblLeistungWert1, lblVerbrauchWert1, lblZylinderWert1,
                lblHubraumWert1,lblBeschleunigungWert1,lblZuladungWert1,lblLadevolumenWert1 };
            LabelsAuto2 = new Label[8] { lblGeschwindigkeitWert2, lblLeistungWert2, lblVerbrauchWert2, lblZylinderWert2,
                lblHubraumWert2,lblBeschleunigungWert2,lblZuladungWert2,lblLadevolumenWert2 };
        }

        private void initialisiereAutos()
        {
            Autokarte[] gespeicherteKarten = this.datenZugriff.LadeKarten();

            //TODO: Da wir wahrscheinlich das Array bei jeder neuen Karte vergrößern (also neu erstellen)
            //wollen, kann das dann raus
            this.autos = gespeicherteKarten.Concat(new[] { new Autokarte() }).ToArray();
        }

        //TODO MB: Gleichstand

        //Variablen für den VERGLEICH
        //Zufallszahlen für die beim Vergleich angezeigten Autos
        public static Random nr = new Random();
        public static int zufall1;
        public static int zufall2;

        public void autokarten_anzeigen(Autokarte auto1, Autokarte auto2)
        {
            Autokarte1_anzeigen(auto1);
            Autokarte2_anzeigen(auto2);
        }

        public void Autokarte1_anzeigen(Autokarte auto1)
        {
            panelAuto1.Visible = true;
            lblModell1.Text = auto1.marke.ToUpper();
            lblGeschwindigkeitWert1.Text = auto1.geschwindigkeit.ToString();
            lblLeistungWert1.Text = auto1.leistung.ToString();
            lblVerbrauchWert1.Text = auto1.verbrauch.ToString();
            lblZylinderWert1.Text = auto1.zylinder.ToString();
            lblHubraumWert1.Text = auto1.hubraum.ToString();
            lblBeschleunigungWert1.Text = auto1.beschleunigung.ToString();
            lblZuladungWert1.Text = auto1.zuladung.ToString();
            lblLadevolumenWert1.Text = auto1.ladevolumen.ToString();
        }

        public void Autokarte2_anzeigen(Autokarte auto2)
        {
            panelAuto2.Visible = true;
            lblModell2.Text = auto2.marke.ToUpper();
            lblGeschwindigkeitWert2.Text = auto2.geschwindigkeit.ToString();
            lblLeistungWert2.Text = auto2.leistung.ToString();
            lblVerbrauchWert2.Text = auto2.verbrauch.ToString();
            lblZylinderWert2.Text = auto2.zylinder.ToString();
            lblHubraumWert2.Text = auto2.hubraum.ToString();
            lblBeschleunigungWert2.Text = auto2.beschleunigung.ToString();
            lblZuladungWert2.Text = auto2.zuladung.ToString();
            lblLadevolumenWert2.Text = auto2.ladevolumen.ToString();
        }

        private void btnVergleichen_Click(object sender, EventArgs e)
        {
            Auswahl_anzeigen();
            zufall1 = nr.Next(0, 3); //0 inklusiv, 3 exklusiv
            Autokarte1_anzeigen(autos[zufall1]);
            btnVergleichen.Enabled = false;
        }

        public void Auswahl_anzeigen()
        {
            lblAuswahlVergleichswert.Visible = true;
            cbAuswahlWert.Visible = true;
        }

        private void cbAuswahl_Wert_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vergleichsfeld = cbAuswahlWert.SelectedIndex;

            do
            {
                zufall2 = nr.Next(0, 3); //0 inklusiv, 3 exklusiv
            } while (zufall1 == zufall2);

            //Vorsorglich einen (weiteren) Vergleich verhindern
            cbAuswahlWert.Enabled = false;

            if (vergleichsfeld != -1)
            {
                Autokarte2_anzeigen(autos[zufall2]);
            }
            else
            {
                //Falls der Wert auf "-1" zurückgesetzt ist (Button "Neu"), darf verglichen werden.
                cbAuswahlWert.Enabled = true;
                //Der Vergleich soll erst bei einer gültigen Auswahl ausgefhrt werden
                return;
            }

            //Vergleich der Werte
            Ergebnis vergleichsErgebnis = this.vergleich.Vergleiche(autos[zufall1], autos[zufall2], vergleichsfeld);
            switch (vergleichsErgebnis)
            {
                case Ergebnis.Gleichstand:
                    //TODO: Bei Gleichstand irgendwie die Eigenschaften färben und in lblGewonnenVerloren anzeigen (und dieses Label umbenennen)
                    break;
                case Ergebnis.Gewinn:
                    Farbe_setzen(this.LabelsAuto1[vergleichsfeld], this.LabelsAuto2[vergleichsfeld]);
                    lblGewonnenVerloren.ForeColor = Color.Blue;
                    lblGewonnenVerloren.Text = "Sie haben GEWONNEN!";
                    break;
                case Ergebnis.Niederlage:
                    Farbe_setzen(this.LabelsAuto2[vergleichsfeld], this.LabelsAuto1[vergleichsfeld]);
                    lblGewonnenVerloren.ForeColor = Color.Red;
                    lblGewonnenVerloren.Text = "Sie haben VERLOREN!";
                    break;
            }
        }

        private void Farbe_setzen(Label lblGewonnen, Label lblVerloren)
        {
            lblGewonnen.BackColor = Color.Chartreuse;
            lblVerloren.BackColor = Color.LightCoral;
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            //Zurücksetzen von relevanten Eigenschaften
            panelAuto1.Visible = false;
            panelAuto2.Visible = false;

            cbAuswahlWert.Enabled = true;
            cbAuswahlWert.SelectedIndex = -1; //keine Auswahl in der ComboBox
            cbAuswahlWert.Visible = false;
            lblAuswahlVergleichswert.Visible = false;
            lblGewonnenVerloren.Visible = false;
            btnVergleichen.Enabled = true;


            for (int i = 0; i < 8; i++)
            {
                LabelFarbeZuruecksetzen(this.LabelsAuto1[i]);
                LabelFarbeZuruecksetzen(this.LabelsAuto2[i]);
            }
        }

        private void LabelFarbeZuruecksetzen(Label lblZurücksetzen)
        {
            lblZurücksetzen.BackColor = Color.White;
        }
    }
}
