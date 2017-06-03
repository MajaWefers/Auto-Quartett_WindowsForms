using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class XmlErsteller
    {
        //Braucht nur ein mal ausgeführt zu werden (dazu das Attribute von "Ignore" auf "TestMethod" ändern), 
        //um im Projekt "Auto-Quartett_WindowsForms" die Datei mit den vorgegebenen Karten zu erstellen.
        //In den Dateieigenschaften muss "Copy to Output Directory" aktiviert sein, 
        //damit sie beim Kompilieren im gleichen Ordner kommt wie die .exe
        [Ignore]
        public void ErstelleVorgegebeneKarten()
        {
            Autokarte[] kartenZumSpeichern = new[]
            {
                new Autokarte("VW", "Phaeton", 250, 309, 15.7, 12, 6, 6.7, 600, 500),
                new Autokarte("VW", "New Beetle", 185, 85, 8.7, 4, 2, 10.9, 419, 527),
                new Autokarte("VW", "Touareg", 225, 230, 12.2, 10, 4.9, 7.8, 600, 555),
                new Autokarte("Nissan","GT-R", 315, 404, 11.8, 6, 3.8, 2.8, 385, 315),
                new Autokarte("BMW", "X1", 205, 110, 4.5, 4,2, 9.2, 585, 505),
                new Autokarte("Renault", "Megane", 190, 74, 5.4, 4, 1.6, 12.3, 472, 1162)
            };

            speichereKarten(kartenZumSpeichern);
        }

        private static void speichereKarten(Autokarte[] kartenZumSpeichern)
        {
            DatenZugriff datenZugriff = new DatenZugriff(@"..\..\..\Auto-Quartett_WindowsForms\Karten.xml");

            datenZugriff.SpeichereKarten(kartenZumSpeichern);
        }
    }
}
