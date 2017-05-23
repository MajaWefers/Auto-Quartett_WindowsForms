using System;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class Menü : Form
    {
        public Menü()
        {
            this.InitializeComponent();
        }

        private void SpielButton_Click(object sender, EventArgs e)
        {
            AutokartenVergleich vergleich = new AutokartenVergleich();
            Autokarte[] autokarten = this.ladeKarten();
            Form1 spielForm = new Form1(autokarten, vergleich);
            this.zeigeForm(spielForm);
        }

        private void GallerieButton_Click(object sender, EventArgs e)
        {
            Autokarte[] autokarten = this.ladeKarten();
            KartenGallerie kartenGallerie = new KartenGallerie(autokarten);

            this.zeigeForm(kartenGallerie);
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            Editor editorForm = new Editor();
            this.zeigeForm(editorForm);
        }

        private void BeendenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zeigeForm(Form form)
        {
            this.Hide();
            form.Closed += this.onChildFormClosed;
            form.Show();
        }

        private Autokarte[] ladeKarten()
        {
            DatenZugriff datenZugriff = new DatenZugriff("VordefinierteKarten.xml");
            Autokarte[] gespeicherteKarten = datenZugriff.LadeKarten();
            return gespeicherteKarten;
        }

        private void onChildFormClosed(object sender, EventArgs e)
        {
            this.Show();
            Form childForm = sender as Form;
            if (childForm != null)
            {
                childForm.Closed -= this.onChildFormClosed;
            }
        }
    }
}
