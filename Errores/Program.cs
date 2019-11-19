using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int valor;
            Console.WriteLine("Ingrese su edad");
            string captura = Console.ReadLine();
            //Console.WriteLine(captura);
            //Console.RedKey();
            valor = int.Parse(captura);
            Console.WriteLine("En diez años tendras {0}", 100/valor);
            Console.ReadKey();
            try 
            {
                string Captura = Console.ReadLine();
                //int valor = int.Parse(Captura);
                Console.WriteLine("En dien años tendras{0}",valor+10
                );
            }
            
            catch(FormatException)
            {
                Console.WriteLine("Formato incorrecto");
            }
            
            catch(DivideByZeroException)
            {
                Console.WriteLine("Formato dividio entre 0 es incorrecto");
            }

            Console.ReadKey();


        }
    }
}
