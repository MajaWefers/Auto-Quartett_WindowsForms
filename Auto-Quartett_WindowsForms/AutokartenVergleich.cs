namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient dem Vergleichen zweier <see cref="Autokarte"/>n anhand einer wählbaren Eigenschaft.
    /// Verwendet dazu für jede Eigenschaft eine Instanz von <see cref="EigenschaftVergleich"/>.
    /// </summary>
    public class AutokartenVergleich
    {
        /// <summary>
        /// Beinhaltet für jede zu vergleichende Eigenschaft eine Instanz der Klasse <see cref="EigenschaftVergleich"/>.
        /// Der an den Konstruktor übergebene Lambda-Ausdruck gibt dieser die Möglichkeit, den Wert dieser Eigenschaft
        /// von einer beliebigen <see cref="Autokarte"/> abzurufen.
        /// </summary>
        private readonly EigenschaftVergleich[] eigenschaften = new[]
        {
            new EigenschaftVergleich(karte => karte.geschwindigkeit),
            new EigenschaftVergleich(karte => karte.leistung),
            new EigenschaftVergleich(karte => karte.verbrauch, false),
            new EigenschaftVergleich(karte => karte.zylinder),
            new EigenschaftVergleich(karte => karte.hubraum),
            new EigenschaftVergleich(karte => karte.beschleunigung, false),
            new EigenschaftVergleich(karte => karte.zuladung),
            new EigenschaftVergleich(karte => karte.ladevolumen),
        };

        /// <summary>
        /// Vergleicht den durch <see cref="vergleichsfeld"/> gegebenen Wert zweier Autokarten 
        /// und liefert das Ergebnis aus Sicht von <see cref="auto1"/>.
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        /// <param name="vergleichsfeld"></param>
        /// <returns></returns>
        public Vergleichsergebnis Vergleiche(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            //Rufe den zum übergebenen vergleichsfeld passenden EigenschaftVergleich ab,
            //nutze diesen anschließend, um den Vergleich durchzuführen
            EigenschaftVergleich eigenschaftVergleich = this.eigenschaften[vergleichsfeld];
            return eigenschaftVergleich.Vergleiche(auto1, auto2);
        }
    }
}
