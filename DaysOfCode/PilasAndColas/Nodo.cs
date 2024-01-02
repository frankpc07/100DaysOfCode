using System;
using System.Collections.Generic;
using System.Text;

namespace PilasAndColas
{
	class Nodo
	{
		private int dato;
		private Nodo siguiente;

		public int Dato
		{
			get { return dato; }
			set { dato = value; }
		}

		public Nodo Siguiente
		{
			get { return siguiente; }
			set { siguiente = value; }
		}

	}
}
