using System;

// Agregar los namespaces para la conexión con SQL Server
using System.Data;
using System.Data.SqlClient;

namespace _01___Fábrica_de_Conexiones
{
    class MyConnectionSql : MyConnection
    {
        public MyConnectionSql(DataProvider theDataProvider) : base(theDataProvider)
        {
            // Utilizando un ConnectionString para realizar la conexión
            // con el servidor SQL Server
            SqlConnection connectionString = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true;");
            try
            {
                //abrir la conexion
                connectionString.Open();

                //detalle de la conexion
                this.DetallesConexion(connectionString);
            }
            catch (SqlException e)
            {
                // desplegar mensaje de error
                Console.WriteLine("error: {0}  {1}", e.Message, e.StackTrace);
            }
            finally
            {
                //cerrar la conexion
                connectionString.Close();
                Console.WriteLine("Conexion finalizada");
            }


        }

        protected void DetallesConexion(SqlConnection connectionString)
        {
            Console.WriteLine("conexion establecida");
            Console.WriteLine("\tConection String {0}", connectionString.ConnectionString);
            Console.WriteLine("\tBase de Datos: {0}", connectionString.Database);
            Console.WriteLine("[tfuente de datos {0}", connectionString.DataSource);
            Console.WriteLine("Version del servidor: {0}", connectionString.ServerVersion);
            Console.WriteLine("\testado: {0}", connectionString.State);
            Console.WriteLine("Id estacion de trabajo: {0}", connectionString.WorkstationId);
        }
    }
}