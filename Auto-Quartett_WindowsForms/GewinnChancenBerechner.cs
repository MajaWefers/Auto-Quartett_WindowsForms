namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Dient der Berechnung der durchschnittlichen Gewinnchance einer <see cref="Autokarte"/> gegen alle anderen
    /// Karten im Spiel.
    /// </summary>
    public class GewinnChancenBerechner
    {
        private readonly AutokartenVergleich vergleich;

        public GewinnChancenBerechner(AutokartenVergleich vergleich)
        {
            this.vergleich = vergleich;
        }

        /// <summary>
        /// Berechnet die Gewinnchance von <see cref="auto"/> gegen die anderen Karten in
        /// <see cref="autosImSpiel"/> bei Auswahl des übergebenen <see cref="vergleichsfeld"/>.
        /// <see cref="auto"/> kann in <see cref="autosImSpiel"/> enthalten sein oder auch nicht.
        /// </summary>
        /// <param name="auto"></param>
        /// <param name="autosImSpiel"></param>
        /// <param name="vergleichsfeld"></param>
        /// <returns></returns>
        public double BerechneGewinnchance(Autokarte auto, Autokarte[] autosImSpiel, int vergleichsfeld)
        {
            int anzahlAndererAutos = 0;
            int anzahlUnterlegenerAutos = 0;

            //Durchlaufe die übergebenen autosImSpiel
            for (int i = 0; i < autosImSpiel.Length; i++)
            {
                //Ignoriere dabei die übergebene Autokarte, da sie im Spiel nicht gegen sich selbst antreten kann
                if (!auto.Equals(autosImSpiel[i]))
                {
                    anzahlAndererAutos++;
                    if (this.gewinntAuto1(auto, autosImSpiel[i], vergleichsfeld))
                    {
                        anzahlUnterlegenerAutos++;
                    }
                }
            }

            //Gewinnchance = Anteil der Karten, gegen die auto gewinnt, an allen anderen Karten
            return (double) anzahlUnterlegenerAutos / anzahlAndererAutos;
        }

        /// <summary>
        /// Liefert true, falls <see cref="auto1"/> bei dem übergebenen <see cref="vergleichsfeld"/>
        /// gegen <see cref="auto2"/> gewinnt.
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        /// <param name="vergleichsfeld"></param>
        /// <returns></returns>
        private bool gewinntAuto1(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            Vergleichsergebnis vergleichsErgebnis = this.vergleich.Vergleiche(auto1, auto2, vergleichsfeld);
            return vergleichsErgebnis == Vergleichsergebnis.Gewinn;
        }
    }
}
