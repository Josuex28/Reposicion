using System;
using System.Data;
using System.Data.SqlClient;

namespace Tareaaaaaaaaa222
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); //Conectarme a  la BD
        SqlCommand miComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es una representacion grafica de la BD en memoria.

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from materias";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "materias");

            miComando.CommandText = "select * from vehiculos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "vehiculos");


            return miDs;
        }
        public String mantenimientoMaterias(String[] materias)
        {
            String sql = "";
            if (materias[0] == "nuevo")
            {
                sql = "INSERT INTO materias (codigo, materia, uv) VALUES('" + materias[1] + "', '" + materias[2] + "', '" +
                    materias[3] + "')";
            }
            else if (materias[0] == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + materias[1] + "', materia='" + materias[2] + "', uv='" + materias[3] +
                    "' WHERE idMateria='" + materias[4] + "'";
            }
            else if (materias[0] == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + materias[4] + "'";
            }
            return ejecutarSql(sql);
        }
        public String mantenimientoCarro(String[] vehiculos)
        {
            String sql = "";
            if (vehiculos[0] == "nuevo")
            {
                sql = "INSERT INTO vehiculos (marca, modelo, year, num_motor, num_chasis) VALUES('" + vehiculos[1] + "', '" + vehiculos[2] + "', '" + vehiculos[3] + 
                    "', '" + vehiculos[4] + "', '" + vehiculos[5] + "')";
            }
            else if (vehiculos[0] == "modificar")
            {
                sql = "UPDATE vehiculos SET marca='" + vehiculos[1] + "', modelo='" + vehiculos[2] + "', year='" + vehiculos[3] + "', num_motor ='" + vehiculos[4] + "', num_chasis='" + vehiculos[5] +
                    "' WHERE idVehiculo='" + vehiculos[6] + "'";
            }
            else if (vehiculos[0] == "eliminar")
            {
                sql = "DELETE FROM vehiculos WHERE idVehiculo='" + vehiculos[6] + "'";
            } 
            return ejecutarSql(sql);
        }
        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
