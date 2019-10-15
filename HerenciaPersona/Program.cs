using System;

namespace HerenciaPersona
{
    class Persona 
    {
        //Protected es para poner poner privado y poder heredar
        protected string nombre;
        public string Nombre
        { 
            get{return nombre;} 
        }

        public Persona(string n)
        {
            nombre = n;
        }

        public void print()
        {
            Console.WriteLine("Mi nombre es {0}", nombre);
        }
    }

    class Alumno : Persona
    {
        protected string num_control;

        //base se usa para utilizar el constructor de la clase base
        public Alumno(string Nombre, string num_control): base(Nombre)
        {
            this.num_control = num_control;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona tom = new Persona("Tom");
            Persona jim = new Persona("Jim");

            tom.print();
            jim.print();
            
            Alumno luis = new Alumno("Luis", "19210516");
            luis.print();

        }
    }
}
