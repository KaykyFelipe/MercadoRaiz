using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Infraestrutura
{
    public class DataRepository
    {
        public bool Add(Usuario usuario) { 

            using var conn = new DBConnection();

            string query = @"INSERT INTO cadastros (nome,email,cpf) VALUES
                            (@nome, @email, @cpf);";

            var result = conn.Connection.Execute(sql: query, param: usuario);

            return result ==1;
        
        
        }
    }
}
