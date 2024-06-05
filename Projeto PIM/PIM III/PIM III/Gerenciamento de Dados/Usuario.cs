using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III
{
    public class Usuario
    {


        public string nome { get; set; }
        public string numero_celular { get; set; }
        public string email { get; set; }
        public string email_proprietario { get; set; }
        public string senha { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public float tamanho { get; set; }
        public float area_plantada { get; set; }
        public string chave_pix { get; set; }

        public void inicio()
        {

            int op;

            Console.WriteLine("Bem vindo ao App MercadoRaiz!!\n\n 1)Login\n2)Cadastrar-se\n\nDigite o numero referente a opção desejada: ");
            op = int.Parse(Console.ReadLine());


            //OPÇÃOLOGIN
            if (op == 1)
            {
            }


            //OPÇÃO CADASTRO
            else if (op == 2)
            {

                while (true)
                {
                    Console.WriteLine("1)Produtor\n2)Cliente\n\nDigite o numero referente a opção deseja:");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1) { Cadastro_Produtor(); break; }
                    else if (op == 2) { Cadastro_Cliente(); break; }
                    else Console.WriteLine("\n\nDigite um numero valido\n\n");

                }

            }


        }

        public void Cadastro_Cliente()
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu numero de celular: ");
            numero_celular = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Crie uma senha de até 10 digitos: ");
            senha = Console.ReadLine();

        }

        public void Cadastro_Produtor()
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu numero de celular: ");
            numero_celular = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Crie uma senha de até 10 digitos: ");
            senha = Console.ReadLine();

            Console.WriteLine("Digite sua chave PIX para pagamentos: ");
            chave_pix = Console.ReadLine();

            Cadastro_Propriedade();

        }
        public void Cadastro_Propriedade()
        {

            Console.WriteLine("Digite sua rua: ");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o numero da sua casa: ");
            numero = Console.ReadLine();

            Console.WriteLine("Digite o seu bairro: ");
            bairro = Console.ReadLine();

            email_proprietario = email;

            Console.WriteLine("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite seu estado: ");
            estado = Console.ReadLine();

            Console.WriteLine("Digite o tipo da sua platação: ");
            tipo = Console.ReadLine();

            Console.WriteLine("Digite o tamanho da sua residencia: ");
            tamanho = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da area de plantio: ");
            area_plantada = float.Parse(Console.ReadLine());

        }

    }
}
       

