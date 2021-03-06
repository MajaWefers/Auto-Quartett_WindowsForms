﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Quartett_WindowsForms
{
    public partial class Editor : Form
    {
        private readonly AutokartenDateiZugriff datenZugriff;
        private Autokarte[] karten;




        public Editor(AutokartenDateiZugriff datenZugriff)
        {
            this.datenZugriff = datenZugriff;
            InitializeComponent();
            this.load();
        }

        //Hier werden die in die XML gespeichert
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Autokarte NeueKarte = new Autokarte();
            try
            {
                NeueKarte.marke = tbMarke.Text;
                NeueKarte.modell = tbModell.Text;
                NeueKarte.geschwindigkeit = Int32.Parse(tbGeschwindigkeit.Text);
                NeueKarte.leistung = Int32.Parse(tbLeistung.Text);
                NeueKarte.verbrauch = Double.Parse(tbVerbrauch.Text);
                NeueKarte.zylinder = Int32.Parse(tbZylinder.Text);
                NeueKarte.hubraum = Double.Parse(tbHubraum.Text);
                NeueKarte.beschleunigung = Double.Parse(tbBeschleunigung.Text);
                NeueKarte.zuladung = Int32.Parse(tbZuladung.Text);
                NeueKarte.ladevolumen = Int32.Parse(tbLadevolumen.Text);
                Autokarte[] kartenArray = this.karten.Concat(new[] { NeueKarte }).ToArray();
                this.datenZugriff.SpeichereKarten(kartenArray);
                this.KarteZurListviewHinzufügen(NeueKarte);
                DialogResult dialogResult = MessageBox.Show("Bild speichern ?" + Environment.NewLine + "Bild bitte so bennenen: \"" + tbMarke.Text.ToLower().ToString() + " " + tbModell.Text.ToLower().ToString() + ".jpg\" und in den Ordner kopieren", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    var filePath = AppDomain.CurrentDomain.BaseDirectory;
                    Process.Start(@"Bilder\", filePath);
                }
                this.RefreshView();
            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Hie werden die Textboxen geleert
        private void RefreshView()
        {
            tbMarke.Text = "";
            tbModell.Text = "";
            tbGeschwindigkeit.Text = "";
            tbLeistung.Text = "";
            tbVerbrauch.Text = "";
            tbZylinder.Text = "";
            tbHubraum.Text = "";
            tbBeschleunigung.Text = "";
            tbZuladung.Text = "";
            tbLadevolumen.Text = "";
        }
        // Die Metohde lässt nur Zahlen und ein Komma in den Textboxen zu außer in Modell und Marke
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }
        // Die Methode lässt keine Sonderzeichen in den Modell und Marken Textboxen zu 
        private void OnlyNumAndChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string verboteneZeichen = "*.\"/\\:;|=,";
            if (verboteneZeichen.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Hier werden die karten aus der XML geladen
        private void load()
        {
            this.karten = this.datenZugriff.LadeKarten();
            foreach (Autokarte eintrag in this.karten)
            {
                this.KarteZurListviewHinzufügen(eintrag);
            }

        }
        // Hier werden die Karten in die ListView geladen
        private Autokarte KarteZurListviewHinzufügen(Autokarte eintrag)
        {
            ListViewItem lvItem = new ListViewItem(eintrag.marke);
            lvItem.SubItems.Add(eintrag.modell);
            lvItem.SubItems.Add(eintrag.geschwindigkeit.ToString());
            lvItem.SubItems.Add(eintrag.verbrauch.ToString());
            lvItem.SubItems.Add(eintrag.zylinder.ToString());
            lvItem.SubItems.Add(eintrag.leistung.ToString());
            lvItem.SubItems.Add(eintrag.hubraum.ToString());
            lvItem.SubItems.Add(eintrag.beschleunigung.ToString());
            lvItem.SubItems.Add(eintrag.zuladung.ToString());
            lvItem.SubItems.Add(eintrag.ladevolumen.ToString());
            listView1.Items.Add(lvItem);
            return eintrag;
        }
        //Hier wird verhidert, dass die Geschwindigkeit über 250 Km/h ist
        private void tbGeschwindigkeit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbGeschwindigkeit.Text != "" && Int32.Parse(tbGeschwindigkeit.Text) > 250)
                {
                    MessageBox.Show("Geschwindigkeit zu hoch. Max 250 km/h.", "Geschwindigkeit zu hoch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbGeschwindigkeit.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGeschwindigkeit.Text = "";
            }

        }



   
        //Hier werden die Textboxen via Button Click geleert
        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshView();
        }
    }
}
