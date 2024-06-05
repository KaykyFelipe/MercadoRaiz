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


        public bool Cadastro_Cliente_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO cliente (email,celular,nome,senha) VALUES
                            (@email,@numero_celular,@nome,@senha);";

            var result = conn.Connection.Execute(sql: query, param: dados);

            return result == 1;
        }

        public bool Cadastro_Produtor_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO produtor (email,celular,nome,senha,chave_pix) VALUES
                            (@email,@numero_celular,@nome,@senha,@chave_pix);";

            var result = conn.Connection.Execute(sql: query, param: dados);

            return result == 1;
        }


        public bool Cadastro_Propriedade_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO propriedade (tamanho,rua,numero,bairro,cidade,estado,email_proprietario,tipo,area_plantada) VALUES
                     (@tamanho,@rua,@numero,@bairro,@cidade,@estado,@email_proprietario,@tipo,@area_plantada);";

            var result = conn.Connection.Execute(sql: query, param: dados);

            return result == 1;



        }

    }

}
