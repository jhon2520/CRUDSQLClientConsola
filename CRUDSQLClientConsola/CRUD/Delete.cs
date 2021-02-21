using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSQLClientConsola.CRUD
{
    class Delete
    {
        private readonly string connString = "Data Source=.;Initial Catalog=PrimerCrud;Integrated Security=True";
        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = $"delete from PrimerCrudTable where idUsuario = {id}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                }
                Console.WriteLine("Ususario eliminado correctamente");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"error {ex.Message}"); ;
            }
 
        }
    }
}
