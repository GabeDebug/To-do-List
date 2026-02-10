
using To_do_list;

List<Tarefa> tarefas = new List<Tarefa>();
int proximoId = 1;

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
        case "0": return;
        default:
            Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
            Console.ReadLine();
            break;
    }
}

void Adicionar()
{
    Console.WriteLine("Digite a descrição da tarefa:");
    string descricao = Console.ReadLine();
    Tarefa novaTarefa = new Tarefa
    {
        Id = proximoId++,
        descricao = descricao,
        concluida = false
    };
    tarefas.Add(novaTarefa);
    Console.WriteLine("Tarefa adicionada");
    Console.ReadLine();
}

void Listar()
{
    Console.WriteLine("\nTarefas:");

    foreach (var t in tarefas)
    {
        string status = t.concluida ? "[x]" : "[ ]";
        Console.WriteLine($"{t.Id} - {status} {t.descricao}");
    }

    Console.ReadKey();
}
void Concluir()
{
    Console.Write("ID da tarefa: ");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out int id))
    {
        Console.WriteLine("ID inválido!");
        Console.ReadKey();
        return;
    }

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

void Remover()
{
    Console.WriteLine("ID da tarefa: ");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out int id))
    {
        Console.WriteLine("ID inválido!");
        Console.ReadKey();
        return;
    }

    tarefas.RemoveAll(t => t.Id == id);
    Console.WriteLine("Tarefa removida");
    Console.ReadKey();
}
