namespace Auto_Quartett_WindowsForms
{
    public class AutokartenVergleich
    {
        private readonly EigenschaftVergleich[] eigenschaften = new[]
        {
            new EigenschaftVergleich(karte => karte.geschwindigkeit),
            new EigenschaftVergleich(karte => karte.leistung),
            new EigenschaftVergleich(karte => karte.verbrauch, false),
            new EigenschaftVergleich(karte => karte.zylinder),
            new EigenschaftVergleich(karte => karte.hubraum),
            new EigenschaftVergleich(karte => karte.beschleunigung),
            new EigenschaftVergleich(karte => karte.zuladung),
            new EigenschaftVergleich(karte => karte.ladevolumen),
        };

        public Ergebnis Vergleiche(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            return this.eigenschaften[vergleichsfeld].Vergleiche(auto1, auto2);
        }
    }
}
