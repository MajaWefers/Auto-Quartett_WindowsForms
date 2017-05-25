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

        public Editor(DatenZugriff datenZugriff)
        {
            this.datenZugriff = datenZugriff;
            InitializeComponent();
        }

        private void beispiele()
        {
            //Beispiel zum Laden
            Autokarte[] karten = this.datenZugriff.LadeKarten();
            //danach die Karten in der Tabelle anzeigen etc

            //Beispiel zum Speichern
            //karten sollten alle Karten sein, die vorher geladenen + die neue
            this.datenZugriff.SpeichereKarten(karten);
        }
       
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\Users\Rajee\Source\Repos\New\Auto-Quartett_WindowsForms\bin\Debug";
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 10;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Autokarte save = new Autokarte();
                try
                {
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

                    XmlSave.SaveData(save, saveFileDialog.FileName);

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }




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

        private void Editor_Load(object sender, EventArgs e)
        {
            if (File.Exists("Auto-Quartett Karten"))
            {
                Autokarte load = new Autokarte();

                XmlLoad<Autokarte> loadAutokarte = new XmlLoad<Autokarte>();

                load = loadAutokarte.LoadData("Auto-Quartett Karten");

                

                tbMarke.Text = load.marke;
                tbModell.Text = load.modell;
                tbGeschwindigkeit.Text = load.geschwindigkeit.ToString();
                tbLeistung.Text = load.leistung.ToString();
                tbVerbrauch.Text = load.verbrauch.ToString();
                tbZylinder.Text = load.zylinder.ToString();
                tbHubraum.Text = load.hubraum.ToString();
                tbBeschleunigung.Text = load.beschleunigung.ToString();
                tbZuladung.Text = load.zuladung.ToString();
                tbLadevolumen.Text = load.ladevolumen.ToString();

                //   //   foreach (var karte in new Autokarte())
                ////  {
                //          ListViewItem lvItem = new ListViewItem();
                //          lvItem.SubItems.Add(eintrag.marke);
                //          lvItem.SubItems.Add(eintrag.modell);
                //          lvItem.SubItems.Add(eintrag.geschwindigkeit.ToString());
                //          lvItem.SubItems.Add(eintrag.leistung.ToString());
                //          lvItem.SubItems.Add(eintrag.verbrauch.ToString());
                //          lvItem.SubItems.Add(eintrag.zylinder.ToString());
                //          lvItem.SubItems.Add(eintrag.hubraum.ToString());
                //          lvItem.SubItems.Add(eintrag.beschleunigung.ToString());
                //          lvItem.SubItems.Add(eintrag.zuladung.ToString());
                //          lvItem.SubItems.Add(eintrag.ladevolumen.ToString());

                //   //   }
            }
        }
    }
}
