namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient dem Vergleichen zweier <see cref="AutokarteDaten"/>n anhand einer wählbaren Eigenschaft.
    /// Verwendet dazu für jede Eigenschaft eine Instanz von <see cref="SpielVergleichEigenschaft"/>.
    /// </summary>
    public class SpielVergleichAutokarten
    {
        /// <summary>
        /// Beinhaltet für jede zu vergleichende Eigenschaft eine Instanz der Klasse <see cref="SpielVergleichEigenschaft"/>.
        /// Der an den Konstruktor übergebene Lambda-Ausdruck gibt dieser die Möglichkeit, den Wert dieser Eigenschaft
        /// von einer beliebigen <see cref="AutokarteDaten"/> abzurufen.
        /// </summary>
        private readonly SpielVergleichEigenschaft[] eigenschaften = new[]
        {
            new SpielVergleichEigenschaft(karte => karte.geschwindigkeit),
            new SpielVergleichEigenschaft(karte => karte.leistung),
            new SpielVergleichEigenschaft(karte => karte.verbrauch, false),
            new SpielVergleichEigenschaft(karte => karte.zylinder),
            new SpielVergleichEigenschaft(karte => karte.hubraum),
            new SpielVergleichEigenschaft(karte => karte.beschleunigung, false),
            new SpielVergleichEigenschaft(karte => karte.zuladung),
            new SpielVergleichEigenschaft(karte => karte.ladevolumen),
        };

        /// <summary>
        /// Vergleicht den durch <see cref="vergleichsfeld"/> gegebenen Wert zweier Autokarten 
        /// und liefert das Ergebnis aus Sicht von <see cref="auto1"/>.
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        /// <param name="vergleichsfeld"></param>
        /// <returns></returns>
        public SpielVergleichErgebnis Vergleiche(AutokarteDaten auto1, AutokarteDaten auto2, int vergleichsfeld)
        {
            //Rufe den zum übergebenen vergleichsfeld passenden EigenschaftVergleich ab,
            //nutze diesen anschließend, um den Vergleich durchzuführen
            SpielVergleichEigenschaft eigenschaftVergleich = this.eigenschaften[vergleichsfeld];
            return eigenschaftVergleich.Vergleiche(auto1, auto2);
        }
    }
}
