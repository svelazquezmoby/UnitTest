using NLipsum.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [TestFixture]
    public class ClienteNUnitTest
    {
        [Test]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {
            Cliente cliente = new();

            string nombreCompleto = cliente.CrearNombreCompleto("sergio", "velasco");

            Assert.That(nombreCompleto, Is.EqualTo("sergio velasco"));
            Assert.That(nombreCompleto, Does.Contain("ser"));
            Assert.That(nombreCompleto, Does.Contain("ser").IgnoreCase);
            Assert.AreEqual(nombreCompleto, "sergio");
            Assert.That(nombreCompleto, Does.StartWith("sergiovelasco"));
        }
    }
}
