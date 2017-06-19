using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class AutokartenVergleichTests
    {
        private readonly Autokarte auto1 = new Autokarte("auto1", "modell", 199, 555, 9.9, 6, 1.99, 9.8, 555, 1110);
        private readonly Autokarte auto2 = new Autokarte("auto2", "modell", 198, 55, 10, 6, 1.99, 9.9, 1555, 1111);

        [TestMethod]
        public void VergleicheTests()
        {
            this.testeVergleich(0, Vergleichsergebnis.Gewinn);
            this.testeVergleich(1, Vergleichsergebnis.Gewinn);
            this.testeVergleich(2, Vergleichsergebnis.Gewinn);
            this.testeVergleich(3, Vergleichsergebnis.Gleichstand);
            this.testeVergleich(4, Vergleichsergebnis.Gleichstand);
            this.testeVergleich(5, Vergleichsergebnis.Niederlage);
            this.testeVergleich(6, Vergleichsergebnis.Niederlage);
            this.testeVergleich(7, Vergleichsergebnis.Niederlage);
        }

        private void testeVergleich(int vergleichsfeld, Vergleichsergebnis erwartetesErgebnis)
        {
            //Arrange
            AutokartenVergleich autokartenVergleich = new AutokartenVergleich();

            //Act
            Vergleichsergebnis ergebnis = autokartenVergleich.Vergleiche(this.auto1, this.auto2, vergleichsfeld);

            //Assert
            Assert.AreEqual(erwartetesErgebnis, ergebnis);
        }
    }
}
