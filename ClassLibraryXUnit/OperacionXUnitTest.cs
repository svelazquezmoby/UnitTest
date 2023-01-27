using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary
{
    public class OperacionXUnitTest
    {
        [Fact]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            //arrange
            Operacion op = new();
            int numero1Test = 50;
            int numero2Test = 10;

            //act
            int resultado = op.SumarNumeros(numero1Test, numero2Test);

            //assert

            Assert.Equal(60, resultado);

        }

        [Theory]
        [InlineData(3, false)]
        [InlineData(5, false)]
        [InlineData(7, false)]


        public void  IsValorPar_InputNumeroImpPar_ReturnFalse(int numeroImpar, bool resultadoesperado)
        {
            Operacion op = new();
            var resultado = op.IsValorPar(numeroImpar);
            //int numeroImpar = 7;
            //bool isPar = op.IsValorPar(numeroImpar);

            //Assert.IsFalse(isPar);

            //Assert.That(isPar, Is.EqualTo(false));
            Assert.Equal(resultadoesperado, resultado);

        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(20)]

        public void IsValorPar_InputNumeroPar_ReturnTrue(int numeroPar)
        {
            Operacion op = new();
            bool isPar = op.IsValorPar(numeroPar);

            Assert.True(isPar);//modelo clasico

          //Assert.Equal(isPar, Is.EqualTo(true));//modelo restricciones


        }

        [Theory]
        [InlineData(2.2,1.2)]//3.4
        [InlineData(2.23,1.24)]//3.47
        public void SumarDecimal_InputDosNumeros_GetValorCorrecto(double decimalTest, double decimal2Test)
        {
            //arrange
            Operacion op = new();
            

            //act
            double resultado = op.SumarDecimal(decimalTest, decimal2Test);

            //assert

            Assert.Equal(3.4, resultado, 0);

        }
    }
}
