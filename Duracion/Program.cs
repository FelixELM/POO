using System;

namespace Duracion
{
    class Duracion
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
        }

        public void print()
        {
            Console.WriteLine("Horas:{0} Minutos:{1} Segundo:{2}", horas, minutos, segundos);
        }

        public void Segundos()
        {
            int totalsegundos;
            totalsegundos = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine("Segundos totales:{0}", totalsegundos);
        }

        public void Minutos()
        {
            int totalminutos;
            totalminutos = (horas * 60) + minutos;
            Console.WriteLine("Minutos totales:{0}", totalminutos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion d = new Duracion(2,45,15);
            d.print();
            d.Segundos();
            d.Minutos();

        }
    }
}
