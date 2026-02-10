
namespace To_do_list
{
    class Program
    {
        static List<tarefa> tarefas = new List<tarefa>();
        static int proximoId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("To-do List");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas");
                Console.WriteLine("3. tarefa concluída");
                Console.WriteLine("4. Remover tarefa");
                Console.WriteLine("0. Sair");
                Console.WriteLine("Escolha 1");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Adicionar(); break;
                    case "2": Listar(); break;
                    case "3": Concluir(); break;
                    case "4": Remover(); break;
                    case "0": return();
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void Adicionar()
        {
            Console.WriteLine("Digite a descrição da tarefa:");
            string descricao = Console.ReadLine();
            tarefa novaTarefa = new tarefa
            {
                Id = proximoId++,
                descricao = descricao,
                concluida = false
            };
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada");
            Console.ReadLine();
        }

        static void Listar()
        {
            Console.WriteLine("\nTarefas:");

            foreach (var t in tarefas)
            {
                string status = t.concluida ? "[x]" : "[ ]";
                Console.WriteLine($"{t.Id} - {status} {t.descricao}");
            }

            Console.ReadKey();
        }
        static void Concluir()
        {
            Console.Write("ID da tarefa: ");
            int id = int.Parse(Console.ReadLine());

            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.concluida = true;
                Console.WriteLine("Tarefa concluída!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }

            Console.ReadKey();
        }

        static void Remover()
        {
            Console.WriteLine("ID da tarefa: ");
            int id = int.Parse(Console.ReadLine());

            tarefas.RemoveAll(t => t.Id == id);
            Console.WriteLine("Tarefa removida");
            Console.ReadKey();
        }
    }
}