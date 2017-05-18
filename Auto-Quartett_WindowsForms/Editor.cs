using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }
        Autokarte eintrag = new Autokarte();
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            
            eintrag.marke = tbName.Text;
            eintrag.geschwindigkeit = Int32.Parse(tbGeschwindigkeit.Text);
            eintrag.leistung = Int32.Parse(tbLeistung.Text);
            eintrag.verbrauch = Double.Parse(tbVerbrauch.Text);
            eintrag.zylinder = Int32.Parse(tbZylinder.Text);
            eintrag.hubraum = Double.Parse(tbHubraum.Text);
            eintrag.beschleunigung = Double.Parse(tbBeschleunigung.Text);
            eintrag.zuladung = Int32.Parse(tbZuladung.Text);
            eintrag.ladevolumen = Int32.Parse(tbLadevolumen.Text);

            this.RefreshView();
        }
        private void RefreshView()
        {
            tbName.Text = "";
            tbGeschwindigkeit.Text = "";
            tbLeistung.Text = "";
            tbVerbrauch.Text = "";
            tbZylinder.Text = "";
            tbHubraum.Text = "";
            tbBeschleunigung.Text = "";
            tbZuladung.Text = "";
            tbLadevolumen.Text = "";

            //foreach (var eintrag)
            //{
            // System.Windows.Forms.ListViewItem lvItem = new ListViewItem();
            // lvItem.SubItems.Add(eintrag.name);
            // lvItem.SubItems.Add(eintrag.geschwindigkeit.ToString());
            // lvItem.SubItems.Add(eintrag.leistung.ToString());
            // lvItem.SubItems.Add(eintrag.verbrauch.ToString());
            // lvItem.SubItems.Add(eintrag.zylinder.ToString());
            // lvItem.SubItems.Add(eintrag.hubraum.ToString());
            // lvItem.SubItems.Add(eintrag.beschleunigung.ToString());
            // lvItem.SubItems.Add(eintrag.zuladung.ToString());
            // lvItem.SubItems.Add(eintrag.ladevolumen.ToString());

            //}

        }
    }
}
