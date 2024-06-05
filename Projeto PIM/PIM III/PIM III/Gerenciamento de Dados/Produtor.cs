using PIM_III.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIM_III.Gerenciamento_de_Dados
{
    internal class Produtor : Usuario
    {
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
            numero = int.Parse(Console.ReadLine());

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

