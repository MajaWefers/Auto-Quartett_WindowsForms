using System;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class QuartettSpiel : Form
    {
        private AutokarteDaten[] autos;
        private AutokartenVergleich vergleich;
        private ChancenBerechner chancenBerechner;
        private ToolTip toolTip;

        private AutokarteSchablone autokarteAnzeige1;
        private AutokarteSchablone autokarteAnzeige2;

        /// <summary>
        /// Variablen für den VERGLEICH
        /// Variablen für Zufallszahlen, um beim Vergleich ein zufälliges Auto zu wählen
        /// </summary>
        public static Random nr = new Random();
        public static int zufall1;
        public static int zufall2;

        int spielerpunkte;
        int gegnerpunkte;
        bool gewinnchancenSichtbar;

        /// <summary>
        /// Steuert die Erstellung der benötogten Komponenten des Spiels
        /// </summary>
        /// <param name="autokarten"></param>
        /// <param name="vergleich"></param>
        /// <param name="chancenBerechner"></param>
        public QuartettSpiel(AutokarteDaten[] autokarten, AutokartenVergleich vergleich, ChancenBerechner chancenBerechner)
        {
            this.autos = autokarten;
            this.vergleich = vergleich;
            this.chancenBerechner = chancenBerechner;
            this.toolTip = new ToolTip();

            InitializeComponent();
            zeigeSpielkarte();

            this.toolTip.SetToolTip(this.btnEinfach, 
                "Zeigt die Gewinnchance bei Auswahl einer bestimmten Eigenschaft zum Vergleich");
            this.toolTip.SetToolTip(this.btnSchwer, "Zeigt keine Hilfe an");
            this.toolTip.SetToolTip(this.lblVergleich, "↑: größerer Wert gewinnt\n↓: kleinerer Wert gewinnt");
        }

        private void zeigeSpielkarte()
        {
            zufall1 = nr.Next(0, autos.Length); //0 inklusiv, autos.Length exklusiv
            AutokarteDaten autoDesSpielers = autos[zufall1];
            zeigeAuto1(autoDesSpielers);
            setzeToolTips(autoDesSpielers);
        }

        private void zeigeAuto1(AutokarteDaten auto)
        {
            autokarteAnzeige1 = new AutokarteSchablone(auto);
            PanelAuto1.Controls.Add(autokarteAnzeige1);
        }
    
        private void zeigeAuto2(AutokarteDaten auto)
        {
            autokarteAnzeige2 = new AutokarteSchablone(auto);
            PanelAuto2.Controls.Add(autokarteAnzeige2);
        }

        /// <summary>
        /// Wird bei Klick auf einen Button vor den Eigenschaften der eigenen Spielkarte aufgerufen
        /// </summary>
        /// <param name="vergleichsfeld"></param>
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

            //Je nach Punkteverhältnis wird die Schriftfarbe der Punktanzeige gesetzt
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


        private void btnNaechsteKarte_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Die "Enabled"-Eigenschaft der Vergleichsbuttons und des "Nächste Karte"-Buttons
        /// wird entgegengesetzt auf true/false gesetzt.
        /// </summary>
        /// <param name="klickbar"></param>
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
            btnNaechsteKarte.Enabled = !klickbar;
            //Focus setzen, damit mit Enter und Pfeiltasten leicht bedient werden kann.
            if (!klickbar)
            {
                btnNaechsteKarte.Focus();
            }
            else
            {
                btnGeschwindigkeit.Focus();
            }
        }
        
        /// <summary>
        /// Der Wert des Vergleichsfeldes wird entsprechend dem angeklickten Button gesetzt. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Setzt ToolTips für die Anzeige der Eigenschaftszuweisung der Buttons
        /// sowie die Gewinnchance bei Auswahl der jeweiligen Eigenschaft 
        /// </summary>
        /// <param name="auto"></param>
        private void setzeToolTips(AutokarteDaten auto)
        {

            double[] gewinnchancen = berechneGewinnchancen(auto);
            setzeToolTip(btnGeschwindigkeit, "Geschwindigkeit", gewinnchancen[0]);
            setzeToolTip(btnLeistung, "Leistung", gewinnchancen[1]);
            setzeToolTip(btnVerbrauch, "Verbrauch", gewinnchancen[2]);
            setzeToolTip(btnZylinder, "Zylinder", gewinnchancen[3]);
            setzeToolTip(btnHubraum, "Hubraum", gewinnchancen[4]);
            setzeToolTip(btnBeschleunigung, "Beschleunigung", gewinnchancen[5]);
            setzeToolTip(btnZuladung, "Zuladung", gewinnchancen[6]);
            setzeToolTip(btnLadevolumen, "Ladevolumen", gewinnchancen[7]);

        }

        //Es folgen die Events für das Ein- und Ausblenden der Chancenberechnung
        private void btnEinfach_Click(object sender, EventArgs e)
        {
            this.gewinnchancenSichtbar = true;
            this.setzeToolTips(this.autos[zufall1]);
            MessageBox.Show(
                "Gewinnchancen werden jetzt als Tooltip der Buttons angezeigt, " +
                "mit denen man eine Eigenschaft für den Vergleich auswählt.",
                "Info", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Asterisk);
        }

        private void btnSchwer_Click(object sender, EventArgs e)
        {
            this.gewinnchancenSichtbar = false;
            this.setzeToolTips(this.autos[zufall1]);
            MessageBox.Show(
                "Gewinnchancen werden nicht als Tooltip angezeigt.", 
                "Info", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void setzeToolTip(Button button, string eigenschaft, double gewinnChance)
        {
            string toolTipText = eigenschaft;
            if (this.gewinnchancenSichtbar)
            {
                toolTipText += "\nGewinnchance: " + gewinnChance.ToString("P0");
            }
            this.toolTip.SetToolTip(button, toolTipText);
        }
        
        private double[] berechneGewinnchancen(AutokarteDaten auto)
        {
            double[] gewinnchancen = new double[8];
            for (int i = 0; i < gewinnchancen.Length; i++)
            {
                gewinnchancen[i] = this.chancenBerechner.BerechneGewinnchance(auto, this.autos, i);
            }
            return gewinnchancen;
        }

    }
}
