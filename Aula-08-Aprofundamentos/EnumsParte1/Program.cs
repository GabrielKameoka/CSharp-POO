using System;
using EnumsParte1.Entities;
using EnumsParte1.Enums;

namespace EnumsParte1;

public class EnumConversionExample
{
    public static void Main ()
    {
        Tarefa tarefa1 = new Tarefa("Estudar C#", TarefaStatus.concluido);
        Tarefa tarefa2 = new Tarefa("Comer", TarefaStatus.pendente);
        Console.WriteLine(tarefa1);
        Console.WriteLine(tarefa2);
    }
}