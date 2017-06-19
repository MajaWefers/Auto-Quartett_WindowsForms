namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient dem Vergleichen zweier <see cref="Autokarte"/>n anhand einer wählbaren Eigenschaft.
    /// Verwendet dazu für jede Eigenschaft eine Instanz von <see cref="VergleichEigenschaft"/>.
    /// </summary>
    public class VergleichAutokarten
    {
        /// <summary>
        /// Beinhaltet für jede zu vergleichende Eigenschaft eine Instanz der Klasse <see cref="VergleichEigenschaft"/>.
        /// Der an den Konstruktor übergebene Lambda-Ausdruck gibt dieser die Möglichkeit, den Wert dieser Eigenschaft
        /// von einer beliebigen <see cref="Autokarte"/> abzurufen.
        /// </summary>
        private readonly VergleichEigenschaft[] eigenschaften = new[]
        {
            new VergleichEigenschaft(karte => karte.geschwindigkeit),
            new VergleichEigenschaft(karte => karte.leistung),
            new VergleichEigenschaft(karte => karte.verbrauch, false),
            new VergleichEigenschaft(karte => karte.zylinder),
            new VergleichEigenschaft(karte => karte.hubraum),
            new VergleichEigenschaft(karte => karte.beschleunigung, false),
            new VergleichEigenschaft(karte => karte.zuladung),
            new VergleichEigenschaft(karte => karte.ladevolumen),
        };

        /// <summary>
        /// Vergleicht den durch <see cref="vergleichsfeld"/> gegebenen Wert zweier Autokarten 
        /// und liefert das Ergebnis aus Sicht von <see cref="auto1"/>.
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        /// <param name="vergleichsfeld"></param>
        /// <returns></returns>
        public VergleichErgebnis Vergleiche(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            //Rufe den zum übergebenen vergleichsfeld passenden EigenschaftVergleich ab,
            //nutze diesen anschließend, um den Vergleich durchzuführen
            VergleichEigenschaft eigenschaftVergleich = this.eigenschaften[vergleichsfeld];
            return eigenschaftVergleich.Vergleiche(auto1, auto2);
        }
    }
}
