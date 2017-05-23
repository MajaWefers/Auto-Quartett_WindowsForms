using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class KartenGallerie : Form
    {
        public KartenGallerie(Autokarte[] autokarten)
        {
            this.InitializeComponent();
            this.zeigeKarten(autokarten);
        }

        private void zeigeKarten(Autokarte[] autokarten)
        {
            foreach (Autokarte autokarte in autokarten)
            {
                AutokarteAnzeige autokarteAnzeige = new AutokarteAnzeige(autokarte);
                this.flowLayoutPanel1.Controls.Add(autokarteAnzeige);
            }
        }
    }
}
