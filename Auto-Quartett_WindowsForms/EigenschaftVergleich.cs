using System;

namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient dem Vergleich zweier <see cref="AutokarteDaten"/>n anhand einer festgelegten Eigenschaft.
    /// </summary>
    public class EigenschaftVergleich
    {
        private readonly Func<AutokarteDaten, double> eigenschaftZugriff;
        private readonly bool groesserGewinnt;

        /// <summary>
        /// Beim Erstellen einer Instanz dieser Klasse wird festgelegt, wie jeder zukünftige Vergleich abläuft.
        /// <see cref="eigenschaftZugriff"/> ist ein Delegat, der für eine übergebene <see cref="AutokarteDaten"/>
        /// den Wert eines bestimmten Felds als <see cref="double"/> zurückgibt. Dieser Wert wird mit dem 
        /// entsprechenden Wert einer zweiten <see cref="AutokarteDaten"/> verglichen.
        /// <see cref="groesserGewinnt"/> gibt an, ob die Karte mit dem größeren oder die mit dem kleineren Wert gewinnt.
        /// </summary>
        /// <param name="eigenschaftZugriff"></param>
        /// <param name="groesserGewinnt"></param>
        public EigenschaftVergleich(Func<AutokarteDaten, double> eigenschaftZugriff, bool groesserGewinnt = true)
        {
            this.eigenschaftZugriff = eigenschaftZugriff;
            this.groesserGewinnt = groesserGewinnt;
        }

        /// <summary>
        /// Vergleicht zwei <see cref="AutokarteDaten"/>n anhand der Eigenschaft, 
        /// die beim Erstellen dieses Objekts festgelegt wurde.
        /// Das Ergebnis ist aus der Sicht von <see cref="auto1"/>
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        /// <returns></returns>
        public Ergebnis Vergleiche(AutokarteDaten auto1, AutokarteDaten auto2)
        {
            //Lese den Wert der zu vergleichenden Eigenschaft der beiden Karten aus
            double wert1 = this.eigenschaftZugriff(auto1);
            double wert2 = this.eigenschaftZugriff(auto2);

            //Vergleiche diese Werte und gebe einen der 3 Möglichen Werte des Ergebnis enums zurück
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
