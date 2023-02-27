using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_a_BD
{
	class Conexion
	{
		private bool conected;
		private static Conexion uniqueInstance;
		private static readonly object InstanceLoker = new Object();

		private Conexion()
		{
			conected = false;
		}

		public static Conexion getInstance()
		{
			if (uniqueInstance == null)
			{
				lock (InstanceLoker)
				{
					if (uniqueInstance == null)
						Console.WriteLine("Creacion de unica instancia de Chocolate Boiler");
					uniqueInstance = new Conexion();
				}
			}
			Console.WriteLine("Regresando la instancia de Conexion");
			return uniqueInstance;
		}

		public void conectar()
        {
            if (!conected)
            {
				conected = true;
				Console.WriteLine("Conectado a la base de datos");
            }
            else
            {
				Console.WriteLine("Ya estás conectado");
            }
        }
		public void desconectar()
        {
            if (conected)
            {
				conected = false;
				Console.WriteLine("Desconectado de la base de datos");
            }
            else
            {
				Console.WriteLine("Ya estás desconectado");
            }
        }
	}
}

