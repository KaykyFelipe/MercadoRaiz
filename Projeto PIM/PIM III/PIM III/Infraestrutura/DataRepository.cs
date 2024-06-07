using Dapper;
using PIM_III.Interfaces;
using System;
using System.Data;

namespace PIM_III.Infraestrutura
{
    public class DataRepository
    {


        //SALVAR DADOS DE CADASTROS NO DB__________________________________________________________________________________________________
        public void Cadastro_Cliente_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO cliente (email,celular,nome,senha) VALUES
                            (@email,@numero_celular,@nome,@senha);";

            var result = conn.Connection.Execute(sql: query, param: dados);


        }

        public void Cadastro_Produtor_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO produtor (email,celular,nome,senha,chave_pix) VALUES
                            (@email,@numero_celular,@nome,@senha,@chave_pix);";

            var result = conn.Connection.Execute(sql: query, param: dados);


        }

        public void Cadastro_Propriedade_DB(Usuario dados)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO propriedade (tamanho,rua,numero,bairro,cidade,estado,email_proprietario,tipo,area_plantada) VALUES
                     (@tamanho,@rua,@numero,@bairro,@cidade,@estado,@email_proprietario,@tipo,@area_plantada);";

            var result = conn.Connection.Execute(sql: query, param: dados);





        }

        //SELECT PARA VALDIAÇÃO DE LOGIN__________________________________________________________________________________________________
        public bool Login_Cliente_DB(Usuario dados)
        {
            using var conn = new DBConnection();

            string query = @"SELECT email, senha FROM cliente WHERE email = @email AND senha = @senha;";

            var result_DB_Validation = conn.Connection.QueryFirstOrDefault<string>(sql: query, param: new { email = dados.email, senha = dados.senha });

            if (result_DB_Validation != null) return true;
            else return false;

        }

        public bool Login_Produtor_DB(Usuario dados)
        {
            using var conn = new DBConnection();

            string query = @"SELECT email, senha FROM produtor WHERE email = @email AND senha = @senha;";

            var result_DB_Validation = conn.Connection.QueryFirstOrDefault<string>(sql: query, param: new { email = dados.email, senha = dados.senha });

            if (result_DB_Validation != null) return true;
            else return false;

        }


        //SELECT CONTROLE DE ESTOQUE PRODUTOR__________________________________________________________________________________________________


        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public List<DataRepository> Controle_Estoque_DB (string email)
        {
            using var conn = new DBConnection();

            string query = @"select prod.nome as Nome,
                     ce.quantidade as Quantidade,
                     ce.preco_unitario as PrecoUnitario
                     from produtor p, prodagricola prod, 
                     propriedade pro inner join plantio pl on pl.id_propriedade = pro.id 
                     inner join colheita_estoque ce on ce.id_plantio  = pl.id
                     where prod.id = pl.id_prodagricola and
                     p.email = @email;";

            var result_DB_Estoque = conn.Connection.Query<DataRepository>(sql: query, param: new { email = email }).ToList();

            return result_DB_Estoque;
        }

    }
}
