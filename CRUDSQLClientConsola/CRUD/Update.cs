using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSQLClientConsola.CRUD
{
    class Update
    {
        private readonly string connString = "Data Source=.;Initial Catalog=PrimerCrud;Integrated Security=True";
        public void UpdateUser(string nombre, string correo, string fecha, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = $"update PrimerCrudTable set nombre = @nombre, correo = @correo, fechaNacimiento = @fecha where idUsuario = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    //si se hicieran cambios según el valor de un tbx aquí se pondrían
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Usuario modificado correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
