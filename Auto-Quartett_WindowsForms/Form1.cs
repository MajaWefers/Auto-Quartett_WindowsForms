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
            autokarten_erstellen();
        }


        Autokarte auto1 = new Autokarte();
        Autokarte auto2 = new Autokarte();
        Autokarte auto3 = new Autokarte();
        
        string vergleichsfeld = "";

        public struct Autokarte
        {
            public string modell;
            public int    geschwindigkeit;
            public int    leistung;
            public double verbrauch;
            public int    zylinder;
            public double hubraum;
            public double beschleunigung;
            public int    zuladung;
            public int    ladevolumen;
        }

        public void autokarten_erstellen()
        {
            //Autokarten werden erstellt
            Autokarte_fuellen( ref auto1, "VW Phaeton", 250, 309, 15.7, 12, 6, 6.7, 600, 500 );
            Autokarte_fuellen( ref auto2, "VW New Beetle", 185, 85, 8.7, 4, 2, 10.9, 419, 527 );
            Autokarte_fuellen( ref auto3, "VW Touareg", 225, 230, 12.2, 10, 4.9, 7.8, 600, 555 );
        }
        

        public void autokarten_anzeigen( Autokarte auto_x, Autokarte auto_y )
        {
            Autokarte1_anzeigen(auto_x);
            Autokarte2_anzeigen(auto_y);
        }

        public void Autokarte_fuellen( ref Autokarte auto_x, string name, int speed, int leist, double verbr,
                                       int zyl, double hubr, double beschl, int zulad, int ladevol )
        {
            auto_x.modell          = name;
            auto_x.geschwindigkeit = speed;
            auto_x.leistung        = leist;
            auto_x.verbrauch       = verbr;
            auto_x.zylinder        = zyl;
            auto_x.hubraum         = hubr;
            auto_x.beschleunigung  = beschl;
            auto_x.zuladung        = zulad;
            auto_x.ladevolumen     = ladevol;
        }

        public void Autokarte1_anzeigen( Autokarte auto_x )
        {
            panelAuto1.Visible = true;
            lblModell1.Text    = auto_x.modell.ToUpper();
            lbl_g_wert1.Text   = auto_x.geschwindigkeit.ToString();
            lbl_l_wert1.Text   = auto_x.leistung.ToString();
            lbl_v_wert1.Text   = auto_x.verbrauch.ToString();
            lbl_zy_wert1.Text  = auto_x.zylinder.ToString();
            lbl_h_wert1.Text   = auto_x.hubraum.ToString();
            lbl_b_wert1.Text   = auto_x.beschleunigung.ToString();
            lbl_zu_wert1.Text  = auto_x.zuladung.ToString();
            lbl_la_wert1.Text  = auto_x.ladevolumen.ToString();
        }

        public void Autokarte2_anzeigen( Autokarte auto_x )
        {
            panelAuto2.Visible = true;
            lblModell2.Text    = auto_x.modell.ToUpper();
            lbl_g_wert2.Text   = auto_x.geschwindigkeit.ToString();
            lbl_l_wert2.Text   = auto_x.leistung.ToString();
            lbl_v_wert2.Text   = auto_x.verbrauch.ToString();
            lbl_zy_wert2.Text  = auto_x.zylinder.ToString();
            lbl_h_wert2.Text   = auto_x.hubraum.ToString();
            lbl_b_wert2.Text   = auto_x.beschleunigung.ToString();
            lbl_zu_wert2.Text  = auto_x.zuladung.ToString();
            lbl_la_wert2.Text  = auto_x.ladevolumen.ToString();
        }

        private void btnVergleichen_Click(object sender, EventArgs e)
        {
            Auswahl_anzeigen();
            Autokarte1_anzeigen( auto1 );
        }

        public void Auswahl_anzeigen()
        {
            lblAuswahl_Vergleichswert.Visible = true;
            cbAuswahl_Wert.Visible            = true;
        }

        public bool Vergleiche_Wert( Autokarte auto_x, Autokarte auto_y, string vergleichsfeld )
        {
            //Ob der Wert von auto_x grösser als von auto_y ist, wird mit "auto_x_groesser" zurückgegeben.
            //So kann gleichzeitig ermittelt werden, ob der Spieler gewonnen/verloren hat.
            bool auto_x_groesser = true;

            switch ( vergleichsfeld )
            {
                case "g":
                    if ( auto_x.geschwindigkeit > auto_y.geschwindigkeit )
                    {
                        lbl_g_wert1.BackColor = Color.Chartreuse;
                        lbl_g_wert2.BackColor = Color.LightCoral;
                    }
                    //Wenn else-Zweig erreicht wird ist auto_y grösser und somit ist "auto_x_groesser" "false".
                    else
                    {
                        lbl_g_wert1.BackColor = Color.LightCoral;
                        lbl_g_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                case "l":
                    if ( auto_x.leistung > auto_y.leistung)
                    {
                        lbl_l_wert1.BackColor = Color.Chartreuse;
                        lbl_l_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_l_wert1.BackColor = Color.LightCoral;
                        lbl_l_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                case "v":
                    if ( auto_x.verbrauch > auto_y.verbrauch )
                    {
                        lbl_v_wert1.BackColor = Color.Chartreuse;
                        lbl_v_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_v_wert1.BackColor = Color.LightCoral;
                        lbl_v_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                 case "zy":
                    if ( auto_x.zylinder > auto_y.zylinder )
                    {
                        lbl_zy_wert1.BackColor = Color.Chartreuse;
                        lbl_zy_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_zy_wert1.BackColor = Color.LightCoral;
                        lbl_zy_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                 case "h":
                    if ( auto_x.hubraum > auto_y.hubraum )
                    {
                        lbl_h_wert1.BackColor = Color.Chartreuse;
                        lbl_h_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_h_wert1.BackColor = Color.LightCoral;
                        lbl_h_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                case "b":
                    if (auto_x.beschleunigung > auto_y.beschleunigung)
                    {
                        lbl_b_wert1.BackColor = Color.Chartreuse;
                        lbl_b_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_b_wert1.BackColor = Color.LightCoral;
                        lbl_b_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                case "zu":
                    if ( auto_x.zuladung > auto_y.zuladung )
                    {
                        lbl_zu_wert1.BackColor = Color.Chartreuse;
                        lbl_zu_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_zu_wert1.BackColor = Color.LightCoral;
                        lbl_zu_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
                case "la":
                    if ( auto_x.ladevolumen > auto_y.ladevolumen )
                    {
                        lbl_la_wert1.BackColor = Color.Chartreuse;
                        lbl_la_wert2.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lbl_la_wert1.BackColor = Color.LightCoral;
                        lbl_la_wert2.BackColor = Color.Chartreuse;
                        auto_x_groesser = false;
                    }
                    break;
            }
            return auto_x_groesser;
        }

        private void cbAuswahl_Wert_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vergleichswert_ermitteln();

            Autokarte2_anzeigen(auto2);
            //Vergleichen der Werte
            bool groesser = Vergleiche_Wert(auto1, auto2, vergleichsfeld);

            lblGewonnen_Verloren.Visible = true;
            if (groesser)
            {
                lblGewonnen_Verloren.ForeColor = Color.Blue;
                lblGewonnen_Verloren.Text = "Sie haben gewonnen!";
            }
            else
            {
                lblGewonnen_Verloren.ForeColor = Color.Red;
                lblGewonnen_Verloren.Text = "Sie haben verloren!";
            }
        }

        public void Vergleichswert_ermitteln()
        {
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[0]) //.ToString() == "Geschwindigkeit"
            { vergleichsfeld = "g"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[1]) //.ToString() == "Leistung"
            { vergleichsfeld = "l"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[2]) //.ToString() == "Verbrauch"
            { vergleichsfeld = "v"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[3]) //.ToString() == "Zylinder"
            { vergleichsfeld = "zy"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[4]) //.ToString() == "Hubraum"
            { vergleichsfeld = "h"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[5]) //.ToString() == "Beschleunigung"
            { vergleichsfeld = "b"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[6]) //.ToString() == "Zuladung"
            { vergleichsfeld = "zu"; }
            if (cbAuswahl_Wert.SelectedItem == cbAuswahl_Wert.Items[7]) //.ToString() == "Ladevolumen"
            { vergleichsfeld = "la"; }
        }

        //Wenn auf den jeweiligen Button geklickt wird, dann wird das "vergleichsfeld" gesetzt

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
