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
		//private Cola vector;

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
			Primero = 0;
		}
		/*public Cola Vector
		{
			get { return vector; }
			set { vector = value; }
		}*/

		public void encolar()
		{
			NodoCola nodo = new NodoCola();
			Console.Write("\n Ingrese un dato\n\n");
			nodo.Dato = int.Parse(Console.ReadLine());
			nodo.Posicion = Primero;

			

			nodo.Nodo = DatosCola;

			DatosCola = nodo;
			Ultimo = Ultimo + 1;

			
			NodoCola NodoActual = new NodoCola();
			NodoActual = DatosCola;

			while(NodoActual != null)
			{
				NodoActual.Posicion = NodoActual.Posicion + 1;
				NodoActual = NodoActual.Nodo;	
			}


		}

		public void desencolar()
		{
			NodoCola NodoDesencolar = new NodoCola();
			NodoCola NodoImprimir = new NodoCola();
			NodoDesencolar = DatosCola;

			while(NodoDesencolar != null)
			{
				if(NodoDesencolar.Posicion <= Ultimo)
				{
					NodoImprimir = NodoDesencolar;
					NodoDesencolar = NodoDesencolar.Nodo;
				}
			}

			while(NodoImprimir != null)
			{
				Console.WriteLine(" " + NodoImprimir.Dato);
				NodoImprimir = NodoImprimir.Nodo;
			}
		}

	}
}
