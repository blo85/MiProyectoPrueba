using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiProyectoPrueba;


namespace MisTestsUnitarios
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void TestSumar()
        {
            var num1 = 1;
            var num2 = 2;
            
            var resultado = Calculadora.Sumar(num1 ,num2);

            var valorEsperado = 3;
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
