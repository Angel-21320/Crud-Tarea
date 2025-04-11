using System.Data.SqlClient;
using System.Data;

uusing System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace miForumulario.Clases
{
    public class CrudTarea
    {
       
        private string connectionString = "Data Source=.;Initial Catalog=UMG;Integrated Security=True";

       
        public void Insertar(Tarea tarea)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tareas (Carnet, Descripcion, FechaEntrega) VALUES (@carnet, @desc, @fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@carnet", tarea.Carnet);
                cmd.Parameters.AddWithValue("@desc", tarea.Descripcion);
                cmd.Parameters.AddWithValue("@fecha", tarea.FechaEntrega);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public DataTable ObtenerTodas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tareas";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Actualizar(Tarea tarea)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tareas SET Carnet = @carnet, Descripcion = @desc, FechaEntrega = @fecha WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tarea.Id);
                cmd.Parameters.AddWithValue("@carnet", tarea.Carnet);
                cmd.Parameters.AddWithValue("@desc", tarea.Descripcion);
                cmd.Parameters.AddWithValue("@fecha", tarea.FechaEntrega);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tareas WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarPorCarnet(string carnet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tareas WHERE Carnet = @carnet";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@carnet", carnet);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
