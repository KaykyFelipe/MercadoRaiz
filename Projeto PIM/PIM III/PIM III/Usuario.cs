using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III
{
    internal class Usuario
    {

        public string nome = null;
        private string cpf;
        private string telefone;
        private string endereço;
        private string cep;
        private string email;
        private string senha;




        //Apresentação do Programa



        public void Cadastro() {

           Console.WriteLine("Digite seu Nome: \n");
           nome = Console.ReadLine(); //GUARDAR NO BANCO DE DADOS

           Console.WriteLine("Digite seu Telefone: \n");

           Console.WriteLine("Digite seu CEP: \n");

           Console.WriteLine("Digite seu Endereço: \n");

           Console.WriteLine("Digite seu E-mail: \n");

           Console.WriteLine("Crie uma Senha Numerica de 4 digitos: \n");

        }

    }
}
