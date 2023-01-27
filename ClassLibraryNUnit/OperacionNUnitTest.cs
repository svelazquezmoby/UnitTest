using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        [Test]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            //arrange
            Operacion op = new();
            int numero1Test = 50;
            int numero2Test = 10;

            //act
            int resultado = op.SumarNumeros(numero1Test, numero2Test);

            //assert

            Assert.AreEqual(60, resultado);

        }

        [Test]
        [TestCase(3, ExpectedResult  = false)]
        [TestCase(5, ExpectedResult  = false)]
        [TestCase(7, ExpectedResult  = false)]


        public bool IsValorPar_InputNumeroImpPar_ReturnFalse(int numeroImpar)
        {
            Operacion op = new();
            //int numeroImpar = 7;
            //bool isPar = op.IsValorPar(numeroImpar);

            //Assert.IsFalse(isPar);

            //Assert.That(isPar, Is.EqualTo(false));
            return op.IsValorPar(numeroImpar);

        }

        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(20)]

        public void IsValorPar_InputNumeroPar_ReturnTrue(int numeroPar)
        {
            Operacion op = new();
            bool isPar = op.IsValorPar(numeroPar);

            Assert.IsTrue(isPar);//modelo clasico

            Assert.That(isPar, Is.EqualTo(true));//modelo restricciones


        }

        [Test]
        [TestCase(2.2,1.2)]//3.4
        [TestCase(2.23,1.24)]//3.47
        public void SumarDecimal_InputDosNumeros_GetValorCorrecto(double decimalTest, double decimal2Test)
        {
            //arrange
            Operacion op = new();
            

            //act
            double resultado = op.SumarDecimal(decimalTest, decimal2Test);

            //assert

            Assert.AreEqual(3.4, resultado, 0.1);

        }
    }
}
