using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDudemy.Datos
{
    public class Conexion
    {
        private string Basededatos;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        public Conexion()
        {
            this.Basededatos = "bd_aprendizaje";
            this.Servidor = "localhost";
            this.Puerto = "5432";
            this.Usuario = "user.crud";
            this.Clave = "lacho2504";
        }

        public NpgsqlConnection CrearConexion()
        {
            NpgsqlConnection Cadena = new NpgsqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                          ";Port=" + this.Puerto +
                                          ";User id=" + this.Usuario +
                                          ";Password=" + this.Clave +
                                          ";Database=" + this.Basededatos;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
