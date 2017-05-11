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
    }
}
