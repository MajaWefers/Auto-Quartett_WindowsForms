namespace Auto_Quartett_WindowsForms
{
    public class ChancenBerechner
    {
        private readonly AutokartenVergleich vergleich;

        public ChancenBerechner(AutokartenVergleich vergleich)
        {
            this.vergleich = vergleich;
        }

        public double BerechneGewinnchance(Autokarte auto, Autokarte[] autosImSpiel, int vergleichsfeld)
        {
            int anzahlAndererAutos = 0;
            int anzahlUnterlegenerAutos = 0;

            for (int i = 0; i < autosImSpiel.Length; i++)
            {
                if (!auto.Equals(autosImSpiel[i]))
                {
                    anzahlAndererAutos++;
                    if (this.gewinntAuto1(auto, autosImSpiel[i], vergleichsfeld))
                    {
                        anzahlUnterlegenerAutos++;
                    }
                }
            }

            return (double) anzahlUnterlegenerAutos / anzahlAndererAutos;
        }

        private bool gewinntAuto1(Autokarte auto1, Autokarte auto2, int vergleichsfeld)
        {
            Ergebnis vergleichsErgebnis = this.vergleich.Vergleiche(auto1, auto2, vergleichsfeld);
            return vergleichsErgebnis == Ergebnis.Gewinn;
        }
    }
}
