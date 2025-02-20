using EnumsParte1.Enums;

namespace EnumsParte1.Entities;

public class Tarefa
{
    public string Nome { get; set; }
    public TarefaStatus Status { get; set; }

    public Tarefa(string nome, TarefaStatus status)
    {
        Nome = nome;
        Status = status;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Status: {Status}";
    }
}