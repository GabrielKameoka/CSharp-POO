using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioResolvido2.Interfaces;

namespace ExercicioResolvido2.Services
{
    public class LogDebug : ILog
    {
        public void Registrar(string mensagem)
        {
            System.Console.WriteLine($"DEBUG: {mensagem}");
        }
    }
}