using System;
using System.Collections.Generic;

namespace Persona2
{
    class Persona:IComparable
    {
     int id;
     string nombre;

        public Int32 CompareTo(Object o)
        {
            return this.id.CompareTo(((Persona)o).id);
        }

        /*public String CompareTo(Object o)
        {
            return this.nombre.CompareTo(((Persona)o).id);
        }*/

        public Persona(int id, string n)
     {
         this.id=id;
         nombre=n;
     } 

     public override string ToString()
     {
         return String.Format("{0},{1}", id, nombre);
     }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers = new List<Persona>();
                pers.Add(new Persona(2,"Pablo"));
                pers.Add(new Persona(1,"Cesar"));
                pers.Add(new Persona(3,"Felix"));
                Console.WriteLine("Lista");
            foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Lista ordenada.");
            pers.Sort();
               foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }

            
        }
    }
}
