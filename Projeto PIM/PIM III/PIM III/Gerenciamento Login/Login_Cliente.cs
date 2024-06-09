using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Gerenciamento_Login
{
    public class Login_Cliente : Usuario
    {
        public void LoginCliente()
        {
            

                Console.WriteLine("Digite o E-mail");
                email = Console.ReadLine();
            
                Console.WriteLine("Digite a Senha");
                senha = Console.ReadLine();


           

        }
        public void Validation_LoginCliente(bool retorno)
        {
            
                if (retorno == true)
                {

                    Console.WriteLine("Login Efetuado!!");
                   //**ACESSO A INTERFACER

                }
                else
                {
                    Console.WriteLine("Login Invalido!!");
                    Console.ReadKey();
                //**REFAZER CADASTRO(LOOP)
            }
                    
            
        }
    }
}