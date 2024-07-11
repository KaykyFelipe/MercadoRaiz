using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Infraestrutura
{
    internal class DBConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DBConnection() { 
         Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PIM;User Id=postgres;Password=dbadmin");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
