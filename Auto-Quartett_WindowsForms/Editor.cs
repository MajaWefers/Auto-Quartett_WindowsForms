﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Quartett_WindowsForms
{
    public partial class Editor : Form
    {
        private readonly DatenZugriff datenZugriff;
        private Autokarte[] karten;

        public Editor(DatenZugriff datenZugriff)
        {
            this.datenZugriff = datenZugriff;
            InitializeComponent();
            this.load();
        }

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
                this.RefreshView();

                DialogResult dialogResult= MessageBox.Show("12","54",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    var filePath = AppDomain.CurrentDomain.BaseDirectory;
                    Process.Start("explorer.exe", filePath);
                }
            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

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

        private void OnlyNumAndChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void load()
        {
            this.karten = this.datenZugriff.LadeKarten();
            foreach (Autokarte eintrag in this.karten)
            {
                this.KarteZurListviewHinzufügen(eintrag);
            }

        }

        private Autokarte KarteZurListviewHinzufügen(Autokarte eintrag)
        {
            ListViewItem lvItem = new ListViewItem(eintrag.marke);
            lvItem.SubItems.Add(eintrag.modell);
            lvItem.SubItems.Add(eintrag.geschwindigkeit.ToString() + " km/h");
            lvItem.SubItems.Add(eintrag.verbrauch.ToString() + " Liter");
            lvItem.SubItems.Add(eintrag.zylinder.ToString() + " Zyl");
            lvItem.SubItems.Add(eintrag.leistung.ToString() + " kW");
            lvItem.SubItems.Add(eintrag.hubraum.ToString() + " Liter");
            lvItem.SubItems.Add(eintrag.beschleunigung.ToString() + " sec");
            lvItem.SubItems.Add(eintrag.zuladung.ToString() + " Kg");
            lvItem.SubItems.Add(eintrag.ladevolumen.ToString() + " Liter");
            listView1.Items.Add(lvItem);
            return eintrag;
        }

        private void tbGeschwindigkeit_TextChanged(object sender, EventArgs e)
        {
            if (tbGeschwindigkeit.Text != ""
                && Int32.Parse(tbGeschwindigkeit.Text) > 250)
            {
                MessageBox.Show("Geschwindigkeit zu hoch. Max 250 km/h.", "Geschwindigkeit zu hoch", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                tbGeschwindigkeit.Text = "250";
                
            }

        }
    }
}
