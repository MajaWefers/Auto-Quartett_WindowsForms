using System;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class Form1 : Form
    {
        private Autokarte[] autos;
        private readonly AutokartenVergleich vergleich;

        private AutokarteAnzeige autokarteAnzeige1;
        private AutokarteAnzeige autokarteAnzeige2;

        //Variablen für den VERGLEICH
        //Zufallszahlen für die beim Vergleich angezeigten Autos
        public static Random nr = new Random();
        public static int zufall1;
        public static int zufall2;

        int spielerpunkte;
        int gegnerpunkte;

        public Form1(Autokarte[] autokarten, AutokartenVergleich vergleich)
        {
            this.autos = autokarten;
            this.vergleich = vergleich;

            InitializeComponent();
            zeigeSpielkarte();
        }

        private void zeigeSpielkarte()
        {
            zufall1 = nr.Next(0, autos.Length); //0 inklusiv, autos.Length exklusiv
            zeigeAuto1(autos[zufall1]);
        }

        private void zeigeAuto1(Autokarte auto)
        {
            autokarteAnzeige1 =  new AutokarteAnzeige(auto);
            PanelAuto1.Controls.Add(autokarteAnzeige1);
        }

        private void zeigeAuto2(Autokarte auto)
        {
            autokarteAnzeige2 =  new AutokarteAnzeige(auto);
            PanelAuto2.Controls.Add(autokarteAnzeige2);
        }
        
        //Wird bei Klick auf einen Button vor den Eigenschaften der eigenen Spielkarte aufgerufen
        private void Vergleich(int vergleichsfeld)
        {
            do
            {
                zufall2 = nr.Next(0, autos.Length); //0 inklusiv, autos.Length exklusiv
            } while (zufall1 == zufall2);

            zeigeAuto2(autos[zufall2]);

            //Vergleich der Werte
            Ergebnis vergleichsErgebnis = this.vergleich.Vergleiche(autos[zufall1], autos[zufall2], vergleichsfeld);
            autokarteAnzeige1.SetzeErgebnisFarben(vergleichsErgebnis, vergleichsfeld);
            switch (vergleichsErgebnis)
            {
                case Ergebnis.Gewinn:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Niederlage, vergleichsfeld);
                    Int32.TryParse(lblSpielerpunkte.Text, out spielerpunkte);
                    lblSpielerpunkte.Text = Convert.ToString(++spielerpunkte);
                    break;
                case Ergebnis.Niederlage:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Gewinn, vergleichsfeld);
                    Int32.TryParse(lblGegnerpunkte.Text, out gegnerpunkte);
                    lblGegnerpunkte.Text = Convert.ToString(++gegnerpunkte);
                    break;
                case Ergebnis.Gleichstand:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Gleichstand, vergleichsfeld);
                    break;
            }

            if (spielerpunkte > gegnerpunkte)
            {
                lblSpielerpunkte.ForeColor = Color.Green;
                lblGegnerpunkte.ForeColor = Color.Red;
            }
            else if (spielerpunkte < gegnerpunkte)
            {
                lblSpielerpunkte.ForeColor = Color.Red;
                lblGegnerpunkte.ForeColor = Color.Green;
            }
            else if (spielerpunkte == gegnerpunkte)
            {
                lblSpielerpunkte.ForeColor = Color.Blue;
                lblGegnerpunkte.ForeColor = Color.Blue;
            }
            ButtonsEnabled(false);
        }
        
        private void btnNeu_Click(object sender, EventArgs e)
        {
            if (btnBeschleunigung.Enabled == false)
            {
                //Autokartenanzeigen entfernen
                this.PanelAuto1.Controls.Clear();
                this.PanelAuto2.Controls.Clear();

                //Zurücksetzen von relevanten Eigenschaften
                zeigeSpielkarte();
                ButtonsEnabled(true);
            }
        }
        
        private void ButtonsEnabled(bool klickbar)
        {
            btnGeschwindigkeit.Enabled = klickbar;
            btnLeistung.Enabled = klickbar;
            btnVerbrauch.Enabled = klickbar;
            btnZylinder.Enabled = klickbar;
            btnHubraum.Enabled = klickbar;
            btnBeschleunigung.Enabled = klickbar;
            btnZuladung.Enabled = klickbar;
            btnLadevolumen.Enabled = klickbar;
            //Next kann umgekehrt zu Vergleich nicht angeklickt werden.
            btnNeu.Enabled = !klickbar;
            //Focus setzen, damit mit Enter und Pfeiltasten leicht bedient werden kann.
            if (!klickbar)
            {
                btnNeu.Focus();
            }
            else
            {
                btnGeschwindigkeit.Focus();
            }
        }

        //Der Wert des Vergleichsfeldes wird entsprechend dem angeklickten Button gesetzt.
        private void btnGeschwindigkeit_Click(object sender, EventArgs e)
        {
            Vergleich(0);
        }
        private void btnLeistung_Click(object sender, EventArgs e)
        {
            Vergleich(1);
        }
        private void btnVerbrauch_Click(object sender, EventArgs e)
        {
            Vergleich(2);
        }
        private void btnZylinder_Click(object sender, EventArgs e)
        {
            Vergleich(3);
        }
        private void btnHubraum_Click(object sender, EventArgs e)
        {
            Vergleich(4);
        }
        private void btnBeschleunigung_Click(object sender, EventArgs e)
        {
            Vergleich(5);
        }
        private void btnZuladung_Click(object sender, EventArgs e)
        {
            Vergleich(6);
        }
        private void btnLadevolumen_Click(object sender, EventArgs e)
        {
            Vergleich(7);
        }

        //ToolTips für die Anzeige der Eigenschaftszuweisung der Buttons
        private void btnGeschwindigkeit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnGeschwindigkeit, "Geschwindigkeit");
        }
        private void btnLeistung_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnLeistung, "Leistung");
        }
        private void btnVerbrauch_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnVerbrauch, "Verbrauch");
        }
        private void btnZylinder_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnZylinder, "Zylinder");
        }
        private void btnHubraum_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnHubraum, "Hubraum");
        }
        private void btnBeschleunigung_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnBeschleunigung, "Beschleunigung");
        }
        private void btnZuladung_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnZuladung, "Zuladung");
        }
        private void btnLadevolumen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnLadevolumen, "Ladevolumen");
        }
    }
}
