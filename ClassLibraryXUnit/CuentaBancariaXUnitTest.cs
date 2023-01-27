using ClassLibrary;
using moq;
using Moq;
using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;
using Xunit;

namespace classlibrary
{

    public class CuentaBancaria
    {
        private CuentaBancaria cuentaBancaria;
        private loggerfalso loggerfalso;

        public CuentaBancaria(loggerfalso loggerfalso)
        {
            this.loggerfalso = loggerfalso;
        }

        [Fact]
        public void deposito_input_loggerfalso_true()
        {
            //act
            CuentaBancaria cuentabancaria = new CuentaBancaria(new loggerfalso());

            var resultado = cuentabancaria.Deposito(100);
            Assert.True(resultado);
            Assert.Equal(cuentabancaria.getbalance, is.equalto(100));
        }

        [Fact]
        public void deposito_input_mocking_true()
        {
            var mocking = new Mock<iloggergeneral>();
            cuentabancaria cuentabancaria = new cuentabancaria(mocking.object);
            var resultado = cuentabancaria.deposito(100);
            Assert.True(resultado);
            Assert.Equal(cuentabancaria.getbalance, is.equalto(100));
        }
    }
}
