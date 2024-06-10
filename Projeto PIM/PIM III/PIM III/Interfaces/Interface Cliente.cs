using PIM_III.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Interfaces
{
    public class Interface_Cliente
    { 
        DataRepository DataRepository = new DataRepository();



        public void Menu_Cliente()
        {
            int op;
            Console.WriteLine("1)Comprar Alimentos\n2)Relatorio de Compras\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1: Comprar_Alimentos(); break;
                    case 2: Relatorio_Compras(); break;

                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); Console.ReadKey(); Console.Clear(); continue;

                }
                continuar = false;

            }




        }


        public void Comprar_Alimentos()
        {
            Console.WriteLine("ALIMENTOS DISPONIVEIS PARA COMPRA:\n\n");

            List<DataRepository> DB = DataRepository.Select_Produtos();

            foreach (var item2 in DB)
            {
                Console.WriteLine($"ID Colheita: {item2.ID_Colheita} | Data Plantio: {item2.Data} | Nome Produto:{item2.Produto_Nome} | Estoque: {item2.Estoque} | Valor da Unidade: {item2.Valor_Produto} | Cidade: {item2.Cidade_Venda}");

            }


            Menu_Cliente();


        }
        public void Relatorio_Compras()
        {
            
                

            
        }
    }
}
