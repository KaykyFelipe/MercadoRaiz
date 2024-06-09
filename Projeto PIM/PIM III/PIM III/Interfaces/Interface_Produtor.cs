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
        DataRepository DataRepository = new DataRepository();
        string estado { get; set; }
        int alimento { get; set; }
        int area_plantio { get; set; }
        int id_plantio { get; set; }
        int quant_colhida { get; set; }
        float valor_produto { get; set; }

        int op;



        public void menu_produtor()
        {

            Console.WriteLine("1)Controle de Estoque\n2)Dicas de Plantio\n3)Vender Alimentos\n4)Relatorio\n5)Mural de Vendas\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1: Controle_Estoque();  break;
                    case 2: dicas();  break;
                    case 3: Vender_Alimentos(); break;
                    case 4: Relatorio(); break;
                    case 5: Mural_de_Vendas(); break;
                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); Console.ReadKey(); Console.Clear(); continue;

                }
                continuar = false;
                
            }
        }



        public void Controle_Estoque()
        {


            Console.WriteLine("1)Relatorio de Estoque\n2)Plantio\n3)Colheita\n4)Voltar\n\nDigite o numero referente a opção deseja:");
            bool continuar = true;
            while (continuar)
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1: RelatorioEstoque(); break;
                    case 2: Plantio(); break;
                    case 3: Colheita(); break;
                    case 4: menu_produtor(); break;
                    default: Console.WriteLine("Erro, opção inválida. Tente novamente."); continue;

                }
                continuar = false;
            }

            void RelatorioEstoque()
            {

                List<DataRepository> estoque = DataRepository.Controle_Estoque_DB(email);

                foreach (var item in estoque)
                {
                    Console.WriteLine($"Nome: {item.PRODUTO} | Quantidade: {item.Qtd_Disponivel} | Preço Unitário: {item.Preco_Produto} | ID Propriedade:{item.ID_Propriedade} | Cidade: {item.Cidade}");
                }
                Console.ReadKey();
                Console.Clear();
                menu_produtor();
            }


            void Plantio()
            {
             

                bool continuar = true;
                while (continuar)
                {
                    List<DataRepository> DB = DataRepository.Select_Produtos_Agricolas();

                    foreach (var item2 in DB)
                    {
                        Console.WriteLine($"ID: {item2.ID_PRODUTO} | PRODUTO: {item2.PRODUTO}");

                    }

                    Console.WriteLine("Digite o ID referente ao produto que irá ser plantado");
                    alimento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a area de plantio do alimento selecionado");
                    area_plantio = int.Parse(Console.ReadLine());



                    DataRepository.Cadastro_Plantio(email, alimento, area_plantio);


                    menu_produtor();
                }
            }


            void Colheita()
            {

                    List<DataRepository> DB = DataRepository.Select_Plantio_DB(email);

                    foreach (var item2 in DB)
                    {
                        Console.WriteLine($"ID PLANTIO: {item2.ID_Plantio} | Data Plantio: {item2.Data_Plantio} | Nome Produto:{item2.Nome_Produto} | Area Plantada: {item2.Area_Plantada} | ID Propriedade: {item2.IDPropriedade}");

                    }


                    Console.WriteLine("Digite o ID do plantio que será colhido");
                    id_plantio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade que será colhida:");
                    quant_colhida = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor que será vendido o produto");
                    valor_produto = float.Parse(Console.ReadLine());

                    DataRepository.Cadastro_Colheita(quant_colhida, valor_produto, id_plantio);

                    menu_produtor();
            }
            
    }

            public void dicas()
            {
                Console.WriteLine("1- Alface: Época de plantio adequado seria no Outono e primavera em temperatura que se varia entre 15°C-25°C. E deve ser plantado em um solo que receba pelo menos 4 horas de sol por dia.\r\n\n\n2- Tomate: Para o tomate não existe época, ele pode ser plantado durante o ano todo, a temperatura indicada é a de entre 15°C-24°C.\r\n\n\n3- Chuchu: Para a plantação de chuchu precisa de um local que receba bastante luz solar e o solo precisa ser rico em matéria orgânica. Temperatura ideal é entre 15°C-28°C. melhor época para plantio é Fevereiro e Outubro.\r\n\n\nn4- Cenoura: Cenouras podem ser plantadas em qualquer época do ano. Na temperatura entre 20°C-30°C. onde o solo precisa ser feito a irrigação todos os dias até a plantar aparecer no solo\r\n\n\n5- Abobrinha italiana: Os melhores meses são entre agosto e março pois são meses mais quentes do ano.Elas preferem temperaturas entre 20°C-35°C. E fazer irrigação do solo regularmente de 4 a 8 litros por cova.\r\n\n\n6- Mandioca: melhores épocas do ano são em setembro/novembro e fevereiro/março. O solo precisa ser plano ou pouco inclinado. A temperatura precisa estar entre 20°C-30°C.\r\n\n\n7- Pimentão: A melhor época para plantio é em agosto e setembro, porém se você estiver em uma região cuja a temperatura é de 21°C-27°C, pode se plantar durante o ano todo.\r\n\n\n8- Nabo: O melhor período é entre abril e maio e o período de produção dura três meses. Já a temperatura tem que ser mais fria entre 14°C-22°C.\r\n\n\n9- Rúcula: Melhor época seria entre março a julho, solo precisa ser rico em matéria orgânica e a temperatura varia de 15°C-18°C.\r\n\n\n10- Abacate: Melhor época é na Primavera, o solo precisa ser rico em matéria orgânica e adubado com bastante frequência.\r\n\n\n11- Repolho: O repolho pode ser plantado durante o ano todo. Ele se adapta a todos os tipos de solo mas prefere com fertilidade natural.\r\n\n\n12- Maçã: De julho a setembro é recomendado o plantio. A faixa ideal de temperatura é entre 18°C-23°C.\r\n\n\n13- Limão: Início de Outono ou início de primavera, pois nessas épocas o fruto se torna mais suculento. É importante deixá-lo em um local que receba bastante luz solar.\r\n\n\n14- Acerola: No início do período chuvoso. A temperatura deve ser entre 15°C-32°C, deve ser feito o plantio em solos profundos.\r\n\n\n15- Goiaba: A primavera é a época recomendada para que haja um equilíbrio entre sol e chuva que facilita o trabalho com o solo.\r\n\n\n16- Quiabo: Se você vive em uma região com temperaturas baixas, o plantio recomendado é de setembro a janeiro, já em locais com climas amenos, é de agosto a março. Recomendasse o plantio em temperaturas de 20°C-25°C.\r\n\n\n17- Pepino: Não há período ideal, pois pode ser cultivado em qualquer época do ano. A temperatura ideal é de 26°C-28°C.\r\n\n\n18- Banana: O plantio da bananeira é bom em épocas de início de chuva. Onde as temperaturas variam de 15°C-35°C.\r\n\n\n19- Mamão: Não temos época exata, desde que tenha um sistema de irrigação previamente instalado.\r\n\n\n20- Uva: Recomenda-se o plantio de julho a agosto, com a temperatura em 10°C-19°C.");
            Console.ReadKey();
            Console.Clear();
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

