
using PIM_III;
using PIM_III.Gerenciamento_Cadastros;
using PIM_III.Gerenciamento_Login;
using PIM_III.Infraestrutura;


//SALVAR DADOS NO BANCO
DataRepository data_base = new DataRepository();
//GERENCIAMENTO DE CADASTROS
Produtor usuario_produtor = new Produtor();
Cliente usuario_cliente = new Cliente();
//GERENCIAMENTO DE LOGIN
Login_Cliente login_cliente = new Login_Cliente();
Login_Produtor login_produtor = new Login_Produtor();



//OPÇÕES INICIAIS____________________________________________________________________________________________________________________________________________________________________
int op;

    Console.WriteLine("Bem vindo ao App MercadoRaiz!!\n\n 1)Login\n2)Cadastrar-se\n\nDigite o numero referente a opção desejada: ");
    op = int.Parse(Console.ReadLine());


//OPÇÃOLOGIN________________________________________________________________________________________________________________________________________________________________________
if (op == 1)
    {
    while (true)
    {
        Console.WriteLine("1)Login Produtor\n2)Login Cliente\n\nDigite o numero referente a opção deseja:");
        op = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            login_produtor.LoginProdutor();
            bool retorno = data_base.Login_Produtor_DB(login_produtor);
            login_produtor.Validation_LoginProdutor(retorno);
            break;

        }
        else if (op == 2)
        {

           login_cliente.LoginCliente();
           bool retorno = data_base.Login_Cliente_DB(login_cliente); 
           login_cliente.Validation_LoginCliente(retorno);
           break;

        }
        else Console.WriteLine("\n\nDigite um numero valido\n\n");

    }

}


//OPÇÃO CADASTRO____________________________________________________________________________________________________________________________________________________________________
else if (op == 2)
    {

        while (true)
        {
            Console.WriteLine("1)Produtor\n2)Cliente\n\nDigite o numero referente a opção deseja:");
            op = int.Parse(Console.ReadLine());

            if (op == 1) 
        {
            usuario_produtor.Cadastro_Produtor();

            data_base.Cadastro_Produtor_DB(usuario_produtor);
            data_base.Cadastro_Propriedade_DB(usuario_produtor);

            break; 
        
        }
            else if (op == 2)
        { 

            usuario_cliente.Cadastro_Cliente();

            data_base.Cadastro_Cliente_DB(usuario_cliente);

            break; 
        }
            else Console.WriteLine("\n\nDigite um numero valido\n\n");

        }

    }










