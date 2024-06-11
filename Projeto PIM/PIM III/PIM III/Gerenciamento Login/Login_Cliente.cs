using PIM_III.Interfaces;
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
                Interface_Cliente interface_Cliente = new Interface_Cliente(email);
                Console.WriteLine("\nLogin Efetuado!!");
                Console.WriteLine("\n\n\nPressione uma tecla para retornar...");
                Console.ReadKey();
                Console.Clear();
                interface_Cliente.Menu_Cliente();
                 
                   //**ACESSO A INTERFACER

                }
                else
                {
                    Console.WriteLine("\nLogin Invalido!!");
                    Console.WriteLine("\n\n\nPressione uma tecla para retornar...");
                    Console.ReadKey();
                    Console.Clear();
                //**REFAZER CADASTRO(LOOP)
            }
                    
            
        }
    }
}