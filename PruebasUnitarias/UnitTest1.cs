using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostPruebasUnitarias;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasProcesador
    {
        [TestMethod]
        public void TestSuma()
        {
            //Definimos las variables
            //Arrange
            var operador1 = 10;
            var operador2 = 11;

            //Ejecutamos la prueba
            //Act
            var result = ProcesadorMatematico.Sumar(operador1, operador2);

            //Comparamos resultados
            //Assert
            var valorEsperado = 21;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestDivision1()
        {
            //Definimos las variables
            //Arrange
            var dividendo = 10;
            var divisor = 2;

            //Ejecutamos la prueba
            //Act
            var result = ProcesadorMatematico.Division(dividendo, divisor);

            //Comparamos resultados
            //Assert
            var valorEsperado = 5;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))] //Excepcion esperada
        public void TestDivisionExcepcion()
        {
            //Definimos las variables
            //Arrange
            var dividendo = 10;
            var divisor = 0;

            //Ejecutamos la prueba
            //Act
            var result = ProcesadorMatematico.Division(dividendo, divisor);

            //Comparamos resultados
            //Assert
            //En este caso, no deberiamos llegar aqui, la prueba correcta es una excepcion de DivisionEntreCero
        }
    }
}