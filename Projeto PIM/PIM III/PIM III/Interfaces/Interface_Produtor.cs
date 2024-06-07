using PIM_III.Gerenciamento_Login;
using PIM_III.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Interfaces
{
    public class Interface_Produtor(string email) //HERDAR MURAL DE VENDAS
    {
        int op;
        DataRepository DataRepository = new DataRepository();

        public void menu_produtor()
        {

            Console.WriteLine("1)Controle de Estoque\n2)Dicas de Plantio\n3)Vender Alimentos\n4)Relatorio\n5)Mural de Vendas\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: Controle_Estoque(); break;
                    case 2: dicas(); break;
                    case 3: Vender_Alimentos(); break;
                    case 4: Relatorio(); break;
                    case 5: Mural_de_Vendas(); break;
                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); continue;

                }
                continuar = false;
            }
        }



            public void Controle_Estoque()
            {

            bool continuar = true;
            Console.WriteLine("1)Relatorio de Estoque\n2)Adicionar Estoque\n\nDigite o numero referente a opção deseja:");
            
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: RelatorioEstoque(); break;
                    case 2: AddEstoque(); break;
                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); continue;

                }
                continuar = false;
            }

            void RelatorioEstoque()
             {

                List<DataRepository> estoque = DataRepository.Controle_Estoque_DB(email);

                    foreach (var item in estoque)
                    {
                        Console.WriteLine($"Nome: {item.Nome}, Quantidade: {item.Quantidade}, Preço Unitário: {item.PrecoUnitario}");
                    }
                     menu_produtor();
        }

            void AddEstoque()
            {
                
            }
                
            
               
            }

            public void dicas()
            {


                menu_produtor();
            }

            public void Vender_Alimentos()
            {

            }
            public void Relatorio()
            {

                menu_produtor();
            }
            public void Mural_de_Vendas()
            {


            }


    }
}

