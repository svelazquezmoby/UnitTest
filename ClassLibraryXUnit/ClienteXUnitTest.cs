
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary
{
    public class ClienteXUnitTest
    {
        [Fact]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {
            Cliente cliente = new();

            string nombreCompleto = cliente.CrearNombreCompleto("sergio", "velasco");

            Assert.Contains("sergio velasco", nombreCompleto);
            //Assert.Equal(nombreCompleto, Does.Contain("ser"));
            //Assert.Equal(nombreCompleto, Does.Contain("ser").IgnoreCase);
            //Assert.Equal(nombreCompleto, "sergio");
            Assert.StartsWith("sergiovelasco" , nombreCompleto);
        }
    }
}
