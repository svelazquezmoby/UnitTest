using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMSTest
{
    [TestClass]
    public class OperacionMSTest
    {
        [TestMethod]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            //arrange
            Operacion op = new();
            int numero1Test = 50;
            int numero2Test = 10;

            //act
            int resultado= op.SumarNumeros(numero1Test, numero2Test);   

            //assert

            Assert.AreEqual(60,resultado);

        }
    }
}
