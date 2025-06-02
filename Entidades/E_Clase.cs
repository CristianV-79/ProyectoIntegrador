using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Clase
    {
        //Atributos
        public int IdClase { get; set; }
        public double Precio { get; set; }
        public string Nombre { get; set; }

        public DateTime Horario { get; set; }
        public int CupoMaximo;

        public List<E_Inscripcion> Inscriptos { get; set; } = new List<E_Inscripcion>();

        //Métodos

        public Boolean HayDisponibilidad = true;

        public string hayDisponibilidad() {

            return Inscriptos.Count < CupoMaximo ? "SI" : "NO";
        }
    }
}
