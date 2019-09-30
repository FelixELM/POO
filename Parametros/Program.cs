using System;

namespace Parametros
{   
    //Parametro que utiliza el modificardor "ref"
    class Usuario
    {
        public string id;
        public string contraseña;

        public Usuario()
        {
            id = "Enrique Leon";
            contraseña = "Password";
        }

        //Parametro que utiliza el modificador "in"
        public void numero(in int n)
        {
            
        }

        public void viajes(int v)
        {
            v= v-1;
        }
    } 

    class Ocultar
    {
           public static void OcultarContraseña(ref Usuario u)
        {
            u.id = "Enrique Leon";
            u.contraseña = "xxxxxxxxxx";
        }

    } 

    //Parametro que utiliza el mdoificador "out"
    class Camion
    { 
        static public void saldo(int a, int b, out int resultado)
        {
            resultado = a-b;
        }

        static public int saldo(int a, int b)
        {
            return a-b;
        }

    }

    class Program
    {       
        static void Main(string[] args)
        {
            int x = 80;
		    int y = 8;
		    int r; 

		    Camion.saldo(x, y, out r);
        
            Usuario u = new Usuario();
            int z = 19210516;
            int q = 10;
            u.numero(in z);
            u.viajes(q);
            Ocultar.OcultarContraseña(ref u);

            //Imprimir resultados
            Console.WriteLine("Usuario:{0}\n\rContraseña:{1}\n\rNumero de id:{2}\n\rSaldo:{3}\n\rSaldo restante:{4}", u.id, u.contraseña, z, r, q);
        }
    }
}
