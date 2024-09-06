using System;
namespace Projeto_05_ClasseSelada;
class Program
{
    static void Main (string[] args)
    {
        Professor proff = new Professor("Gabriel", 30, 2000.0);
        proff.Apresentar();

        Aluno aluno = new Aluno("Gabriella", 19, 8.5);
        aluno.Apresentar();
    }
}