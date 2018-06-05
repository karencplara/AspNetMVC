using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CrudAspNet.Models;

namespace AtividadeCrud.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("Clientes")
        {
            Database.SetInitializer<DBContext>
                (new DropCreateDatabaseIfModelChanges<DBContext>());
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}