using System;
using System.Collections.Generic;
using System.Text;

namespace PilasAndColas
{
	class Cola
	{
		//posicion 1 2 3 4 5 6
		// valor   8 9

		// Encolar(1, cola(0, 8))
		// Encolar(2, cola(1,9))
		private NodoCola DatosCola = new NodoCola();
		private int primero;
		private int ultimo;
		private Cola vector;

		public int Primero {
			get { return primero; }
			set { primero = value; }
		}
		public int Ultimo
		{
			get { return ultimo; }
			set { ultimo = value; }
		} 
		public Cola()
		{
			DatosCola = null;
		}
		public Cola Vector
		{
			get { return vector; }
			set { vector = value; }
		}

		public void encolar()
		{
			NodoCola nodo = new NodoCola();
			Console.Write("\n Ingrese un dato\n\n");
			nodo.Dato = int.Parse(Console.ReadLine());
			if (Vector != null)
				nodo.Posicion = Vector.Primero + 1;
			else
				nodo.Posicion = 1;

			DatosCola = nodo;
			DatosCola.Nodo = DatosCola;
			Cola cola1 = new Cola();
			cola1.Primero = nodo.Posicion - 1;
			cola1.Ultimo = nodo.Posicion;
			Vector = cola1;

		}

	}
}
