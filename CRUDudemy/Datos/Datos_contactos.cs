using CRUDudemy.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CRUDudemy.Datos
{
    public class Datos_contactos
    {
        public DataTable listadoCargos()
        {
            NpgsqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            NpgsqlConnection SqlConection = new NpgsqlConnection();
            try
            {
                SqlConection = Conexion.getInstancia().CrearConexion();
                NpgsqlCommand Comando = 
                    new NpgsqlCommand("select descripcion_cargos,cargo_id from tb_cargos where activo = true;",SqlConection);
                Comando.CommandType = CommandType.Text;
                SqlConection.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(SqlConection.State == ConnectionState.Open) SqlConection.Close();
            }
        }

        public DataTable listadoContactos(string contTexto)
        {
            NpgsqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            NpgsqlConnection SqlConection = new NpgsqlConnection();
            try
            {
                SqlConection = Conexion.getInstancia().CrearConexion();
                NpgsqlCommand Comando =
                    new NpgsqlCommand("select (funcion_listado_contactos('" + contTexto + "')).*;", SqlConection);
                Comando.CommandType = CommandType.Text;
                SqlConection.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlConection.State == ConnectionState.Open) SqlConection.Close();
            }
        }

        public string guardarContacto(int nOpcion, E_Contactos contacto)
        {
            string respuesta = "";
            string SQL = "";
            string insertarSQL = "insert into tb_contactos (nombre_contacto, telefono_contacto," +
                                 "correo_contacto, fechanac_contacto, cargo_id)" +
                                 "values('"+ contacto.Nombre_contacto +"','"+ contacto.Telefono_contacto +"'," +
                                 "'"+ contacto.Correo_contacto + "', '"+ contacto.Fechanac_contacto + "', '"+ contacto.Cargo_id +"')";
            string actualizarSQL = "update tb_contactos set nombre_contacto = '"+ contacto.Nombre_contacto +"', " +
                                                           "telefono_contacto = '"+ contacto.Telefono_contacto + "', " +
                                                           "correo_contacto = '"+ contacto.Correo_contacto +"', " +
                                                           "fechanac_contacto = '"+ contacto.Fechanac_contacto +"', " +
                                                           "cargo_id = '"+ contacto.Cargo_id +"' " +
                                                           "where contacto_id = '"+ contacto.Contacto_id +"';";
            SQL = nOpcion == 1 ? insertarSQL : actualizarSQL;
            NpgsqlConnection SqlConection = new NpgsqlConnection();
            try
            {
                SqlConection = Conexion.getInstancia().CrearConexion();
                NpgsqlCommand Comando =
                    new NpgsqlCommand(SQL, SqlConection);
                Comando.CommandType = CommandType.Text;
                SqlConection.Open();
                respuesta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo registrar la información";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlConection.State == ConnectionState.Open) SqlConection.Close();
            }
            return respuesta;
        }

        public string eliminarContacto(int contacto_id)
        {
            string respuesta = "";
            //string SQL = "delete from tb_contactos where contacto_id = '"+ contacto_id +"';"; esto eliminaria del al base de datos el contacto
            string SQL = "update tb_contactos set activo = false where contacto_id = '"+ contacto_id +"';"; //esto pone el estado en false para no poder mostrar en el formulario :D
            NpgsqlConnection SqlConection = new NpgsqlConnection();
            try
            {
                SqlConection = Conexion.getInstancia().CrearConexion();
                NpgsqlCommand Comando =
                    new NpgsqlCommand(SQL, SqlConection);
                Comando.CommandType = CommandType.Text;
                SqlConection.Open();
                respuesta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el contacto";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlConection.State == ConnectionState.Open) SqlConection.Close();
            }
            return respuesta;
        }
    }
}
