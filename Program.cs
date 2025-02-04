using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonaClase;

namespace Semana02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            Persona p1 = new Persona();
            Persona p2 = new Persona("604740594", "Jorge", 22, "Zamora");
            p2.mostrar();
        }
    }
}
