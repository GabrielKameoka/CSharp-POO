using System;
class Program
{
    static void Main(string[] args)
    {
        DiasSemana ds = DiasSemana.1;
        System.Console.WriteLine(ds);
    }
    enum DiasSemana
    {
        Domingo, Segunda, Terca, Quarte, Quinta, Sexta, Sabado
    }
}