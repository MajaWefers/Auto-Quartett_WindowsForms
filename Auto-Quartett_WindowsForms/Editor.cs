using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

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
            Autokarte save = new Autokarte();
            save.marke = tbMarke.Text;
            save.modell = tbModell.Text;
            save.geschwindigkeit = Int32.Parse(tbGeschwindigkeit.Text);
            save.leistung = Int32.Parse(tbLeistung.Text);
            save.verbrauch = Double.Parse(tbVerbrauch.Text);
            save.zylinder = Int32.Parse(tbZylinder.Text);
            save.hubraum = Double.Parse(tbHubraum.Text);
            save.beschleunigung = Double.Parse(tbBeschleunigung.Text);
            save.zuladung = Int32.Parse(tbZuladung.Text);
            save.ladevolumen = Int32.Parse(tbLadevolumen.Text);
            Autokarte[] kartenArray = this.karten.Concat(new[] { save }).ToArray();
            this.datenZugriff.SpeichereKarten(kartenArray);

            this.RefreshView();

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
                ListViewItem lvItem = new ListViewItem(eintrag.marke);
                lvItem.SubItems.Add(eintrag.modell);
                lvItem.SubItems.Add(eintrag.geschwindigkeit.ToString()+ " km/h");
                lvItem.SubItems.Add(eintrag.verbrauch.ToString()+" Liter");
                lvItem.SubItems.Add(eintrag.zylinder.ToString()+" Zyl");
                lvItem.SubItems.Add(eintrag.leistung.ToString()+" kW");
                lvItem.SubItems.Add(eintrag.hubraum.ToString()+" Liter");
                lvItem.SubItems.Add(eintrag.beschleunigung.ToString()+" sec");
                lvItem.SubItems.Add(eintrag.zuladung.ToString()+" Kg");
                lvItem.SubItems.Add(eintrag.ladevolumen.ToString()+" Liter");

                listView1.Items.Add(lvItem);
            }

        }
    }
}
