
using System;
using Series.Classes;
using Series.Enum;


namespace Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizaSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcaoUsuario();
            }
            
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o Id da série que deseja visualizar: ");
            int idSerie = int.Parse(Console.ReadLine());

            var serie = repository.RetornaPorId(idSerie);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o Id da série que deseja excluir: ");
            int idSerie = int.Parse(Console.ReadLine());

            repository.Exclui(idSerie);

        }

        private static void AtualizaSerie()
        {
            Console.WriteLine("Digite o número do Id da Série que deseja atualizar: ");
            int indiceSerie = Int32.Parse(Console.ReadLine());

            Console.WriteLine("   Inserir Nova Série  ");
            Console.WriteLine("Gêneros: ");
            Console.WriteLine("1 - Acao");
            Console.WriteLine("2 - Aventura");
            Console.WriteLine("3 - Comedia");
            Console.WriteLine("4 - Documentario");
            Console.WriteLine("5 - Drama");
            Console.WriteLine("6 - Espionagem");
            Console.WriteLine("7 - Faroeste");
            Console.WriteLine("8 - Fantasia");
            Console.WriteLine("9 - Ficcao_Cientifica");
            Console.WriteLine("10 - Musical");
            Console.WriteLine("11 - Romance");
            Console.WriteLine("12 - Suspense");
            Console.WriteLine("13 - Terror");

            Console.WriteLine("Digite o gênero entre as opções a cima: ");
            int entradaGenero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o Ano de lançamento da série: ");
            int entradaAno = Int32.Parse(Console.ReadLine());

            Serie serieAtualizada = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno
                );
            repository.Atualiza(indiceSerie, serieAtualizada);

        }

        private static void InserirSerie()
        {
            Console.WriteLine("   Inserir Nova Série  ");
            Console.WriteLine("Gêneros: ");
            Console.WriteLine("1 - Acao");
            Console.WriteLine("2 - Aventura");
            Console.WriteLine("3 - Comedia");
            Console.WriteLine("4 - Documentario");
            Console.WriteLine("5 - Drama");
            Console.WriteLine("6 - Espionagem");
            Console.WriteLine("7 - Faroeste");
            Console.WriteLine("8 - Fantasia");
            Console.WriteLine("9 - Ficcao_Cientifica");
            Console.WriteLine("10 - Musical");
            Console.WriteLine("11 - Romance");
            Console.WriteLine("12 - Suspense");
            Console.WriteLine("13 - Terror");

            Console.WriteLine("Digite o gênero entre as opções a cima: ");
            int entradaGenero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o Ano de lançamento da série: ");
            int entradaAno = Int32.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repository.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno
                );
            repository.Insere(novaSerie);



        }

        private static void ListarSerie()
        {
            Console.WriteLine("   Lista de Séries     ");
            var lista = repository.List();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                if(!serie.RetornaExcluido())
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }
                
            }
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("        DIO SÉRIES         ");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;

        }
    }
}
