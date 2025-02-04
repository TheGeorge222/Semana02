using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaClase
{
    class Persona
    {
        private string varCedula { get; set; }
        private string varNombre { get; set; }
        private int varEdad { get; set; }
        private string varApellido { get; set; }

        // constructor por parametros

        public Persona(string pCedula, string pNombre, int pEdad, string pApellido)
        {
            this.varCedula = pCedula;
            this.varApellido = pApellido;
            this.varEdad = pEdad;
            this.varNombre = pNombre;
            Console.WriteLine("Se creo una Persona Por Parametros");
        }
        // construcotr sin parametros 
        public Persona()
        {
            this.varApellido = "";
            this.varCedula = "";
            this.varEdad = 0;
            this.varNombre = "";
            Console.WriteLine("se creo una Persona sin parametros ");


        }

        public void mostrar()
        {
            Console.WriteLine("+++++++ Datos de la Perosna +++++++");
            Console.WriteLine($"        Nombre: { this.varNombre} ");
            Console.WriteLine($"        Apellidos: {this.varApellido}");
            Console.WriteLine($"        Edad: {this.varEdad}");
            Console.WriteLine($"        Cedula: {this.varCedula}");
        }
        public string resturnoStr()
        {
            return "";
        }

        public int returnoInt()
        {
            return 0;

        }

        public bool returnoBool()
        {
           return true ;
        }
        public float returnoFloat()
        {
            return 0;
        }

        public Double returnoDouble()
        {
            return 0;
        }







    }














}
   
