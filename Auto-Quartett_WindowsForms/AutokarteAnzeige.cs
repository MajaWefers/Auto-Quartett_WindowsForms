using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class AutokarteAnzeige : UserControl
    {
        public AutokarteAnzeige(Autokarte autokarte)
        {
            InitializeComponent();

            Marke.Text = autokarte.marke.ToUpper();
            Modell.Text = autokarte.modell.ToUpper();
            GeschwindigkeitWert.Text = autokarte.geschwindigkeit.ToString();
            LeistungWert.Text = autokarte.leistung.ToString();
            VerbrauchWert.Text = autokarte.verbrauch.ToString("N1");
            ZylinderWert.Text = autokarte.zylinder.ToString();
            HubraumWert.Text = autokarte.hubraum.ToString("N1");
            BeschleunigungWert.Text = autokarte.beschleunigung.ToString("N1");
            ZuladungWert.Text = autokarte.zuladung.ToString();
            LadevolumenWert.Text = autokarte.ladevolumen.ToString();
        }
    }
}
