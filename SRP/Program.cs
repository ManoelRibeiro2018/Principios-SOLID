using System;

namespace SRP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoMenu();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        InserirAnime();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcaoMenu();
            }
        }

        private static string OpcaoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Animes On!!!!!");
            Console.WriteLine("1 - Listar usuário");
            Console.WriteLine("2 - Inserir novo usuário");
            Console.WriteLine("3 - Atualizar  usuário");
            Console.WriteLine("4 - Excluir usuário");
            Console.WriteLine("5 - Visualizar usuário");
            Console.WriteLine("C -- Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            return Console.ReadLine().ToUpper();
        }


        private static void ListarAnimes()
        {
            Console.WriteLine("Listar de usuários");

            var lista = UserRepository.GetAll();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum usuário encontrado");
                return;
            }
            foreach (var user in lista)
            {
                Console.WriteLine("#ID{0}: - {1} - {2} - {3}", user.Id, user.Name, user.LastName, user.Address);
            }
        }

        private static void InserirAnime()
        {
            Console.WriteLine("Cadastrar usuário");
          
            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Digite seu endereço: ");
            string address = Console.ReadLine();

            var user = new User(UserRepository.NextId(), name, lastName, address);

            UserRepository.Create(user);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o código do usuário: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastrar usuário");

            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Digite seu endereço: ");
            string address = Console.ReadLine();

            var user = new User(id, name, lastName, address );

            UserRepository.Update(id, user);
        }

        public static void Excluir()
        {
            Console.WriteLine("Digite o ID do usuário: ");
            int id = int.Parse(Console.ReadLine());

            UserRepository.Delete(id);
        }

        public static void Visualizar()
        {
            Console.WriteLine("Digite o ID do usuário: ");
            int id = int.Parse(Console.ReadLine());

            var serie = UserRepository.GetOne(id);

            Console.WriteLine(serie.ToString());
        }

      
    }
}
