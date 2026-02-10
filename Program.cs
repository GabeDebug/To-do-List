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
    }
}