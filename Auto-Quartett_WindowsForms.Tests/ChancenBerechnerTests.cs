using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class ChancenBerechnerTests
    {
        private readonly AutokarteDaten[] autos = new[]
        {
            new AutokarteDaten("auto1", "modell", 9, 9, 9, 9, 9, 9, 9, 9),
            new AutokarteDaten("auto2", "modell", 9, 9, 9, 9, 9, 9, 9, 99),
            new AutokarteDaten("auto3", "modell", 99, 9, 9, 9, 9, 9, 9, 1),
            new AutokarteDaten("auto4", "modell", 1, 9, 9, 9, 9, 9, 9, 1)
        };

        [TestMethod]
        public void BerechneGewinnchance_AutoNichtInArray()
        {
            AutokarteDaten eigenesAuto = new AutokarteDaten("auto", "modell", 9, 9, 9, 9, 9, 9, 9, 9);
            this.teste(eigenesAuto, 0, 0.25);
            this.teste(eigenesAuto, 7, 0.5);
        }

        [TestMethod]
        public void BerechneGewinnchance_AutoIstInArray()
        {
            AutokarteDaten eigenesAuto = this.autos[0];
            this.teste(eigenesAuto, 0, 0.333333);
            this.teste(eigenesAuto, 7, 0.666666);
        }

        private void teste(AutokarteDaten eigenesAuto, int vergleichsfeld, double erwarteteGewinnchance)
        {
            //Arrange
            ChancenBerechner chancenBerechner = new ChancenBerechner(new AutokartenVergleich());

            //Act
            double ergebnis = chancenBerechner.BerechneGewinnchance(eigenesAuto, this.autos, vergleichsfeld);

            //Assert
            Assert.AreEqual(erwarteteGewinnchance, ergebnis, 0.00001);
        }
    }
}
