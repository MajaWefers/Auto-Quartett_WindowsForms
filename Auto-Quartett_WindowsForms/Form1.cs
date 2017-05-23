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
        private readonly AutokartenVergleich vergleich;

        private AutokarteAnzeige autokarteAnzeige1;
        private AutokarteAnzeige autokarteAnzeige2;

        //Variablen für den VERGLEICH
        //Zufallszahlen für die beim Vergleich angezeigten Autos
        public static Random nr = new Random();
        public static int zufall1;
        public static int zufall2;

        public Form1(Autokarte[] autokarten, AutokartenVergleich vergleich)
        {
            this.autos = autokarten;
            this.vergleich = vergleich;

            InitializeComponent();
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

        //TODO MB: Gleichstand
        
        private void btnVergleichen_Click(object sender, EventArgs e)
        {
            Auswahl_anzeigen();
            zufall1 = nr.Next(0, autos.Length); //0 inklusiv, autos.Length exklusiv
            zeigeAuto1(autos[zufall1]);
            
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
                zufall2 = nr.Next(0, autos.Length); //0 inklusiv, autos.Length exklusiv
            } while (zufall1 == zufall2);

            //Vorsorglich einen (weiteren) Vergleich verhindern
            cbAuswahlWert.Enabled = false;

            if (vergleichsfeld != -1)
            {
                zeigeAuto2(autos[zufall2]);
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
            autokarteAnzeige1.SetzeErgebnisFarben(vergleichsErgebnis, vergleichsfeld);
            switch (vergleichsErgebnis)
            {
                case Ergebnis.Gewinn:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Niederlage, vergleichsfeld);
                    lblGewonnenVerloren.ForeColor = Color.Blue;
                    lblGewonnenVerloren.Text = "Sie haben GEWONNEN!";
                    break;
                case Ergebnis.Niederlage:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Gewinn, vergleichsfeld);
                    lblGewonnenVerloren.ForeColor = Color.Red;
                    lblGewonnenVerloren.Text = "Sie haben VERLOREN!";
                    break;
                case Ergebnis.Gleichstand:
                    autokarteAnzeige2.SetzeErgebnisFarben(Ergebnis.Gleichstand, vergleichsfeld);
                    //TODO: lblGewonnenVerloren anzeigen und färben (und das Label umbenennen)
                    break;
            }
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            //Autokartenanzeigen entfernen
            this.PanelAuto1.Controls.Clear();
            this.PanelAuto2.Controls.Clear();

            //Zurücksetzen von relevanten Eigenschaften
            cbAuswahlWert.Enabled = true;
            cbAuswahlWert.SelectedIndex = -1; //keine Auswahl in der ComboBox
            cbAuswahlWert.Visible = false;
            lblAuswahlVergleichswert.Visible = false;
            lblGewonnenVerloren.Visible = false;
            btnVergleichen.Enabled = true;
        }
    }
}
