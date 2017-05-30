using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            this.BildEinfuegen(autokarte);
            //Abrunden(panelAuto, 0, 0, 292, 451, 40);
        }

        //Quelle: http://www.vbarchiv.net/forum/id22_i51818t51817_panel-abrunden.html
        private void Abrunden(Panel Form, int x, int y, int width, int height, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new  System.Drawing.Drawing2D.GraphicsPath();
            
            gp.AddLine(x + radius, y, x + width - radius, y);
            gp.AddArc(x + width - radius, y, radius, radius, 270, 90);
            gp.AddLine(x + width, y + radius, x + width, y + height - radius);
            gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
            gp.AddLine(x + width - radius, y + height, x + radius, y + height);
            gp.AddArc(x, y + height - radius, radius, radius, 90, 90);
            gp.AddLine(x, y + height - radius, x, y + radius);
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.CloseFigure();
            
            Form.Region = new System.Drawing.Region(gp);
            gp.Dispose();
        }

        public void SetzeErgebnisFarben(Ergebnis vergleichsErgebnis,int vergleichsfeld)
        {
            switch (vergleichsErgebnis)
            {
                case Ergebnis.Gewinn:
                    this.labels[vergleichsfeld].BackColor = Color.Chartreuse;
                    this.BackColor = Color.LightGreen;
                    break;
                case Ergebnis.Niederlage:
                    this.labels[vergleichsfeld].BackColor = Color.LightCoral;
                    this.BackColor = Color.Salmon;
                    break;
                case Ergebnis.Gleichstand:
                    this.labels[vergleichsfeld].BackColor = Color.LightBlue;
                    this.BackColor = Color.Blue;
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

        private void BildEinfuegen(Autokarte autokarte)
        {
            try
            {
                AutoBild.Image = Image.FromFile(@"Bilder\" + autokarte.marke.ToLower() + Regex.Replace(autokarte.modell.ToLower(), " ", "") + ".jpg");
            }
            catch
            {
                AutoBild.Image = Image.FromFile(@"Bilder\" + "autodefault.jpg");
            }
        }
    }
}
