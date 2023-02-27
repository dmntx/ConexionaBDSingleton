using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_a_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion nuevaBD = Conexion.getInstance();
            Conexion base2 = Conexion.getInstance();

            nuevaBD.conectar(); //Conectado la bd desde el primer objeto
            base2.conectar(); //intentando conectar la bd desde el segundo objeto

            base2.desconectar(); //desconectado la bd desde el segundo objeto
            nuevaBD.desconectar(); //intentando desconectar la bd desde el primero objeto
            Console.ReadKey();
        }
    }
}
