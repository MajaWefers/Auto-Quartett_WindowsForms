using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Quartett_WindowsForms
{
    public struct Autokarte
    {
        public string marke;
        public int geschwindigkeit;
        public int leistung;
        public double verbrauch;
        public int zylinder;
        public double hubraum;
        public double beschleunigung;
        public int zuladung;
        public int ladevolumen;
        
        public Autokarte(string marke, int geschwindigkeit, int leistung, double verbrauch,
                  int zylinder, double hubraum, double beschleunigung, int zuladung, int ladevolumen)
        {
            this.marke = marke;
            this.geschwindigkeit = geschwindigkeit;
            this.leistung = leistung;
            this.verbrauch = verbrauch;
            this.zylinder = zylinder;
            this.hubraum = hubraum;
            this.beschleunigung = beschleunigung;
            this.zuladung = zuladung;
            this.ladevolumen = ladevolumen;
        }
        
    }
}
