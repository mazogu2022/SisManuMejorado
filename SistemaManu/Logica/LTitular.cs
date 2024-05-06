using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using SistemaManu.Modelo;


namespace SistemaManu.Logica
{
    public class LTitular
    {
        public DataTable Listadotitular()
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon=Conexion.getInstancia().CrearConexion();
                string Sql_tarea = "select * from tb_titular";
                SQLiteCommand Comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado=Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State==ConnectionState.Open) SqlCon.Close();
            }
        }

        // Método para guardar un titular en la base de datos
        public void GuardarTitular(MTitular titular)
        {
            SQLiteConnection SqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                SqlCon.Open();
                string sqlQuery = @"INSERT INTO tb_titular (empresa, llama1, llama2, llama3, identificador, ruc, telefono, correo, direccion, distrito, provincia, departamento, representante, dni, comentarios, fecharegistro) 
                                    VALUES (@Empresa, @Llama1, @Llama2, @Llama3, @Identificador, @Ruc, @Telefono, @Correo, @Direccion, @Distrito, @Provincia, @Departamento, @Representante, @Dni, @Comentarios, @FechaRegistro)";
                SQLiteCommand command = new SQLiteCommand(sqlQuery, SqlCon);
                command.Parameters.AddWithValue("@Empresa", titular.empresa);
                command.Parameters.AddWithValue("@Llama1", titular.llama1);
                command.Parameters.AddWithValue("@Llama2", titular.llama2);
                command.Parameters.AddWithValue("@Llama3", titular.llama3);
                command.Parameters.AddWithValue("@Identificador", titular.identificador);
                command.Parameters.AddWithValue("@Ruc", titular.ruc);
                command.Parameters.AddWithValue("@Telefono", titular.telefono);
                command.Parameters.AddWithValue("@Correo", titular.correo);
                command.Parameters.AddWithValue("@Direccion", titular.direccion);
                command.Parameters.AddWithValue("@Distrito", titular.distrito);
                command.Parameters.AddWithValue("@Provincia", titular.provincia);
                command.Parameters.AddWithValue("@Departamento", titular.departamento);
                command.Parameters.AddWithValue("@Representante", titular.representante);
                command.Parameters.AddWithValue("@Dni", titular.dni);
                command.Parameters.AddWithValue("@Comentarios", titular.comentarios);
                command.Parameters.AddWithValue("@FechaRegistro", titular.fecharegistro);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        // Método para modificar un titular en la base de datos
        public void ModificarTitular(MTitular titular)
        {
            SQLiteConnection SqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                SqlCon.Open();
                string sqlQuery = @"UPDATE tb_titular 
                                    SET empresa = @Empresa, llama1 = @Llama1, llama2 = @Llama2, llama3 = @Llama3, identificador = @Identificador, 
                                        ruc = @Ruc, telefono = @Telefono, correo = @Correo, direccion = @Direccion, distrito = @Distrito, 
                                        provincia = @Provincia, departamento = @Departamento, representante = @Representante, dni = @Dni, 
                                        comentarios = @Comentarios, fecharegistro = @FechaRegistro 
                                    WHERE id_titular = @IdTitular";
                SQLiteCommand command = new SQLiteCommand(sqlQuery, SqlCon);
                command.Parameters.AddWithValue("@Empresa", titular.empresa);
                command.Parameters.AddWithValue("@Llama1", titular.llama1);
                command.Parameters.AddWithValue("@Llama2", titular.llama2);
                command.Parameters.AddWithValue("@Llama3", titular.llama3);
                command.Parameters.AddWithValue("@Identificador", titular.identificador);
                command.Parameters.AddWithValue("@Ruc", titular.ruc);
                command.Parameters.AddWithValue("@Telefono", titular.telefono);
                command.Parameters.AddWithValue("@Correo", titular.correo);
                command.Parameters.AddWithValue("@Direccion", titular.direccion);
                command.Parameters.AddWithValue("@Distrito", titular.distrito);
                command.Parameters.AddWithValue("@Provincia", titular.provincia);
                command.Parameters.AddWithValue("@Departamento", titular.departamento);
                command.Parameters.AddWithValue("@Representante", titular.representante);
                command.Parameters.AddWithValue("@Dni", titular.dni);
                command.Parameters.AddWithValue("@Comentarios", titular.comentarios);
                command.Parameters.AddWithValue("@FechaRegistro", titular.fecharegistro);
                command.Parameters.AddWithValue("@IdTitular", titular.id_titular);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        // Método para eliminar un titular de la base de datos
        public void EliminarTitular(int idTitular)
        {
            SQLiteConnection SqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                SqlCon.Open();
                string sqlQuery = @"DELETE FROM tb_titular WHERE id_titular = @IdTitular";
                SQLiteCommand command = new SQLiteCommand(sqlQuery, SqlCon);
                command.Parameters.AddWithValue("@IdTitular", idTitular);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        

    }
}
