﻿using System;

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

        public Duracion(int s)
        {
             horas = (int) s/3600;
             minutos = (int) (s-(horas*3600))/60;
             segundos = (int) (s-(horas*3600))-(minutos*60);
        }

        public void print()
        {
            Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
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
            Console.WriteLine("Minutos totales:{0}\r\n", totalminutos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion a = new Duracion(2,15,12);
            Duracion b = new Duracion(0,2,15);
            Duracion c = new Duracion(2,0,10);
            Duracion d = new Duracion(7210);

            a.print();
            a.Segundos();
            a.Minutos();

            b.print();
            b.Segundos();
            b.Minutos();

            c.print();
            c.Segundos();
            c.Minutos();
            

            d.print();
        }
    }
}
