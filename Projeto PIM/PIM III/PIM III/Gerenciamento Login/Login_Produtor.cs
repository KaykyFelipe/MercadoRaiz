using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Gerenciamento_Login
{
    internal class Login_Produtor: Usuario
    {

        public void LoginProdutor()
        {


            Console.WriteLine("Digite o E-mail");
            email = Console.ReadLine();

            Console.WriteLine("Digite a Senha");
            senha = Console.ReadLine();



        }
        public void Validation_LoginProdutor(bool retorno)
        {

            if (retorno == true)
            {

                Console.WriteLine("Login Efetuado!!");

                
            }
            else Console.WriteLine("Login Invalido!!");
            //**REFAZER CADASTRO (LOOP)
        }
    }
}
