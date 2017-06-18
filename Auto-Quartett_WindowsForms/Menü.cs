using System;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient als Ausgangspunkt zum Aufruf sämtlicher Fenster des Programms.
    /// Gegebenenfalls für die Erstellung der Forms nötige Objekte werden vorher erzeugt.
    /// Das Menü wird versteckt, wenn eines der Fenster geöffnet wird
    /// und wieder angezeigt, wenn es geschlossen wurde.
    /// </summary>
    public partial class Menü : Form
    {
        private readonly DatenZugriff datenZugriff;

        public Menü()
        {
            this.InitializeComponent();
            this.datenZugriff = new DatenZugriff("Karten.xml");
        }

        /// <summary>
        /// Instanziiert die für die Erstellung von <see cref="QuartettSpiel"/> benötigten Klassen
        /// <see cref="AutokartenVergleich"/> und <see cref="ChancenBerechner"/>,
        /// lädt die Autokarten aus einer Datei und übergibt das alles an den Konstruktor.
        /// Anschließend wird das Fenster mit Hilfe der Methode <see cref="zeigeForm"/> angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpielButton_Click(object sender, EventArgs e)
        {
            AutokartenVergleich vergleich = new AutokartenVergleich();
            ChancenBerechner chancenBerechner = new ChancenBerechner(vergleich);
            AutokarteDaten[] autokarten = this.ladeKarten();
            QuartettSpiel spielForm = new QuartettSpiel(autokarten, vergleich, chancenBerechner);
            this.zeigeForm(spielForm);
        }

        /// <summary>
        /// Lädt die gespeicherten <see cref="AutokarteDaten"/>n aus der Datei
        /// und erzeugt damit eine Instanz von <see cref="KartenGallerie"/>.
        /// Zeigt diese anschließend an.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GallerieButton_Click(object sender, EventArgs e)
        {
            AutokarteDaten[] autokarten = this.ladeKarten();
            KartenGallerie kartenGallerie = new KartenGallerie(autokarten);

            this.zeigeForm(kartenGallerie);
        }

        /// <summary>
        /// Erzeugt eine Instanz von <see cref="Editor"/> mit
        /// einem davon benötigten <see cref="DatenZugriff"/> 
        /// und zeigt diese an.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditorButton_Click(object sender, EventArgs e)
        {
            Editor editorForm = new Editor(this.datenZugriff);
            this.zeigeForm(editorForm);
        }

        /// <summary>
        /// Schließt das Menüfenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeendenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Versteckt das Menüfenster, zeigt das übergebene <see cref="form"/> an
        /// und abonniert bei diesem das Ereignis <see cref="Form.Closed"/>, um bestimmte Anweisungen
        /// auszuführen, wenn es wieder geschlossen wird
        /// </summary>
        /// <param name="form"></param>
        private void zeigeForm(Form form)
        {
            this.Hide();
            form.Closed += this.onChildFormClosed;
            form.Show();
        }

        private AutokarteDaten[] ladeKarten()
        {
            AutokarteDaten[] gespeicherteKarten = this.datenZugriff.LadeKarten();
            return gespeicherteKarten;
        }

        /// <summary>
        /// EventHandler, der aufgerufen von einem sich schließenden Fenster uafgerufen wird.
        /// Dabei wird das vorher versteckte Menüfenster wieder angezeigt und das Ereignisabonnement
        /// beim geschlossenen Fenster gekündigt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
