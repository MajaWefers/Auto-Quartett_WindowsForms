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

        /// <summary>
        /// Erstellt für jede <see cref="Autokarte"/> im übergebenen Array <see cref="autokarten"/>
        /// ein UserControl <see cref="AutokarteAnzeige"/> und fügt dieses einem
        /// FlowLayoutPanel hinzu, das diese automatisch hintereinander und mit Zeilenumbrüchen darstellt.
        /// </summary>
        /// <param name="autokarten"></param>
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
