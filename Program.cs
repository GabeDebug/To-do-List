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
            }
        }
    }
}