using System;
using Calculadora.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calcula.Domain.Tests
{
    [TestClass]
    public class SomaTests
    {
        [TestMethod]
        public void Soma_Resultado_Correto_A_Soma_De_Inteiros_Positivos()
        {
            var n1 = 3;
            var n2 = 3;
            var sut = new Soma(n1, n2);
            var result = sut.Resultado();

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divisao_Erro_Ao_Dividir_Por_Zero()
        {
            var n1 = 3;
            var n2 = 0;
            var sut = new Divisao(n1, n2);
            var result = sut.Resultado();
        }
    }
}
