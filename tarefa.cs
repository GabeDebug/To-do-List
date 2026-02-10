using System.Runtime.InteropServices.Marshalling;

namespace To_do_list
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public required string descricao { get; set; }
        public bool concluida { get; set; }
    }
}
