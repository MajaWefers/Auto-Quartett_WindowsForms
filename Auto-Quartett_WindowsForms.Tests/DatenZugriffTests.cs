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
            AutokarteDaten[] ergebnis = datenZugriff.LadeKarten();

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
            AutokarteDaten[] kartenZumSpeichern = new[]
            {
                new AutokarteDaten("Smart", "bla" , 1, 2, 3, 4, 5, 6, 7, 8),
                new AutokarteDaten("bla", "blabla" , 1, 2, 3, 4, 5, 6, 7, 8)
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
    }
}
