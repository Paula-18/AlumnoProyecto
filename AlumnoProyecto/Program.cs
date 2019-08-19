using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matrícula: " + alumno1.Matricula);

            Console.Read();
        }
    }
}
