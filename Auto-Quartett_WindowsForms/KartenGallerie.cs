using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class KartenGallerie : Form
    {
        public KartenGallerie(AutokarteDaten[] autokarten)
        {
            this.InitializeComponent();
            this.zeigeKarten(autokarten);
        }

        /// <summary>
        /// Erstellt für jede <see cref="AutokarteDaten"/> im übergebenen Array <see cref="autokarten"/>
        /// ein UserControl <see cref="AutokarteSchablone"/> und fügt dieses einem
        /// FlowLayoutPanel hinzu, das diese automatisch hintereinander und mit Zeilenumbrüchen darstellt.
        /// </summary>
        /// <param name="autokarten"></param>
        private void zeigeKarten(AutokarteDaten[] autokarten)
        {
            foreach (AutokarteDaten autokarte in autokarten)
            {
                AutokarteSchablone autokarteAnzeige = new AutokarteSchablone(autokarte);
                this.flowLayoutPanel1.Controls.Add(autokarteAnzeige);
            }
        }
    }
}
