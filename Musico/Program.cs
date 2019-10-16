using System;
using System.Collections.Generic;

namespace Musico
{
	class Musico
	{
		protected string nombre;

		public Musico(string n)
		{
			nombre = n;						             
		}

		//Virtual permite remplazar su propio metodo por medio de herencia
		public virtual void Afina()
		{
			Console.WriteLine("{0} afina su instrumento", nombre);
		}

		public virtual string Saluda()
		{
			return String.Format("Hola soy {0}", nombre);
		}
	}

	class Bajista:Musico
	{
		private string bajo;
		
		public Bajista(string no, string b):base(no)
		{
			bajo = b;

		}

		//Override es para remplezar el metodo		
		public override void Afina()
		{
			Console.WriteLine("{0} afina su {1}", nombre, bajo);
		}
		
		public override string Saluda()
		{
			return base.Saluda() + " y soy bajista";
		}
	}
	
	class Guitarrista:Musico
	{
		private string guitarra;

		public Guitarrista(string no, string g):base(no)
		{
			guitarra = g;
		}

		public override void Afina()
		{
			Console.WriteLine("{0} afiando su {1}", nombre, guitarra);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Musico tom = new Musico("Tom");
			Bajista flea = new Bajista("Flea", "Gibson");
			//Console.WriteLine(tom.Saluda());
			Guitarrista felix = new Guitarrista("Felix","Yamaha");
			/*tom.Saluda();
			tom.Afina();
			flea.Saluda();
			flea.Afina();*/
			List<Musico> grupo = new List<Musico>();
			grupo.Add(tom);
			grupo.Add(flea);
			grupo.Add(felix);
			foreach(Musico m in grupo)
			{
				Console.WriteLine(m.Saluda());
				m.Afina();
			}
 		}
	}
}
