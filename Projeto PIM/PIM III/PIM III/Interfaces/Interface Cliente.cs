using PIM_III.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIM_III.Interfaces
{
    public class Interface_Cliente(string email)
    { 
        DataRepository DataRepository = new DataRepository();



        public void Menu_Cliente()
        {
            int op;
            Console.WriteLine("1)Estoque Alimentos\n2)Relatorio de Compras\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1: Estoque_Alimentos(); break;
                    case 2: Relatorio_Compras(); break;

                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); Console.ReadKey(); Console.Clear(); continue;

                }
                continuar = false;

            }

        }


        public void Estoque_Alimentos()
        {
            Console.WriteLine("ALIMENTOS DISPONIVEIS PARA COMPRA:\n\n");

            List<DataRepository> DB = DataRepository.Select_Produtos();

            foreach (var item2 in DB)
            {
                Console.WriteLine($"ID Colheita: {item2.ID_Colheita} | Data Plantio: {item2.Data} | Nome Produto:{item2.Produto_Nome} | Estoque: {item2.Estoque} | Valor da Unidade: {item2.Valor_Produto} | Cidade: {item2.Cidade_Venda}");

            }

            int op;
            Console.WriteLine("\n\n1)Comprar Alimentos\n2)Voltar\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1: Comprar(); break;
                    case 2: Menu_Cliente(); Console.Clear(); break;

                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); Console.ReadKey(); continue;

                }
                continuar = false;

            }

            void Comprar() 
            {
                int id_produto;
                int quant_prod;
                DataRepository.Abertura_Pedido(email);

                while (true)
                {
                    Console.WriteLine("Digite o ID do produto que será comprado:");
                    if (int.TryParse(Console.ReadLine(), out id_produto))
                    {
                        break;
                    }
                    Console.Write("\nApenas números são permitidos!");
                }

                while (true)
                {
                    Console.WriteLine("Digite a quantidade que será comprada:");
                    if (int.TryParse(Console.ReadLine(), out quant_prod))
                    {
                        break;
                    }
                    Console.Write("\nApenas números são permitidos!");
                }

                DataRepository.Pedido_Compra(id_produto, quant_prod, email);

                Console.Write("\nPedido Realizado!!");

                Console.Clear();
                Console.ReadKey();

                Menu_Cliente();
            }

            
        }
        public void Relatorio_Compras()
        {

            List<DataRepository> DB = DataRepository.Select_Relatorio_Cliente(email);

            foreach (var item2 in DB)
            {
                Console.WriteLine($"ID Pedido: {item2.ID_Pedido} | Quantidade: {item2.Quant_Pedido} | Nome Produto:{item2.Produto_Pedido} | Preço Unitario: {item2.Preco_Pedido} | Total Compra: {item2.ValorTotal}");

            }

            Console.ReadKey();
            Console.Clear();
            Menu_Cliente();
        }
    }
}
