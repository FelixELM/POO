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
        static int suma(int x, int y)
        {
            return x+y;
        }

        static void duplica (ref int x)
        {
            x = x * 2;
        }

        static void suma (int x, int y, out int resultado)
        {
            resultado = x+y;
        }
       
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int r = suma(a,b);
            int r2;
            suma(a,b, out r2);

            //duplica(ref a)
            Console.WriteLine(r);

          
            /*Persona p = new Persona();
            Console.WriteLine(p.nombre);
            Anonimo.anonimiza(p);
            Anonimo.cambia(ref p);
            Console.WriteLine(p.nombre);*/
        }
    }
}
