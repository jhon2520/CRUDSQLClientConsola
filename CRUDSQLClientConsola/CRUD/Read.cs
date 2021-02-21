using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSQLClientConsola.CRUD
{
    
    class Read
    {
        private readonly string connString = "Data Source=.;Initial Catalog=PrimerCrud;Integrated Security=True";
        public void ReadUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "select * from PrimerCrudTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    /*
                     * así se pasaría la información a un datagrid
                     datagrid.DataSource = dt;
                     */

                    foreach (DataRow item in table.Rows)
                    {
                        Console.WriteLine(item[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
