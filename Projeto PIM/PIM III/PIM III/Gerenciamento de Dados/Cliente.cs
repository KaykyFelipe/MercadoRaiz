using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Gerenciamento_de_Dados
{
    internal class Cliente: Usuario
    {

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
    }
}
