using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [TestFixture]
    public class ProductoNUnitTest
    {
        [Test]
        public void GetPrecio_PremiumCliente_ReturnsPrecio()
        {
            Producto producto = new Producto
            {
                Precio = 50
            };

            var resultado = producto.GetPrecio(new Cliente { IsPremium = true });

            Assert.That(resultado, Is.EqualTo(40));

        }
    }

}

