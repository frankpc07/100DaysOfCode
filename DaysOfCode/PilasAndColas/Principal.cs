using System;
using System.Collections.Generic;
using System.Text;

namespace PilasAndColas
{
	class Principal
	{
		static void Main(String[] args)
		{
			/*Pila pila = new Pila();

			pila.insertarNodo();
			pila.insertarNodo();
			pila.insertarNodo();
			pila.insertarNodo();
			pila.insertarNodo();

			Console.WriteLine("\n La Pila ingresada es \n\n");
			pila.desplegarPila();

			Console.ReadLine();*/

			Cola cola = new Cola();
			
			cola.encolar();
			cola.encolar();

			Console.ReadLine();

		}
	}
}
