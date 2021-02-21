using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using CRUDSQLClientConsola.CRUD;
using System.Data.SqlClient;

namespace CRUDSQLClientConsola
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //crear usuario

            /*
            Create create = new Create();
            create.CreateUser("Jhon", "Jhon@123", "01/05/1995");
            */

            //Modificar usuario

            /*
            Update update = new Update();
            update.UpdateUser("Jhon Nuevo","jhonNuevo@123","01/10/1995",13);

            */
            /*

            Delete delete = new Delete();
            delete.DeleteUser(9);

            */

            /*
            Read read = new Read();
            read.ReadUsers();
            */

            //Store procedure

            StoreProcedure storeProcedure = new StoreProcedure();
            storeProcedure.RunStoreProcedure(100);

            Console.ReadKey();
        }
    }
}
