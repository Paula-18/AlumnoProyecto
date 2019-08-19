using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoProyecto
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumno(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

        public Alumno()
        {
            Nombre = "Pendiente";
            Matricula = "Sin asignar";
        }
    }
}
