using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cliente
    {
        public bool IsPremium { get; set; }

        public string CrearNombreCompleto(string nombre, string apellido)
        {
            return $"{nombre} {apellido}";    

        }
        public Cliente()
        {
            IsPremium = false;
        }
    }
}
