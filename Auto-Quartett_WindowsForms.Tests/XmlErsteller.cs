using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class XmlErsteller
    {
        //Braucht nur ein mal ausgeführt zu werden (dazu das Attribute von "Ignore" auf "TestMethod" ändern), 
        //um im Projekt "Auto-Quartett_WindowsForms" die Datei mit den vorgegebenen Karten zu erstellen.
        //Anschließend in den Dateieigenschaften "Copy to Output Directory" aktivieren, 
        //damit sie beim Kompilieren im gleichen Ordner landet wie die .exe
        [Ignore]
        public void ErstelleVorgegebeneKarten()
        {
            Autokarte[] kartenZumSpeichern = new[]
            {
                new Autokarte("VW", "Phaeton", "vwphaeton.jpg", 250, 309, 15.7, 12, 6, 6.7, 600, 500),
                new Autokarte("VW", "New Beetle", "vwnewbeetle.jpg", 185, 85, 8.7, 4, 2, 10.9, 419, 527),
                new Autokarte("VW", "Touareg",  "vwtouareg.jpg", 225, 230, 12.2, 10, 4.9, 7.8, 600, 555)
            };

            speichereKarten(kartenZumSpeichern);
        }

        private static void speichereKarten(Autokarte[] kartenZumSpeichern)
        {
            DatenZugriff datenZugriff = new DatenZugriff(@"..\..\..\Auto-Quartett_WindowsForms\VordefinierteKarten.xml");

            datenZugriff.SpeichereKarten(kartenZumSpeichern);
        }
    }
}
