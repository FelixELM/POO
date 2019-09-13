using System;

namespace Pelicula
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula("Spiderverse", "Estados Unidos", "Phil Lord y Rodney Rothman", "Peter Ramsey, Rodney Rothman y Bob Persichetti", 2018) ;          
            p1.imprime();

            Pelicula p2 = new Pelicula();
            p2.imprime();

        }
    }

    class Pelicula
    {
        private string titulo;
        private string pais;
        private string autor;
        private string director;
        private Int16 año;

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
        
        public void imprime()
        {
            Console.WriteLine("Titulo:{0}\n\r Pais:{1}\n\r Autor:{2}\n\r Director:{3}\n\r Año:{4}", titulo, pais, autor, director, año);
        }   

        public Pelicula(string t, string p, string a, string d, Int16 ñ)
        {     
            this.titulo = t;
            this.pais = p;
            this.autor = a;
            this.director = d;
            this.año = ñ;
        }  

        public Pelicula()
        {
            titulo = "Coco";
            pais = "Estados Unidos";
            autor = "Adrian Molina y Matthew Aldrich";
            director = "Lee Unkrich";
            año = 2017;
        }   
    }
    
}
