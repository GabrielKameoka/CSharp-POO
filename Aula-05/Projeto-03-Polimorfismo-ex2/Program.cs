using System;
namespace Projeto3_5;
class Program
{
    static void Main (string[] args)
    {
        Pessoa p1 = new Pessoa("Gabriel", 20);
        Aluno a1 = new Aluno("Eduardo", 18, 9);
        p1.Apresentar();
        a1.Apresentar();
    }
}