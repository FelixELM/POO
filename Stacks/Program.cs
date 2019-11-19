using System;

namespace Stacks
{
	public class Stack < T >
	{
		readonly int m_Size;
		int m_StackPointer = 0;
		T[] m_Items;
		public Stack() : this(100)
		{}
		public Stack(int size)
		{
			m_Size = size;
			m_Items = new T[m_Size];
		}
		public void Push(T item)
		{
			if (m_StackPointer >= m_Size)
				throw new StackOverflowException();
			m_Items[m_StackPointer] = item;
			m_StackPointer++;
		}
		public T Pop()
		{
			m_StackPointer--;
			if (m_StackPointer >= 0)
			{
				return m_Items[m_StackPointer];
			}
			else
			{
				m_StackPointer = 0;
				throw new InvalidOperationException("Stack vacio");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> lista = new Stack<string>(3);
			lista.Push("onda");
			lista.Push(" ");
			lista.Push("Que");
			//string saludo = lista.Pop();
			/*saludo+=lista.Pop();
			saludo+=lista.Pop();*/
			Console.WriteLine(lista.Pop()+lista.Pop()+lista.Pop());
		}
	}
}
