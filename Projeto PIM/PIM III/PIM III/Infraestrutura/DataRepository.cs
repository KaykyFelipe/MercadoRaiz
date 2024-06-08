using Dapper;
using PIM_III.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
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


        public List<DataRepository> Controle_Estoque_DB(string email)
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
        public string PRODUTO { get; set; }
        public int ID_PRODUTO { get; set; }
        public List<DataRepository> Select_Produtos_Agricolas()
        {
            using var conn = new DBConnection();

            string query = @"select id as ID_PRODUTO, nome as PRODUTO from prodagricola;";

            var result_DB_Plantio = conn.Connection.Query<DataRepository>(sql: query, param: new {}).ToList();

            return result_DB_Plantio;
        }

        public void Cadastro_Plantio(string email, int id_produto, int plantio)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO plantio (data_plantio, id_propriedade, id_prodagricola, area) values 
                   (CURRENT_TIMESTAMP, (SELECT p.id FROM propriedade p WHERE @email = p.email_proprietario),
                   @alimento,
                   @area_plantio);";

            var result = conn.Connection.Execute(sql: query, param: new { email = email, alimento = id_produto, area_plantio = plantio });



        }

        public DateTime Data_Plantio { get; set; }
        public string Nome_Produto { get; set; }
        public int Area_Plantada { get; set; }
        public int IDPropriedade { get; set; }
        public int ID_Plantio { get; set; }

        public List<DataRepository>Select_Plantio_DB(string email)
        {
            using var conn = new DBConnection();

            string query2 = @"select pl.id as ID_Plantio, pl.data_plantio as Data_Plantio, prd.nome as Nome_Produto, pl.area as Area_Plantada, p.id as IDPropriedade
                                from propriedade p 
                                inner join plantio pl on pl.id_propriedade = p.id
                                inner join prodagricola prd on prd.id = pl.id_prodagricola
                                where p.id = (select p.id from propriedade p where email_proprietario = @email);";

            var result_DB_Plantio = conn.Connection.Query<DataRepository>(sql: query2, param: new { email = email }).ToList();

            return result_DB_Plantio;
        }

        public void Cadastro_Colheita(int quant_colhida,float valor_produto,int id_plantio)
        {

            using var conn = new DBConnection();

            string query = @"INSERT INTO colheita_estoque 
                            (data_colheita, quantidade, preco_unitario, id_plantio) VALUES
                            (CURRENT_TIMESTAMP ,@quant_colhida ,@valor_produto , @id_plantio);";

            var result = conn.Connection.Execute(sql: query, param: new {  quant_colhida= quant_colhida, valor_produto = valor_produto,id_plantio = id_plantio});



        }

    }
}
