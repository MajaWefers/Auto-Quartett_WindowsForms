using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto_Quartett_WindowsForms.Tests
{
    [TestClass]
    public class GewinnChancenBerechnerTests
    {
        private readonly Autokarte[] autos = new[]
        {
            new Autokarte("auto1", "modell", 9, 9, 9, 9, 9, 9, 9, 9),
            new Autokarte("auto2", "modell", 9, 9, 9, 9, 9, 9, 9, 99),
            new Autokarte("auto3", "modell", 99, 9, 9, 9, 9, 9, 9, 1),
            new Autokarte("auto4", "modell", 1, 9, 9, 9, 9, 9, 9, 1)
        };

        [TestMethod]
        public void BerechneGewinnchance_AutoNichtInArray()
        {
            Autokarte eigenesAuto = new Autokarte("auto", "modell", 9, 9, 9, 9, 9, 9, 9, 9);
            this.teste(eigenesAuto, 0, 0.25);
            this.teste(eigenesAuto, 7, 0.5);
        }

        [TestMethod]
        public void BerechneGewinnchance_AutoIstInArray()
        {
            Autokarte eigenesAuto = this.autos[0];
            this.teste(eigenesAuto, 0, 0.333333);
            this.teste(eigenesAuto, 7, 0.666666);
        }

        private void teste(Autokarte eigenesAuto, int vergleichsfeld, double erwarteteGewinnchance)
        {
            //Arrange
            GewinnChancenBerechner chancenBerechner = new GewinnChancenBerechner(new AutokartenVergleich());

            //Act
            double ergebnis = chancenBerechner.BerechneGewinnchance(eigenesAuto, this.autos, vergleichsfeld);

            //Assert
            Assert.AreEqual(erwarteteGewinnchance, ergebnis, 0.00001);
        }
    }
}
