using System;
using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpuestosTest
{
    /*
        ** Obtener el IVA a partir del monnto de una reserva
        ** Obtener el impuesto sobre hospedaje a partir del monto de una reserva
        ** Obtener el monto total de la reserva
    */
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550);

            //Assert
            // iva = 16%, montoReserva = 1550
            // 1550 * .16 = 248.00
            Assert.AreEqual(248.00m, iva);


        }

        [TestMethod]
        public void ISHTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            // ish = montoReserva * proncentajeIsh = 46.5
            Assert.AreEqual(46.5m, ish);
        }

        [TestMethod]
        public void MontoTotal()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550);
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);
            decimal total = ci.ObtenerTotal(1550.00m, ish, iva);


            //Assert
            // total = 248.00 + 46.5 +1550.00m = 1844.5
            Assert.AreEqual(1844.5m, total);
        }

    }
}
