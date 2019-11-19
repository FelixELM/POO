using System;
using System.Collections.Generic;

namespace Figura
{
    class Figura
    {
        protected int ancho, largo;
        protected int px,py;
        protected string color_relleno, color_borde;
        //public abstract void Dibuja();
        public Figura(int ancho, int largo, int px, int py, string color_relleno, string color_borde)
        {
            this.ancho = ancho;
            this.largo = largo;
            this.px = px;
            this.py = py;
            this.color_relleno = color_relleno;
            this.color_borde = color_borde;
        }
    }
    
    class Rectangulo:Figura
    {
        public Rectangulo(int a, int l, int pox, int poy, string cr, string cb):base(a, l, pox, poy, cr, cb)
        {

        }

        /*public override void Dibuja()
        {
            Console.WriteLine("Se dibuja en rect color{0} en X:{1} y Y{2}", color_relleno, px, py);
        }*/
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura(10,10);
            List<Figura> figuras = new List<Figura>();
           // figuras.Add(new Rectangulo());
        }
    }
}
