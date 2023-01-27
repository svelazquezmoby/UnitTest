using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
  
    [TestFixture]
    public class CuentaBancariaNUnitTest
    {
        public CuentaBancaria? cuentaBancaria;
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Deposito_Input_LoggerFalso_True()
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria(new LoggeFalso());
            var resultado = cuentaBancaria.Deposito(100);
            Assert.IsTrue(resultado);
            Assert.That(cuentaBancaria.Getbalance, Is.EqualTo(100));
        }

        [Test]
        public void Deposito_Input_Mocking_True()
        {
            var mocking = new Mock<ILoggerGeneral>();
            CuentaBancaria cuentaBancaria = new CuentaBancaria(mocking.Object);
            var resultado = cuentaBancaria.Deposito(100);
            Assert.IsTrue(resultado);
            Assert.That(cuentaBancaria.Getbalance, Is.EqualTo(100));
        }
    }
}
