﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class AutokarteDateiZugriffTests
    {
        [TestMethod]
        public void LadeKartenTest()
        {
            //Arrange
            AutokartenDateiZugriff datenZugriff = new AutokartenDateiZugriff(@"..\..\TestDateien\TestKartenDatei.xml");

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
            AutokartenDateiZugriff datenZugriff = new AutokartenDateiZugriff(dateiPfad);
            Autokarte[] kartenZumSpeichern = new[]
            {
                new Autokarte("Smart", "bla" , 1, 2, 3, 4, 5, 6, 7, 8),
                new Autokarte("bla", "blabla" , 1, 2, 3, 4, 5, 6, 7, 8)
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
