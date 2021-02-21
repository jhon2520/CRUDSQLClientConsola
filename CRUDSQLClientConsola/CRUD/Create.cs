using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;

namespace CRUDSQLClientConsola.CRUD
{
    class Create
    {
        private readonly string connString = "Data Source=.;Initial Catalog=PrimerCrud;Integrated Security=True";
    
        
        public void CreateUser(string nombre, string correo, string fecha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = $"insert into PrimerCrudTable values ('{nombre}', '{correo}', '{fecha}')";
                    SqlDataAdapter comando = new SqlDataAdapter(query, conn);
                    comando.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                }

                Console.WriteLine("Usuario agregado exitosamente");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"error {ex.Message}");
            }


      
        }
    }
}
