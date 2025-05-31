using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Socio : E_Persona
    {
        public int CodSoc { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; } // true = activo, false = inactivo
    }
}
