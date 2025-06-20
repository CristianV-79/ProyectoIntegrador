using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    internal class E_NoSocio : E_Persona
    {
        public int CodNoSoc { get; set; }
        public DateTime FechaAlta { get; set; }
        public int NSolic { get; set; }
    }
        
}
