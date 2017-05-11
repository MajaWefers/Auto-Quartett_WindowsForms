using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class DatenZugriffTests
    {
        [TestMethod]
        public void LadeKartenTest()
        {
            //Arrange
            DatenZugriff datenZugriff = new DatenZugriff(@"..\..\TestDateien\TestKartenDatei.xml");

            //Act
            Autokarte[] ergebnis = datenZugriff.LadeKarten();

            //Assert
            Assert.IsNotNull(ergebnis);
            Assert.AreEqual(2, ergebnis.Length);
            Assert.AreEqual("Mini", ergebnis[0].modell);
            Assert.AreEqual(3, ergebnis[0].verbrauch);
            Assert.AreEqual(8, ergebnis[0].ladevolumen);
            Assert.AreEqual(123, ergebnis[1].geschwindigkeit);
        }

        [TestMethod]
        public void SpeichereKartenTest()
        {
            //Arrange
            string dateiPfad = Path.Combine(Path.GetTempPath(), "SchreibTest.xml");
            DatenZugriff datenZugriff = new DatenZugriff(dateiPfad);
            Autokarte[] kartenZumSpeichern = new[]
            {
                new Autokarte("Smart", 1, 2, 3, 4, 5, 6, 7, 8),
                new Autokarte("bla", 1, 2, 3, 4, 5, 6, 7, 8)
            };
            string erwarteterDateiInhalt = File.ReadAllText(@"..\..\TestDateien\ErwarteteKartenDatei.xml");

            //Act
            datenZugriff.SpeichereKarten(kartenZumSpeichern);

            //Assert
            string tatsächlicherDateiInhalt = File.ReadAllText(dateiPfad);
            Assert.AreEqual(erwarteterDateiInhalt, tatsächlicherDateiInhalt);

            //Clean up
            File.Delete(dateiPfad);
        }

        //Braucht nur ein mal ausgeführt zu werden (dazu das Attribute von "Ignore" auf "TestMethod" ändern), 
        //um im Projekt "Auto-Quartett_WindowsForms" die Datei mit den vorgegebenen Karten zu erstellen.
        //Anschließend in den Dateieigenschaften "Copy to Output Directory" aktivieren, 
        //damit sie beim Kompilieren im gleichen Ordner landet wie die .exe
        [Ignore]
        public void ErstelleVorgegebeneKarten()
        {
            string dateiPfad = Path.Combine(@"..\..\..\Auto-Quartett_WindowsForms\VordefinierteKarten.xml");
            DatenZugriff datenZugriff = new DatenZugriff(dateiPfad);
            Autokarte[] kartenZumSpeichern = new[]
            {
                new Autokarte("VW Phaeton", 250, 309, 15.7, 12, 6, 6.7, 600, 500),
                new Autokarte("VW New Beetle", 185, 85, 8.7, 4, 2, 10.9, 419, 527),
                new Autokarte("VW Touareg", 225, 230, 12.2, 10, 4.9, 7.8, 600, 555)
            };

            datenZugriff.SpeichereKarten(kartenZumSpeichern);
        }
    }
}
