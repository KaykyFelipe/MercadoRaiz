using PIM_III.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Gerenciamento_Login
{
    public class Login_Produtor: Usuario
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
                Interface_Produtor Interface_Produtor = new Interface_Produtor(email);

                Console.WriteLine("\nLogin Efetuado!!");

                Console.WriteLine("\n\n\nPressione uma tecla para retornar...");
                Console.ReadKey();
                Console.Clear();
                Interface_Produtor.menu_produtor();
                
            }
            else Console.WriteLine("\nLogin Invalido!!");
            Console.WriteLine("\n\n\nPressione uma tecla para retornar...");
            Console.ReadKey();
            Console.Clear();
            //**REFAZER CADASTRO (LOOP)
        }
    }
}
