using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class AutokartenVergleichTests
    {
        private readonly AutokarteDaten auto1 = new AutokarteDaten("auto1", "modell", 199, 555, 9.9, 6, 1.99, 9.8, 555, 1110);
        private readonly AutokarteDaten auto2 = new AutokarteDaten("auto2", "modell", 198, 55, 10, 6, 1.99, 9.9, 1555, 1111);

        [TestMethod]
        public void VergleicheTests()
        {
            this.testeVergleich(0, Ergebnis.Gewinn);
            this.testeVergleich(1, Ergebnis.Gewinn);
            this.testeVergleich(2, Ergebnis.Gewinn);
            this.testeVergleich(3, Ergebnis.Gleichstand);
            this.testeVergleich(4, Ergebnis.Gleichstand);
            this.testeVergleich(5, Ergebnis.Niederlage);
            this.testeVergleich(6, Ergebnis.Niederlage);
            this.testeVergleich(7, Ergebnis.Niederlage);
        }

        private void testeVergleich(int vergleichsfeld, Ergebnis erwartetesErgebnis)
        {
            //Arrange
            AutokartenVergleich autokartenVergleich = new AutokartenVergleich();

            //Act
            Ergebnis ergebnis = autokartenVergleich.Vergleiche(this.auto1, this.auto2, vergleichsfeld);

            //Assert
            Assert.AreEqual(erwartetesErgebnis, ergebnis);
        }
    }
}
