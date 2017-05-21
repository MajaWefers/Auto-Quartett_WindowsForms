using System;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void SpielButton_Click(object sender, EventArgs e)
        {
            DatenZugriff datenZugriff = new DatenZugriff("VordefinierteKarten.xml");
            AutokartenVergleich vergleich = new AutokartenVergleich();
            Form1 spielForm = new Form1(datenZugriff, vergleich);
            this.zeigeForm(spielForm);
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            Editor editorForm = new Editor();
            this.zeigeForm(editorForm);
        }

        private void zeigeForm(Form form)
        {
            this.Hide();
            form.Closed += this.onChildFormClosed;
            form.Show();
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

        private void BeendenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
