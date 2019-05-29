using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Fábrica_de_Conexiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Una sencilla fábrica de conexiones *****");

            // Crear, establecer utilizar y luego cerrar la conexíón
            MyConnection miconexion = new MyConnection(DataProvider.SQLServer);
            miconexion.Conectar();
            miconexion.TipoDeConexion();

            // Realizar una pausa
            Console.Read();
        }
    }
}
