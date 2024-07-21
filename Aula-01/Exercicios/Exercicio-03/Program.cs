using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());//senha que o usuário vai digitar na caixa de entrada
            int senhaCorreta = 2002;//senha correta que o usuário deve digitar na caixa de entrada

            while (senha != senhaCorreta)
            {
                System.Console.WriteLine("Senha invalida, digite novamente");
                senha = int.Parse(Console.ReadLine());
            }
            /*enquanto o usuário não digitar a senha correta, irá aparecer a mensagem "senha invalida"*/

            System.Console.WriteLine("Acesso liberado!!");//a senha que op usuário digitou está correta, assim termina a lógica do programa
        }
    }
}