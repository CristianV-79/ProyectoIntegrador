using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string Dni;
        public List<E_Clase> HorariosAsignados { get; set; }
        public List<DateTime> AsistenciaMensual;
        public double SueldoMensual { get; set; }
    }
}
