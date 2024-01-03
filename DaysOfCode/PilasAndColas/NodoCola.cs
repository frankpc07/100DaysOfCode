using System;
using System.Collections.Generic;
using System.Text;

namespace PilasAndColas
{
	class NodoCola
	{
		private int dato;
		private int posicion;

		private NodoCola nodo;

		public int Dato {
			get { return dato; }
			set { dato = value; }
		}
		public int Posicion
		{
			get { return posicion; }
			set { posicion = value; }
		}

		public NodoCola Nodo
		{
			get { return nodo; }
			set { nodo = value; }
		}
	}
}
