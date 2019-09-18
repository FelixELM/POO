using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Spiderverse");
            p1.SetAño(2018);
            p1.AgregarActor(new Actor("Jake Johnson", 1978));
			p1.AgregarActor(new Actor("Hailee Steinfeld", 1996));
            p1.Imprime();
            p1.ImprimeActores();

            Pelicula p2 = new Pelicula();           
            p2.Imprime();

            List<Pelicula> peliculas = new List<Pelicula>();          
            peliculas.Add(new Pelicula ("Venom", 2018));
            peliculas.Add(new Pelicula ("Spider-man: Homecoming", 2017));
            peliculas.Add(new Pelicula ("Spider-man: Far for home", 2019));
            peliculas.Add(new Pelicula ("The Amazing Spiderman", 2012));
            peliculas.Add(new Pelicula ("The Amazing Spiderman 2: Rise of electro",2014));
            
            foreach(Pelicula p in peliculas)
            {
                p.Imprime();
            }


        }
    }

    class Pelicula
    {
        private string titulo;
        private string pais;
        private string autor;
        private string director;
        private Int16 año;
        private List<Actor> actores = new List<Actor>();

        public void SetTitulo(string t)
        {
            titulo = t;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetPais(string p)
        {
            pais = p;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetAutor(string a)
        {
            autor = a;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetDirector(string d)
        {
            director = d;
        }

        public string GetDirector()
        {
            return director;
        }

        public void SetAño(Int16 ñ)        
        {
            año = ñ;
        }

        public Int16 GetAño()
        {
            return año;
        }
        
        public void Imprime()
        {
            Console.WriteLine("Titulo:{0}\n\r Año:{1}", this.titulo, this.año);
        }   

        public Pelicula(string t, Int16 ñ)
        {
            this.titulo = t;
            this.año = ñ;
        }       

        public Pelicula()
        {
            this.titulo = "coco";
            this.año = 2017;
        }
        public void AgregarActor(Actor actor) 
        {
			actores.Add(actor);
		}
        public void ImprimeActores() 
        {
			Console.WriteLine("Actores:");
            foreach(Actor actor in actores)               
			    Console.WriteLine("{0} ({1})", actor.Nombre, actor.AñoNacimiento);
		}
        
    }

    class Actor
    {
        public string Nombre;
        public Int16 AñoNacimiento;

        public Actor(string Nombre, Int16 AñoNacimiento)
        {
            this.Nombre = Nombre;
            this.AñoNacimiento = AñoNacimiento;
        }      
    }
    
}
