using System.Globalization;
using Votacao;

class program
{
    static List<Alderman> aldermens = new List<Alderman>();

    static void Main(string[] args)
    {
        bool getout = false;

        while (!getout)
        {
            Console.WriteLine("Olá seja bem vindo ao sistema de cadastro de vereadores da cidade de Martelandia");
            Console.WriteLine("1 - Cadastrar vereador");
            Console.WriteLine("2 - Listar vereadores");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Escolha uma opção");
            string option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    RegisterAlderman();
                    break;
                case "2":
                    ListAlderman();
                    break;
                case "3":
                    getout = true;
                    Console.WriteLine("Obrigado por usar o programa");
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }
    }
    static void RegisterAlderman ()
    {
        Console.WriteLine("===   Cadastro de Vereador   ===");
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("Partido: ");
        string politicalparty = Console.ReadLine();

        Console.Write("Idade: ");
        int age = int.Parse(Console.ReadLine());

        Alderman alderman = new Alderman(name, age, politicalparty);
        aldermens.Add(alderman);

        Console.WriteLine("Processo Concluido!!");
        Console.WriteLine();
        Console.WriteLine("Vereador cadastrado com sucesso!");

    }

    static void ListAlderman()
    {
        Console.WriteLine("===   Vereadores Cadastrados   ===");

        if (aldermens.Count == 0)
        {
            Console.WriteLine("Nenhum vereador cadastrado");
        }
        else
        {
            foreach (Alderman alderman in aldermens)
            {
                Console.WriteLine(alderman);
            }
        }
    }

}