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
        public Form1()
        {
            InitializeComponent();
        }

        //TODO Variablennamen ausformulieren/angleichen

        Autokarte[] autos = new Autokarte[] 
        {
            new Autokarte("VW Phaeton", 250, 309, 15.7, 12, 6, 6.7, 600, 500),
            new Autokarte("VW New Beetle", 185, 85, 8.7, 4, 2, 10.9, 419, 527),
            new Autokarte("VW Touareg", 225, 230, 12.2, 10, 4.9, 7.8, 600, 555),
            new Autokarte()
        };

        //Variablen für den VERGLEICH
        //Zufallszahlen für die beim Vergleich angezeigten Autos
        public static Random nr = new Random();
        public static int zufall1;
        public static int zufall2;

        public static int vergleichsfeld = 0;
        public static int[] vergleich = new int[8];

        public void autokarten_anzeigen( Autokarte auto1, Autokarte auto2 )
        {
            Autokarte1_anzeigen(auto1);
            Autokarte2_anzeigen(auto2);
        }

        public void Autokarte1_anzeigen( Autokarte auto1 )
        {
            panelAuto1.Visible = true;
            lblModell1.Text = auto1.modell.ToUpper();
            lblGeschwindigkeitWert1.Text = auto1.geschwindigkeit.ToString();
            lblLeistungWert1.Text = auto1.leistung.ToString();
            lblVerbrauchWert1.Text = auto1.verbrauch.ToString();
            lblZylinderWert1.Text = auto1.zylinder.ToString();
            lblHubraumWert1.Text = auto1.hubraum.ToString();
            lblBeschleunigungWert1.Text = auto1.beschleunigung.ToString();
            lblZuladungWert1.Text = auto1.zuladung.ToString();
            lblLadevolumenWert1.Text = auto1.ladevolumen.ToString();
        }

        public void Autokarte2_anzeigen( Autokarte auto2 )
        {
            panelAuto2.Visible = true;
            lblModell2.Text = auto2.modell.ToUpper();
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
            for (int i = 0; i < 8; i++)
            {
                //Zahl pro Eigenschaft
                vergleich[i] = i;
            }
            Auswahl_anzeigen();
            zufall1 = nr.Next(0, 3); //0 inklusiv, 3 exklusiv
            Autokarte1_anzeigen( autos[zufall1] );
            btnVergleichen.Enabled = false;
        }

        public void Auswahl_anzeigen()
        {
            lblAuswahlVergleichswert.Visible = true;
            cbAuswahlWert.Visible            = true;
        }

        private void cbAuswahl_Wert_SelectedIndexChanged(object sender, EventArgs e)
        {
            vergleichsfeld = Vergleichswert_ermitteln();

            do
            {
                zufall2 = nr.Next(0, 3); //0 inklusiv, 3 exklusiv
            } while (zufall1 == zufall2);

            cbAuswahlWert.Enabled = false;

            if (cbAuswahlWert.SelectedIndex != -1)
            {
                Autokarte2_anzeigen(autos[zufall2]);
            }
            else
            {
                cbAuswahlWert.Enabled = true;
            }
            
            //Vergleich der Werte
            bool groesser = Vergleiche_Wert(autos[zufall1], autos[zufall2], vergleichsfeld);

            lblGewonnenVerloren.Visible = true;
            if (groesser)
            {
                lblGewonnenVerloren.ForeColor = Color.Blue;
                lblGewonnenVerloren.Text = "Sie haben GEWONNEN!";
            }
            else
            {
                lblGewonnenVerloren.ForeColor = Color.Red;
                lblGewonnenVerloren.Text = "Sie haben VERLOREN!";
            }
        }

        public int Vergleichswert_ermitteln()
        {
            int feld = 0;
            vergleichsfeld = -1;
            for (int i = 0; i < vergleich.Length-1 ; i++)
            {
                if (cbAuswahlWert.SelectedItem == cbAuswahlWert.Items[i])
                { vergleichsfeld = vergleich[feld]; }
                feld++;
            }
            return vergleichsfeld;
        }

        //private void vergleichen<T>(Autokarte autoX, Func<Autokarte, T> eigenschaft) { }
        public bool Vergleiche_Wert(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            //vergleichen(autos[0], a => a.geschwindigkeit);
            //Ob der Wert von auto_x grösser als von auto_y ist, wird mit "auto_x_groesser" zurückgegeben.
            //So kann gleichzeitig ermittelt werden, ob der Spieler gewonnen/verloren hat.
            bool auto1_groesser = true;

            switch (vergleichsfeld)
            {
                case 0:
                    if (auto1.geschwindigkeit > auto2.geschwindigkeit)
                    {
                        Farbe_setzen(lblGeschwindigkeitWert1, lblGeschwindigkeitWert2);
                    }
                    //Wenn else-Zweig erreicht wird, ist auto_y grösser, und somit ist "auto_x_groesser" "false".
                    else if (auto1.geschwindigkeit < auto2.geschwindigkeit)
                    {
                        Farbe_setzen(lblGeschwindigkeitWert2, lblGeschwindigkeitWert1);
                        auto1_groesser = false;
                    }
                    else
                    {
                        //gleichstand = true;
                    }
                    break;
                case 1:
                    if (auto1.leistung > auto2.leistung)
                    {
                        Farbe_setzen(lblLeistungWert1, lblLeistungWert2);
                    }
                    else if (auto1.leistung < auto2.leistung)
                    {
                        Farbe_setzen(lblLeistungWert2, lblLeistungWert1); ;
                        auto1_groesser = false;
                    }
                    break;
                case 2:
                    //"Verbrauch" ist die Ausnahme: Der kleiner Wert gewinnt.
                    if (auto1.verbrauch < auto2.verbrauch)
                    {
                        Farbe_setzen(lblVerbrauchWert1, lblVerbrauchWert2);
                    }
                    else if (auto1.verbrauch > auto2.verbrauch)
                    {
                        Farbe_setzen(lblVerbrauchWert2, lblVerbrauchWert1);
                        auto1_groesser = false;
                    }
                    break;
                case 3:
                    if (auto1.zylinder > auto2.zylinder)
                    {
                        Farbe_setzen(lblZylinderWert1, lblZylinderWert2);
                    }
                    else if (auto1.zylinder < auto2.zylinder)
                    {
                        Farbe_setzen(lblZylinderWert2, lblZylinderWert1);
                        auto1_groesser = false;
                    }
                    break;
                case 4:
                    if (auto1.hubraum > auto2.hubraum)
                    {
                        Farbe_setzen(lblHubraumWert1, lblHubraumWert2);
                    }
                    else if (auto1.hubraum < auto2.hubraum)
                    {
                        Farbe_setzen(lblHubraumWert2, lblHubraumWert1);
                        auto1_groesser = false;
                    }
                    break;
                case 5:
                    if (auto1.beschleunigung > auto2.beschleunigung)
                    {
                        Farbe_setzen(lblBeschleunigungWert1, lblBeschleunigungWert2);
                    }
                    else if (auto1.beschleunigung < auto2.beschleunigung)
                    {
                        Farbe_setzen(lblBeschleunigungWert2, lblBeschleunigungWert1);
                        auto1_groesser = false;
                    }
                    break;
                case 6:
                    if (auto1.zuladung > auto2.zuladung)
                    {
                        Farbe_setzen(lblZuladungWert1, lblZuladungWert2);
                    }
                    else if (auto1.zuladung < auto2.zuladung)
                    {
                        Farbe_setzen(lblBeschleunigungWert2, lblBeschleunigungWert1);
                        auto1_groesser = false;
                    }
                    break;
                case 7:
                    if (auto1.ladevolumen > auto2.ladevolumen)
                    {
                        Farbe_setzen(lblLadevolumenWert1, lblLadevolumenWert2);
                    }
                    else if (auto1.ladevolumen < auto2.ladevolumen)
                    {
                        Farbe_setzen(lblLadevolumenWert2, lblLadevolumenWert1);
                        auto1_groesser = false;
                    }
                    break;
            }
            return auto1_groesser;
        }

        private void Farbe_setzen(Label lblGewonnen, Label lblVerloren )
        {
            lblGewonnen.BackColor = Color.Chartreuse;
            lblVerloren.BackColor = Color.LightCoral;
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            panelAuto1.Visible = false;
            panelAuto2.Visible = false;

            Label[] auto1 = new Label[8] { lblGeschwindigkeitWert1, lblLeistungWert1, lblVerbrauchWert1, lblZylinderWert1,
            lblHubraumWert1,lblBeschleunigungWert1,lblZuladungWert1,lblLadevolumenWert1 };
            Label[] auto2 = new Label[8] { lblGeschwindigkeitWert2, lblLeistungWert2, lblVerbrauchWert2, lblZylinderWert2,
            lblHubraumWert2,lblBeschleunigungWert2,lblZuladungWert2,lblLadevolumenWert2 };
            for (int i = 0; i < 8; i++)
            {
                LabelFarbe_zuruecksetzen(auto1[i]);
                LabelFarbe_zuruecksetzen(auto2[i]);
            }

            cbAuswahlWert.Enabled = true;
            cbAuswahlWert.SelectedIndex = -1;
            cbAuswahlWert.Visible = false;
            lblAuswahlVergleichswert.Visible = false;
            lblGewonnenVerloren.Visible = false;
            btnVergleichen.Enabled = true;
        }

        private void LabelFarbe_zuruecksetzen(Label lblZurücksetzen)
        {
            lblZurücksetzen.BackColor = Color.White;
        }

        /*public bool Farbe_setzen( bool groesser)
        {
            if (groesser)
            {
                if (groesser)
                { Console.ForegroundColor = ConsoleColor.Green; }
                else
                { Console.ForegroundColor = ConsoleColor.Red; }
            }
            if (auto_xy == "auto_y")
            {
                if (groesser)
                { Console.ForegroundColor = ConsoleColor.Red; }
                else
                { Console.ForegroundColor = ConsoleColor.Green; }
            }
            return groesser;
        }*/
    }
}
