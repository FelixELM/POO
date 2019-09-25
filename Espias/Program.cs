using System;

namespace Espias
{

    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            nombre = "Felix";
            apellido = "Molina";
        }

    }

    class Anonimo 
    {
        public static void anonimiza(Persona p)
        {
            p.nombre = "xxxxx";
            p.apellido = "xxxxxxxxxx";
        }

        public static void cambia(ref  Persona p)
        {
            p = new Persona();
            p.nombre = "new";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Console.WriteLine(p.nombre);
            //Anonimo.anonimiza(p);
            Anonimo.cambia(ref p);
            Console.WriteLine(p.nombre);
        }
    }
}
