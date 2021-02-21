using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSQLClientConsola.CRUD
{
    class StoreProcedure
    {
        private readonly string connString = "Data Source=.;Initial Catalog=PrimerCrud;Integrated Security=True";
        public void RunStoreProcedure(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SelectUSer", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if(table.Rows.Count == 0)
                    {
                        Console.WriteLine("El usuario no existe, no puede ingresar, Te hace falta calle, ¡perro!");
                    }
                    else
                    {
                        foreach (DataRow item in table.Rows)
                        {
                            Console.WriteLine(item[1]);
                            Console.WriteLine("Puede pasar, señor francés");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error {ex.Message}");
            }
        }
    }
}
