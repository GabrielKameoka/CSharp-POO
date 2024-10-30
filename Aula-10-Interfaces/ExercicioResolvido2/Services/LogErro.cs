using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioResolvido2.Interfaces;

namespace ExercicioResolvido2.Services
{
    public class LogErro : ILog
    {
        public void Registrar(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRO: {mensagem}");
            Console.ResetColor();
        }
    }
}