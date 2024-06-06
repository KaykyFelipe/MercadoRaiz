using PIM_III;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

internal class Produtor : Usuario
{
    public void Cadastro_Produtor()
    {
        while (true)
        {
            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();
            if (Regex.IsMatch(nome, @"^[\p{L}\p{M}]+$"))
            {
                break;
            }
            Console.Write("\nNome inválido! Apenas letras são permitidas.");
        }

        while (true)
        {
            Console.Write("\nDigite seu número de celular: ");
            numero_celular = Console.ReadLine();
            if (Regex.IsMatch(numero_celular, @"^[0-9\s]+$"))
            {
                break;
            }
            Console.Write("Número de celular inválido! Apenas números são permitidos!");
        }

        while (true)
        {
            Console.Write("\nDigite seu email: ");
            email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email))
            {
                break;
            }
            Console.Write("\nO email não pode estar vazio! Por favor, digite novamente.");
        }

        while (true)
        {
            Console.Write("\nCrie uma senha de 5 a 10 dígitos: ");
            senha = Console.ReadLine();
            if (senha.Length >= 5 && senha.Length <= 10)
            {
                break;
            }
            Console.Write("\nA senha deve ter entre 5 e 10 dígitos!");
        }

        while (true)
        {
            Console.Write("\nDigite sua chave PIX para pagamentos: ");
            chave_pix = Console.ReadLine();
            if (!string.IsNullOrEmpty(chave_pix))
            {
                break;
            }
            Console.Write("\nA chave PIX não pode estar vazia! Por favor, digite novamente.");
        }
        Cadastro_Propriedade();
    }

    public void Cadastro_Propriedade()
    {
        while (true)
        {
            Console.Write("\nDigite sua rua: ");
            rua = Console.ReadLine();
            if (Regex.IsMatch(rua, @"^[\p{L}\p{M}\s]+$"))
            {
                break;
            }
            Console.Write("\nNome da rua inválido! Apenas letras são permitidas!");
        }

        int numero;
        while (true)
        {
            Console.Write("\nDigite o número da sua casa: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                break;
            }
            Console.Write("\nNúmero da residência inválido! Apenas números são permitidos!");
        }
        Console.WriteLine($"Número da residência: {numero}");

        while (true)
        {
            Console.Write("\nDigite o seu bairro: ");
            bairro = Console.ReadLine();
            if (Regex.IsMatch(bairro, @"^[\p{L}\p{M}\s]+$"))
            {
                break;
            }
            Console.Write("\nNome do bairro inválido! Apenas letras são permitidas!");
        }

        while (true)
        {
            Console.Write("\nDigite sua cidade: ");
            cidade = Console.ReadLine();
            if (Regex.IsMatch(cidade, @"^[\p{L}\p{M}\s]+$"))
            {
                break;
            }
            Console.Write("\nNome da cidade inválido! Digite novamente!");
        }

        string[] siglasEstados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

        while (true)
        {
            Console.Write("\nDigite a UF do seu estado: ");
            string siglaUsuario = Console.ReadLine().ToUpper();

            if (Array.Exists(siglasEstados, s => s == siglaUsuario))
            {
                Console.WriteLine("Sigla de estado válida.");
                break;
            }
            else
            {
                Console.WriteLine("Sigla de estado inválida. Por favor, digite novamente.");
            }
        }

        Console.Write("\nDigite o tipo da sua plantação: ");
        tipo = Console.ReadLine();

        Console.Write("\nDigite o tamanho da sua residência: ");
        tamanho = float.Parse(Console.ReadLine());

        Console.Write("\nDigite o tamanho da área de plantio: ");
        area_plantada = float.Parse(Console.ReadLine());
    }
}



