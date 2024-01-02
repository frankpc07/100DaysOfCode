using System;
using System.Collections.Generic;
using System.Text;

namespace PilasAndColas
{
	class Pila
	{
		private Nodo Primero = new Nodo();

		public Pila()
		{
			Primero = null;
		}

		public void insertarNodo()
		{
			Nodo Nuevo = new Nodo();

			Console.Write(" Ingrese el dato que contendrá el nuevo Nodo: ");
			Nuevo.Dato = int.Parse(Console.ReadLine());

			Nuevo.Siguiente = Primero;
			Primero = Nuevo;

			Console.WriteLine("\n Nodo ingresado\n\n");
		}

		public void desplegarPila()
		{
			Nodo Actual = new Nodo();
			Actual = Primero;

			if(Primero != null)
			{
				while (Actual != null)
				{
					Console.WriteLine(" " + Actual.Dato);
					Actual = Actual.Siguiente;
				}
			}
			else
			{
				Console.WriteLine("\n La Pila se encuentra vacía\n\n");
			}
		}
	}
}
