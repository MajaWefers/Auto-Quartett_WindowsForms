using System;

namespace Auto_Quartett_WindowsForms
{
    public class EigenschaftVergleich
    {
        private readonly Func<Autokarte, double> eigenschaftZugriff;
        private readonly bool groesserGewinnt;

        public EigenschaftVergleich(Func<Autokarte, double> eigenschaftZugriff, bool groesserGewinnt = true)
        {
            this.eigenschaftZugriff = eigenschaftZugriff;
            this.groesserGewinnt = groesserGewinnt;
        }

        public Ergebnis Vergleiche(Autokarte auto1, Autokarte auto2)
        {
            double wert1 = this.eigenschaftZugriff(auto1);
            double wert2 = this.eigenschaftZugriff(auto2);

            if (wert1 == wert2)
            {
                return Ergebnis.Gleichstand;
            }
            else if (this.groesserGewinnt == (wert1 > wert2))
            {
                return Ergebnis.Gewinn;
            }
            else
            {
                return Ergebnis.Niederlage;
            }
        }
    }
}
