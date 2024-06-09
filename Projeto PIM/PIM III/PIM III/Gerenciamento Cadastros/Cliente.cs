using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIM_III.Gerenciamento_Cadastros
{
    internal class Cliente: Usuario
    {

        public void Cadastro_Cliente()
        {
            while (true)
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                if (Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                {
                    break;
                }
                Console.WriteLine("Nome inválido. Apenas letras são permitidas.");
            }

            // Validação do número de celular
            while (true)
            {
                Console.WriteLine("Digite seu número de celular: ");
                numero_celular = Console.ReadLine();
                if (Regex.IsMatch(numero_celular, @"^[0-9\s]+$"))
                {
                    break;
                }
                Console.WriteLine("Número de celular inválido. Apenas números são permitidos.");
            }

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            // Validação da senha
            while (true)
            {
                Console.WriteLine("Crie uma senha de 5 a 10 dígitos: ");
                senha = Console.ReadLine();
                if (senha.Length >= 5 && senha.Length <= 10)
                {
                    break;
                }
                Console.WriteLine("A senha deve ter entre 5 e 10 dígitos.");
            }

            Console.WriteLine("Cadastro realizado com sucesso!");

            Console.ReadKey();
        }
    }
}

