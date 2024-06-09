using PIM_III.Gerenciamento_Cadastros;
using PIM_III.Gerenciamento_Login;
using PIM_III.Infraestrutura;
using PIM_III.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III.Menus
{
    public class Menu
    {
        //SALVAR DADOS NO BANCO
        DataRepository data_base = new DataRepository();
        //GERENCIAMENTO DE CADASTROS
        Produtor usuario_produtor = new Produtor();
        Cliente usuario_cliente = new Cliente();
        //GERENCIAMENTO DE LOGIN
        Login_Cliente login_cliente = new Login_Cliente();
        Login_Produtor login_produtor = new Login_Produtor();



        public void Menu_lobby()
        {

            int op;

            Console.WriteLine("Bem vindo ao App MercadoRaiz!!\n\n1)Login\n2)Cadastrar-se\n\nDigite o numero referente a opção desejada: ");
            op = int.Parse(Console.ReadLine()); Console.Clear();



            //OPÇÃOLOGIN________________________________________________________________________________________________________________________________________________________________________
            if (op == 1)
            {

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("1)Login Produtor\n2)Login Cliente\n3)Voltar\n\nDigite o numero referente a opção deseja:");
                    op = int.Parse(Console.ReadLine()); Console.Clear();

                    switch (op)
                    {
                        case 1:
                            login_produtor.LoginProdutor();

                            bool retorno_prod = data_base.Login_Produtor_DB(login_produtor);
                            login_produtor.Validation_LoginProdutor(retorno_prod); Console.Clear();
                            Menu_lobby();
                            
                            break;

                        case 2:

                            login_cliente.LoginCliente();

                            bool retorno_cl = data_base.Login_Cliente_DB(login_cliente);
                            login_cliente.Validation_LoginCliente(retorno_cl); Console.Clear();
                            Menu_lobby();
                            break;
                        case 3: Menu_lobby(); Console.Clear(); break;
                        default:
                            Console.WriteLine("\n\nDigite um numero valido\n\n"); continue;
                    }
                    continuar = false;
                }

            }






            //OPÇÃO CADASTRO____________________________________________________________________________________________________________________________________________________________________
            else if (op == 2)
            {

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("1)Cadastrar-se como Produtor\n2)Cadastrar-se como Cliente\n3)Voltar\n\nDigite o numero referente a opção deseja:");
                    op = int.Parse(Console.ReadLine()); Console.Clear();

                    switch (op)
                    {
                        case 1:
                            usuario_produtor.Cadastro_Produtor();

                            data_base.Cadastro_Produtor_DB(usuario_produtor);
                            data_base.Cadastro_Propriedade_DB(usuario_produtor);
                            Console.Clear(); Menu_lobby(); 

                            break;

                        case 2:

                            usuario_cliente.Cadastro_Cliente();

                            data_base.Cadastro_Cliente_DB(usuario_cliente);
                            Console.Clear(); Menu_lobby(); 

                            break;
                        case 3: Console.Clear(); Menu_lobby();  break;
                        default: Console.WriteLine("\n\nDigite um numero valido\n\n"); continue;
                    }
                    continuar = false;

                }

            }
        }
    }
}