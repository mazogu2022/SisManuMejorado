using System;
using System.Data.SQLite;

namespace SistemaManu.Logica
{
    public class Conexion
    {
        private string Basedatos;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Basedatos = "./bdescritos.db";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            try
            {
                Cadena.ConnectionString="Data Source=" + this.Basedatos;
            }
            catch (Exception ex)
            {

                Cadena=null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
